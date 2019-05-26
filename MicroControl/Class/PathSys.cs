using System;
using System.IO;

namespace MicroControl.Class
{
    public class PathSys
    {
        public string pathRootFolder { get; private set; }
        public string pathFolderUpdate { get; private set; }
        public string pathUpdateProcess { get; private set; }
        public string pathRootAppProcess { get; private set; }
        public string pathAppProcess { get; private set; }
        public string pathSettingsFile { get; private set; }
        
        
        public PathSys()
        {
            pathRootFolder = @"C:\R.S.R Software\Micro Control";
            pathSettingsFile = @"C:\R.S.R Software\Micro Control\settings";
            pathFolderUpdate = @"C:\R.S.R Software\Micro Control\update";
            pathRootAppProcess = @"C:\R.S.R Software\Micro Control\app\";
            pathUpdateProcess = @"C:\R.S.R Software\Micro Control\update\MCUpdate.exe";
            pathAppProcess = @"C:\R.S.R Software\Micro Control\app\MicroControl.exe";
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
        public bool CheckPathFolderUpdate()
        {
            if (File.Exists(pathFolderUpdate))
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
