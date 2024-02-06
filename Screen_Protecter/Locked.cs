using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Protecter
{
    public partial class Locked : Form
    {
        public string passwd=String.Empty;
        public int incorrect_counter = 0;
        public Locked()
        {
            InitializeComponent();
            this.TopMost = true;
            SHOW_incorrect.Hide();
            Thread thread = new Thread(Loop_thread);
            thread.Start();
        }
        
        [DllImport("cfuncs.dll")]
        public static extern void hooker();

        [DllImport("cfuncs.dll")]
        public static extern void unhooker();

        static void Loop_thread()
        {
            hooker();
        }
        private void Locked_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            passwd = Screen_Protecter.MainW.GlobalData.passwd_G;
        }

        private void Pwd_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkup_pwd();
            }
        }

        private void checkup_pwd()
        {
            if (passwd.Equals(Pwd_input.Text))
            {
                SHOW_incorrect.Hide();
                unhooker();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show(Pwd_input.Text, "密码错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SHOW_incorrect.Show();
                incorrect_counter++;
                SHOW_incorrect.Text = SHOW_incorrect.Text.Substring(0,6)+incorrect_counter+$" 最后尝试时间：{DateTime.Now}";
            }
        }

        private void Locked_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && ModifierKeys == Keys.Alt)
            {
                e.Cancel = true;
            }
        }

        private void Pwd_input_TextChanged(object sender, EventArgs e)
        {
            len_s.Text = len_s.Text.Substring(0, 4) + Pwd_input.Text.Length;
        }
    }
}
