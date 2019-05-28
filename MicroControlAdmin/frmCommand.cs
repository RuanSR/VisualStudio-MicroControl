using MCL;
using System.Windows.Forms;

namespace MicroControlAdmin
{
    public partial class frmCommand : Form
    {
        DB dataBase = new DB();
        Micro micro;
        int selectedIndex;
        public frmCommand(Micro micro)
        {
            InitializeComponent();
            this.micro = micro;
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
            if (selectedIndex == 1)
            {
                btnSender.Enabled = true;
                groupComplement.Enabled = false;
                micro.CommandMicro = selectedIndex;
            }
            else if (selectedIndex == 2)
            {
                groupComplement.Enabled = true;
                btnSender.Enabled = true;
                micro.CommandMicro = selectedIndex;
            }
            else if (selectedIndex == 3)
            {
                groupComplement.Enabled = true;
                btnSender.Enabled = true;
                micro.CommandMicro = selectedIndex;
            }

            if (groupComplement.Enabled)
            {
                micro.ComplementMicro = txtComplement.Text;
            }
        }
        private void BtnSender_Click(object sender, System.EventArgs e)
        {
            if (groupComplement.Enabled)
            {
                micro.ComplementMicro = txtComplement.Text;
            }
            dataBase.SendCommand(micro.IDMicro,micro);
            MessageBox.Show("COMANDO ENVIADO!");
        }
        private void LoadObjectMicro()
        {
            txtMicroID.Text = micro.IDMicro;
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
