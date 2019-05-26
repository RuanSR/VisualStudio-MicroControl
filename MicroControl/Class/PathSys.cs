using System;
using System.IO;

namespace MicroControl.Class
{
    public class PathSys
    {
        public string pathRootFolder { get; private set; }
        public string pathSettingsFile { get; private set; }

        public PathSys()
        {
            pathRootFolder = @"C:\R.S.R Software\Micro Control";
            pathSettingsFile = @"C:\R.S.R Software\Micro Control\settings";
        }
        public bool CheckRootFolder()
        {
            if (File.Exists(pathRootFolder))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckSettingsFile()
        {
            if (File.Exists(pathSettingsFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ExistDataSettingsFile()
        {
            if (string.IsNullOrEmpty(File.ReadAllText(pathSettingsFile)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
