using System;
using System.Windows.Forms;

namespace IslahGroupInventory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var loginForm = new Login();
            //loginForm.FormClosed += FormClosed;
            //loginForm.Show();

            var mainForm = new MainForm();
            mainForm.FormClosed += FormClosed;
            mainForm.Show();

            Application.Run();
        }

        static void FormClosed(Object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
