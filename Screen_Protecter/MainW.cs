using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Protecter
{
    public partial class MainW : Form
    {
        public MainW()
        {
            InitializeComponent();
            GlobalData.passwd_G = String.Empty;
            Lock_b.Enabled = false;
        }
        public static class GlobalData
        {
            public static string passwd_G { get; set; }
        }

        private void Lock_b_Click(object sender, EventArgs e)
        {
            runner();
        }

        private void runner()
        {
            Program.d_release();
            Thread t1 = new Thread(start_l_1);
            t1.Start();
            this.Close();
        }
        private void start_l_1()
        {
            GlobalData.passwd_G = Pwd.Text;
            Program.Start_lock();
            
        }

        private void Pwd_TextChanged(object sender, EventArgs e)
        {
            if (Pwd.Text!=String.Empty)
            {
                Lock_b.Enabled = true;
            }
            else
            {
                Lock_b.Enabled = false;
            }
        }

        private void Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runner();
            }
        }
    }
}
