using System;
using System.Windows.Forms;
using MCL;
using MicroControl.Class;
using System.Diagnostics;
using System.Drawing;
using System.Management;

namespace MicroControl
{
    public partial class mainForm : Form
    {
        Initializing initializing = new Initializing();
        PathSys pathSys = new PathSys();
        Command cmd = new Command();
        DB dataBase;
        DBInfo dbInfo;
        Micro micro;
        //string microID;
        public mainForm()
        {
            InitializeComponent();
            dataBase = new DB();
            
            //this.microID = microID;
        }
            //SÁMERDA DEU TRABALHO!\\
        private void MainForm_Load(object sender, EventArgs e)
        {
            NotifyLoad();
            AutenticationMicro();
        }
        private async void LoadData()
        {
            try
            {
                if (dataBase.ConnectServer())
                {
                    var micro = await dataBase.GetMicroServer(1);
                    this.micro = micro;
                    this.Text = ":: " + micro.NameMicro.ToUpper() + " ::";
                    txtID.Text = micro.IDMicro.ToString(); ;
                    txtMicroName.Text = micro.NameMicro;
                    txtStatus.Text = micro.StatusMicro.ToString();
                    txtLastCommand.Text = micro.CommandMicro.ToString();
                    //initializing.WriteDataLogin(string.Format("{0}|{1}|{2}|{3}", micro.IDMicro, micro.NameMicro, micro.StatusMicro, micro.CommandMicro));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro em LoadData: "+ex.Message);
                dataBase.UpdateMicro(micro);
                txtLog.AppendText("ERROR : CONNECTION \n"+ex.Message);
                txtLastCommand.Text = "-" + micro.CommandMicro.ToString();
                timeUpdate.Start();
            }
        }
        private void TimeUpdate_Tick(object sender, EventArgs e)
        {
            
            timeUpdate.Stop();
            //timerSync.Stop();
            try
            {
                GetDataMicroInfo();
                if (micro.CommandMicro == 1)
                {
                    cmd.SHUTDOWN(micro.ComplementMicro);
                    //dataBase.UpdateMicro(micro);
                }
                else if (micro.CommandMicro == 2)
                {
                    cmd.SET_BG(micro.ComplementMicro, true);
                    //dataBase.UpdateMicro(micro);
                }
                else if (micro.CommandMicro == 3)
                {
                    //dataBase.UpdateMicro(micro);
                    MessageBox.Show(micro.ComplementMicro);
                }
                else if (micro.CommandMicro == 99)
                {
                    using (Process initUpdate = new Process())
                    {
                        dataBase.UpdateMicro(micro);
                        initUpdate.StartInfo.FileName = pathSys.pathUpdateProcess;
                        initUpdate.StartInfo.CreateNoWindow = true;
                        initUpdate.Start();
                        Application.Exit();
                    }
                }
                //initializing.WriteDataLogin(string.Format("{0}|{1}|{2}|{3}", micro.IDMicro, micro.NameMicro, micro.StatusMicro, 0));
                dataBase.UpdateMicro(micro);
                //SyncStatus();
                timeUpdate.Start();
                //timerSync.Start();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro em ao passar comando! "+ex.Message);
                dataBase.UpdateMicro(micro);
                txtLog.AppendText("ERROR : COMMAND \n" + ex.Message);
                txtLastCommand.Text = "-"+micro.CommandMicro.ToString();
                //SyncStatus();
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
        private void SyncStatus()
        {
            micro.StatusMicro = 1;
            dataBase.UpdateMicro(micro);
        }
        async void AutenticationMicro()
        {
            var db_info = await dataBase.GetIDServer();
            this.dbInfo = db_info;
            int i = 1;
            int count = dbInfo.count;
            if (count > 0)
            {
                while (i <= count)
                {
                    var micro = await dataBase.GetMicroServer(i);
                    this.micro = micro;
                    if (this.micro.SerialLogin.Equals(GetSerialMicro()))
                    {
                        //SyncStatus();
                        this.micro.NameMicro = GetPcName();
                        dataBase.UpdateMicroInfo(this.micro);

                        this.Text = ":: " + micro.NameMicro.ToUpper() + " ::";
                        txtID.Text = micro.IDMicro.ToString();
                        txtMicroName.Text = micro.NameMicro;
                        txtStatus.Text = micro.StatusMicro.ToString();
                        txtLastCommand.Text = micro.CommandMicro.ToString();
                        lblConn.ForeColor = Color.Green;
                        timeUpdate.Start();
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (i > count || count == 0)
            {
                Micro newMicro = new Micro
                {
                    IDMicro = count+1,
                    SerialLogin = GetSerialMicro(),
                    NameMicro = GetPcName(),
                    StatusMicro = 0,
                    CommandMicro = 0,
                    ComplementMicro = "null"
                };
                dataBase.InsertMicro(newMicro);
                AutenticationMicro();
                //txtLog.AppendText("Nenhum espaço no servidor!\n");
                //lblConn.Text = "Connect";
                //lblConn.ForeColor = Color.Red;
            }
            timeUpdate.Start();
        }
        async void AutenticationServer()
        {
            //var db_info = await dataBase.GetIDServer();
            //this.dbInfo = db_info;

            //int i = 1;
            //int count = dbInfo.count;
            //while (i <= count)
            //{
            //    var micro = await dataBase.GetMicroServer(i);
            //    this.micro = micro;
            //    if (!this.micro.ConnectedMicro)
            //    {
            //        this.micro.NameMicro = GetPcName();
            //        this.micro.ConnectedMicro = true;
            //        dataBase.UpdateMicroInfo(this.micro);

            //        this.Text = ":: " + micro.NameMicro.ToUpper() + " ::";
            //        txtID.Text = micro.IDMicro.ToString();
            //        txtMicroName.Text = micro.NameMicro;
            //        txtStatus.Text = micro.StatusMicro.ToString();
            //        txtLastCommand.Text = micro.CommandMicro.ToString();
            //        lblConn.ForeColor = Color.Green;


            //        timeUpdate.Start();
            //        break;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            //if (i > count)
            //{
            //    txtLog.AppendText("Nenhum espaço no servidor!\n");
            //    lblConn.Text = "Connect";
            //    lblConn.ForeColor = Color.Red;
            //}
            //timeUpdate.Start();
        }
        async void GetDataMicroInfo()
        {
            int i = 1;
            while (i <= this.dbInfo.count)
            {
                if (this.micro.IDMicro == i)
                {
                    var micro = await dataBase.GetMicroServer(i);
                    this.micro = micro;
                    txtStatus.Text = micro.StatusMicro.ToString();
                    txtLastCommand.Text = micro.CommandMicro.ToString();
                    lblConn.ForeColor = Color.Green;
                    break;
                }
                else
                {
                    i++;
                }
            }
            if (i > this.dbInfo.count)
            {
                txtLog.AppendText("Erro ao atualizar dados!\n");
            }
            timeUpdate.Start();
        }
        private string GetSerialMicro()
        {
            return GetSerialHD() + GetPcName();
        }
        string GetSerialHD()
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            return dsk["VolumeSerialNumber"].ToString();
        }
        string GetPcName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
        }

        private void TimerSync_Tick(object sender, EventArgs e)
        {
            //SyncStatus();
        }
    }
}
