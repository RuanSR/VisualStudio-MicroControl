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
