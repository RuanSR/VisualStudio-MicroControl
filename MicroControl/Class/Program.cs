using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PathSys pathSys = new PathSys();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (pathSys.CheckSettingsFile())
            {
                Application.Run(new mainForm());
            }
            else
            {
                Application.Run(new initForm());
            }
        }
    }
}
