using System;
using System.Windows.Forms;
using MCL;
using MicroControl.Class;
using System.Diagnostics;


namespace MicroControl
{
    public partial class mainForm : Form
    {
        Initializing initializing = new Initializing();
        PathSys pathSys = new PathSys();
        Command cmd = new Command();
        DB dataBase;
        Micro micro;
        string microID;
        public mainForm(string microID = null)
        {
            InitializeComponent();
            dataBase = new DB();
            this.microID = microID;
        }
            //SÁMERDA DEU TRABALHO!\\
        private void MainForm_Load(object sender, EventArgs e)
        {
            NotifyLoad();
            LoadData();
            timeUpdate.Start();
        }
        private async void LoadData()
        {
            try
            {
                if (dataBase.ConnectServer())
                {
                    var micro = await dataBase.GetMicroServer(microID);
                    this.micro = micro;
                    this.Text = ":: " + micro.NameMicro.ToUpper() + " ::";
                    txtID.Text = micro.IDMicro.ToString(); ;
                    txtMicroName.Text = micro.NameMicro;
                    txtStatus.Text = micro.StatusMicro.ToString();
                    txtLastCommand.Text = micro.CommandMicro.ToString();
                    initializing.WriteDataLogin(string.Format("{0}|{1}|{2}|{3}", micro.IDMicro, micro.NameMicro, micro.StatusMicro, micro.CommandMicro));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro em LoadData: "+ex.Message);
                dataBase.UpdateMicro(txtID.Text, micro);
                txtLog.AppendText("ERROR : CONNECTION \n"+ex.Message);
                txtLastCommand.Text = "-" + micro.CommandMicro.ToString();
                timeUpdate.Start();
            }
        }
        private void TimeUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                timeUpdate.Stop();
                LoadData();

                if (micro.CommandMicro == 1)
                {
                    cmd.SHUTDOWN();
                    dataBase.UpdateMicro(txtID.Text, micro);
                }
                else if (micro.CommandMicro == 2)
                {
                    cmd.SET_BG(micro.ComplementMicro, true);
                    dataBase.UpdateMicro(txtID.Text, micro);
                }
                else if (micro.CommandMicro == 3)
                {
                    MessageBox.Show(micro.ComplementMicro);
                    dataBase.UpdateMicro(txtID.Text, micro);
                }else if (micro.CommandMicro == 99)
                {
                    using (Process initUpdate = new Process())
                    {
                        dataBase.UpdateMicro(txtID.Text, micro);
                        initUpdate.StartInfo.FileName = pathSys.pathUpdateProcess;
                        initUpdate.StartInfo.CreateNoWindow = true;
                        initUpdate.Start();
                        Application.Exit();
                    }
                }
                initializing.WriteDataLogin(string.Format("{0}|{1}|{2}|{3}", micro.IDMicro, micro.NameMicro, micro.StatusMicro, 0));
                timeUpdate.Start();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro em ao passar comando! "+ex.Message);
                dataBase.UpdateMicro(txtID.Text, micro);
                txtLog.AppendText("ERROR : COMMAND \n" + ex.Message);
                txtLastCommand.Text = "-"+micro.CommandMicro.ToString();
                timeUpdate.Start();
            }
        }
        private void NotifyLoad()
        {
            //notifyIcon.BalloonTipTitle = "Micro Control";
            //notifyIcon.BalloonTipText = "Controle do Instrutor";
            notifyIcon.Text = "Micro Control";
        }
        private void HideForm()
        {
            this.Hide();
            notifyIcon.Visible = true;
            //notifyIcon.ShowBalloonTip(1000);
            //if (WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //    notifyIcon.Visible = true;
            //    notifyIcon.ShowBalloonTip(1000);
            //}
            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon.Visible = false;
            //}
        }
        private void LblHide_Click(object sender, EventArgs e)
        {
            HideForm();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            HideForm();
        }
        private void LblDisconnect_Click(object sender, EventArgs e)
        {
            timeUpdate.Stop();
            System.IO.File.WriteAllText(pathSys.pathSettingsFile, "0|0|0|null");
            new initForm().Show();
        }
    }
}
