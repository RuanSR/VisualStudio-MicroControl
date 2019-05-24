using System;
using System.Windows.Forms;
using MCL;
namespace MicroControl
{
    public partial class dialogAdminForm : Form
    {
        DB dataBase;
        AdminBase AdminBase = new AdminBase();
        public dialogAdminForm()
        {
            InitializeComponent();
        }

        private void BtnAutentication_Click(object sender, EventArgs e)
        {
            dataBase = new DB();
            if (dataBase.ConnectServer())
            {

            }
            else
            {
                MessageBox.Show("Erro ao conectar-se com o servidor!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            this.Hide();
            this.Close();
            this.Dispose();
            new registerForm().ShowDialog();
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
