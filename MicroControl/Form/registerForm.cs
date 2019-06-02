using System;
using System.Windows.Forms;
using MCL;

namespace MicroControl
{
    public partial class registerForm : Form
    {
        DB dataBase;
        public registerForm()
        {
            InitializeComponent();
        }

        private void BtnNewMicro_Click(object sender, EventArgs e)
        {
            dataBase = new DB();
            if (dataBase.ConnectServer())
            {
                dataBase.InsertMicro(txtMicroName.Text, 0, 0, "null");
                MessageBox.Show("Sucesso no cadastro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se com o servidor!", "ERRO!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
