using System;
using System.Windows.Forms;
using MCL;

namespace MicroControl
{
    public partial class initForm : Form
    {
        DB dataBase;
        Micro micro;
        public initForm()
        {
            InitializeComponent();
        }

        private void btnLogarMicro_Click(object sender, EventArgs e)
        {
            dataBase = new DB();
            micro = new Micro();

            if (dataBase.ConnectServer())
            {
                //dataBase.ConnectServer();
                //dataBase.GetMicroServer("MICRO_TESTE01");
                //MessageBox.Show(dataBase.t);
                new mainForm().ShowDialog();
                //this.Hide();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se com o servidor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewMicro_Click(object sender, EventArgs e)
        {
            new dialogAdminForm().ShowDialog();
        }
    }
}
