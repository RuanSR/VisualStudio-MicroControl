using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCL;
using MicroControl.Class;

namespace MicroControl
{
    public partial class mainForm : Form
    {
        Initializing initializing = new Initializing();
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
            LoadData();
        }
        private async void LoadData()
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
                initializing.CheckPath(string.Format("{0}|{1}|{2}|{3}",micro.IDMicro,micro.NameMicro,micro.StatusMicro,micro.CommandMicro));
            }
        }
    }
}
