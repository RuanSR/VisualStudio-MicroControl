using MCL;
using System.Windows.Forms;

namespace MicroControlAdmin
{
    public partial class frmCommand : Form
    {
        DB dataBase = new DB();
        Micro micro;
        RadioButton rbOption;
        int selectedIndex;
        string[] typeCommand = new string[] { "simple","advanced" };
        public frmCommand(Micro micro, string typeCommand = "simple")
        {
            InitializeComponent();
            this.micro = micro;
            if (typeCommand == this.typeCommand[0])
            {
                groupAdvanced.Visible = false;
                groubMicro.Visible = true;
            }
            else
            {
                groupAdvanced.Visible = true;
                groubMicro.Visible = false;
            }
        }
        private void FrmCommand_Load(object sender, System.EventArgs e)
        {
            if (dataBase.ConnectServer())
            {
                LoadObjectMicro();
                LoadComboBoxCommands();
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se com a base de dados!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void CbCommands_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            selectedIndex = cbCommands.SelectedIndex;
            selectedIndex++;
            if (selectedIndex == 1)//DESLIGAR
            {
                btnSender.Enabled = true;
                groupComplement.Enabled = false;
                groupTime.Visible = true;
                micro.CommandMicro = selectedIndex;
            }
            else if (selectedIndex == 2)//BG
            {
                rbOption = new RadioButton();
                groupComplement.Enabled = true;
                btnSender.Enabled = true;
                groupTime.Visible = false;
                rbOption.Checked = false;
                rbOption = null;
                micro.CommandMicro = selectedIndex;
            }
            else if (selectedIndex == 3)//SEND MSG
            {
                rbOption = new RadioButton();
                groupComplement.Enabled = true;
                btnSender.Enabled = true;
                groupTime.Visible = false;
                rbOption.Checked = false;
                rbOption = null;
                micro.CommandMicro = selectedIndex;
            }

            if (groupComplement.Enabled)
            {
                micro.ComplementMicro = txtComplement.Text;
            }
        }
        private void SetRadioButtonOption(object sender, System.EventArgs e)
        {
            rbOption = (RadioButton)sender;
        }
        private void BtnSender_Click(object sender, System.EventArgs e)
        {
            if (groupComplement.Enabled)
            {
                if (txtComplement.Text != string.Empty)
                {
                    micro.ComplementMicro = txtComplement.Text;
                    dataBase.SendCommand(micro);
                    MessageBox.Show("COMANDO ENVIADO!");
                }
                else
                {
                    MessageBox.Show("PREENCHA O CAMPO COMPLEMENT!");
                }
            }else if (groupTime.Visible)
            {
                if (rbOption.Checked)
                {
                    micro.ComplementMicro = CheckRadioButtonOption();
                    dataBase.SendCommand(micro);
                    MessageBox.Show("COMANDO ENVIADO!");
                }
                else
                {
                    MessageBox.Show("MARQUE UMA OPÇÃO EM TIME");
                }
            }
            else
            {
                dataBase.SendCommand(micro);
                MessageBox.Show("COMANDO ENVIADO!");
            }
        }
        private string CheckRadioButtonOption()
        {
            string r;
            switch (rbOption.Text)
            {
                case "1m":
                    r = "60";
                    break;
                case "30s":
                    r = "0,166667";
                    break;
                case "10s":
                    r = "";
                    break;
                case "Imediato":
                    r = "0";
                    break;
                default:
                    r = "0";
                    break;
            }
            return r;
        }
        private void LoadObjectMicro()
        {
            txtMicroID.Text = micro.IDMicro.ToString();
            txtMicroName.Text = micro.NameMicro;
            txtMicroStatus.Text = micro.StatusMicro.ToString();
        }
        private void LoadComboBoxCommands()
        {
            cbCommands.Items.Add("DESLIGAR PC");
            cbCommands.Items.Add("ALTERAR PAPEL PAREDE");
            cbCommands.Items.Add("MANDAR MENSSAGEM");
        }
        string strfilename;
        private void TxtComplement_DoubleClick(object sender, System.EventArgs e)
        {
           
            if (selectedIndex == 2)
            {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                }
                txtComplement.Text = strfilename;
            }
        }
    }
}
