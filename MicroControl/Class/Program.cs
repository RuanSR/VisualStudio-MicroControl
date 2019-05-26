using System;
using System.Windows.Forms;
using Microsoft.Win32;

using MicroControl.Class;

namespace MicroControl
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run",true);
            reg.SetValue("Micro Control", Application.ExecutablePath.ToString());

            PathSys pathSys = new PathSys();
            Initializing init = new Initializing();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            init.CheckPath("0|0|0|null");
            if (init.Settings()[0] != "0")
            {
                Application.Run(new mainForm(init.Settings()[0]));
            }
            else
            {
                Application.Run(new initForm());
            }
        }
    }
}
