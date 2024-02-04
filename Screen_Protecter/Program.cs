using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Protecter
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainW());
        }

        public static async void Start_lock()
        {
            Locked l_screen = new Locked();
            l_screen.ShowDialog();
        }

        public static void d_release()
        {
            string dllpath = Environment.CurrentDirectory + "\\cfuncs.dll";
            if (!(File.Exists(dllpath)))
            {
                using (Stream dllStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Screen_Protecter.cfuncs.dll"))
                {
                    string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dllpath);
                    File.WriteAllBytes(dllPath, ReadFully(dllStream));
                }
            }
        }
        static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
