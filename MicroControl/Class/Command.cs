using System.Runtime.InteropServices;
using System;
using System.Diagnostics;

namespace MicroControl.Class
{
    public class Command
    {
        /*
        * Este trecho de código foi retirado do site:
        * http://csharphelper.com/blog/2017/01/set-the-windows-desktop-picture-in-c/
        * Tanks! ;)
        */
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

        private const uint SPI_SETDESKWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x1;
        private const uint SPIF_SENDWININICHANGE = 0x2;
        /*
        * DisplayPicture()
        * Este método foi retirado do site:
        * http://csharphelper.com/blog/2017/01/set-the-windows-desktop-picture-in-c/
        * Tanks! ;)
        */
        public void SET_BG(string file_name, bool update_registry)
        {
            try
            {
                // If we should update the registry,
                // set the appropriate flags.
                uint flags = 0;
                if (update_registry)
                    flags = SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE;

                // Set the desktop background to this file.
                if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0, file_name, flags))
                {
                    Console.WriteLine("SystemParametersInfo failed.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao definir BG: "+ex.Message);
            }
        }
        public void SHUTDOWN(string time)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine("shutdown -s -t "+time+"");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no comando SHUTDOWN: "+ex.Message);
            }
        }
    }
}
