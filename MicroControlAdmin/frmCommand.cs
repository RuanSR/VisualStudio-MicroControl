using MCL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MicroControlAdmin
{
    public partial class frmCommand : Form
    {
        DB dataBase = new DB();
        Micro micro;
        RadioButton rbOption;
        int selectedIndex;
        List<Micro> listMicro;
        string[] typeCommand = new string[] { "simple","advanced" };
        public frmCommand(Micro micro,List<Micro> listMicro = null, string typeCommand = "simple")
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
                this.listMicro = listMicro;
                groupAdvanced.Visible = true;
                groubMicro.Visible = false;

                for (int i = 0; i != listMicro.Count; i++)
                {
                    if (i == 0)
                    {
                        checkListMicro.Items.Add("ALL");
                        checkListMicro.Items.Add(listMicro[i].NameMicro);
                    }
                    else
                    {
                        this.checkListMicro.Items.Add(listMicro[i].NameMicro);
                    }
                    
                }
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

        private void CheckListMicro_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (checkListMicro.SelectedIndex == 0)
            {
                if (checkListMicro.GetItemChecked(0))
                {
                    for (int i = 1; i != listMicro.Count + 1; i++)
                    {
                        checkListMicro.SetItemCheckState(i, CheckState.Checked);
                    }
                }
                else if(!checkListMicro.GetItemChecked(0))
                {
                    for (int i = listMicro.Count; i != 0; i--)
                    {
                        checkListMicro.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
            else
            {
                checkListMicro.SetItemCheckState(0, CheckState.Unchecked);
            }
        }
    }
}
