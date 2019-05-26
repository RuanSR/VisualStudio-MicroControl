using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.ComponentModel;
using MicroControl.Class;
using System.IO.Compression;
using System.IO;

namespace MCUpdate
{
    public partial class frmUpdate : Form
    {
        PathSys pathSys = new PathSys();
        WebClient wc = new WebClient();
        private HttpClient client = new HttpClient();
        public string newVersion;
        public string newVersionNameUpdate;
        public string fileLinkUpdate;
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            statusLabel.Text = string.Empty;
            statusLabel2.Text = string.Empty;
            CheckUpdate();
        }
        private async void CheckUpdate()
        {
            try
            {
                string[] downData = { await client.GetStringAsync("https://pastebin.com/raw/C1bLqj8n") };
                string[] dataDown = null;
                foreach (string data in downData)
                {
                    dataDown = data.Split('|');
                }
                fileLinkUpdate = dataDown[0];
                newVersion = dataDown[1];
                DownloadUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método CheckUpdates(). Detalhes: " + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                StartMC();
            }
        }
        public void DownloadUpdate()
        {
            Uri uri = new Uri(fileLinkUpdate);
            wc.DownloadFileAsync(uri, pathSys.pathRootFolder+ @"\" + "MicroControl_" +newVersion + ".zip");
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }
        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (progressBar.Value == progressBar.Maximum)
            {
                progressBar.Value = 0;
            }
            statusLabel.Text = e.ProgressPercentage.ToString() + "%";
        }
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            statusLabel.Text = "Download Completed";
            statusLabel2.Text = "Installing...";
            if (e.Error == null)
            {
                InstallUpdate();
                System.Diagnostics.Process.Start(pathSys.pathAppProcess);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        void InstallUpdate()
        {
            string zipPath = pathSys.pathRootFolder + @"\" + "MicroControl_" + newVersion + ".zip";
            string extractPath = pathSys.pathRootAppProcess;
            File.Delete(pathSys.pathRootAppProcess);
            Directory.CreateDirectory(extractPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
        void StartMC()
        {
            using (System.Diagnostics.Process initUpdate = new System.Diagnostics.Process())
            {
                initUpdate.StartInfo.FileName = pathSys.pathAppProcess;
                initUpdate.StartInfo.CreateNoWindow = true;
                initUpdate.Start();
                Application.Exit();
            }
        }
    }
}
