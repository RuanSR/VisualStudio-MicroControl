using System;
using System.Windows.Forms;
using MCL;
using MicroControl.Class;

namespace MicroControl
{
    public partial class mainForm : Form
    {
        Initializing initializing = new Initializing();
        Command cmd = new Command();
        DB dataBase;
        Micro micro;
        string microName;
        public mainForm(string microName = null)
        {
            InitializeComponent();
            dataBase = new DB();
            this.microName = microName;
        }
        //public async void testy()
        //{
        //    var micro = await dataBase.GetMicroServer("1");
        //    this.micro = micro;
        //    if (micro != null)
        //    {
        //        MessageBox.Show("SUCESSO!");
        //        this.micro = micro;
        //        this.Text = ":: " + micro.NameMicro.ToUpper() + " ::";
        //        this.Load += MainForm_Load;
        //    }
        //}

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
                    var micro = await dataBase.GetMicroServer(microName);
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
                MessageBox.Show("Erro em LoadData: "+ex.Message);
                this.Close();
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
                    cmd.SET_BG(micro.ComplementMicro, true);
                    dataBase.UpdateMicro(txtID.Text, micro);
                }
                else if(micro.CommandMicro == 2)
                {
                    cmd.SHUTDOWN();
                    dataBase.UpdateMicro(txtID.Text, micro);
                }
                else if(micro.CommandMicro == 3)
                {
                    MessageBox.Show(micro.ComplementMicro);
                    dataBase.UpdateMicro(txtID.Text, micro);
                }
                initializing.WriteDataLogin(string.Format("{0}|{1}|{2}|{3}", micro.IDMicro, micro.NameMicro, micro.StatusMicro, 0));
                timeUpdate.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em ao passar comando! "+ex.Message);
            }
        }
        private void NotifyLoad()
        {
            notifyIcon.BalloonTipTitle = "Micro Control";
            notifyIcon.BalloonTipText = "Controle do Instrutor";
            notifyIcon.Text = "Micro Control";
        }
        private void HideForm()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }
        private void LblHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
