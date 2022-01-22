using cryptOS;
using FileContainerUI;
using System;
using System.Windows.Forms;

namespace TcpSendFiles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new FirstForm());
            //Application.Run(new Verification());
            //Application.Run(new mainForm());
            //Application.Run(new FileContainerEditForm());

        }
    }
}
