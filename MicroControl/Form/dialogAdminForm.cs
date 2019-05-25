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
            AdminBase = new AdminBase();
            if (AdminBase.SuperPass.Equals(txtPass.Text))
            {
                this.Hide();
                this.Close();
                this.Dispose();
                new registerForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se com o servidor!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
