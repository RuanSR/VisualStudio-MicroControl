using System;
using System.IO;

namespace MicroControl.Class
{
    public class Initializing
    {
        private PathSys PathSys = new PathSys();
        public void CheckPath()
        {
            if (!PathSys.CheckRootFolder())
            {
                Directory.CreateDirectory(PathSys.pathRootFolder);
            }
            if (!PathSys.CheckSettingsFile())
            {
                File.Create(PathSys.pathSettingsFile);
            }
        }
    }
}
