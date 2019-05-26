using System.IO;

namespace MicroControl.Class
{
    public class Initializing
    {
        private PathSys PathSys = new PathSys();
        public void CheckPath(string data)
        {
            if (!PathSys.CheckRootFolder())
            {
                Directory.CreateDirectory(PathSys.pathRootFolder);
            }
            if (!PathSys.CheckSettingsFile())
            {
                File.WriteAllText(PathSys.pathSettingsFile, data);
            }
            else
            {
                if (File.ReadAllText(PathSys.pathSettingsFile) == "")
                {
                    File.WriteAllText(PathSys.pathSettingsFile, data);
                }
            }
        }
        public void WriteDataLogin(string data)
        {
            File.WriteAllText(PathSys.pathSettingsFile, data);
        }
        public string[] Settings() {
            string[] data_read = { File.ReadAllText(PathSys.pathSettingsFile) };
            string[] data_file = null;
            foreach (var item in data_read)
            {
                data_file = item.Split('|');
            }
            return data_file;
        }
    }
}
