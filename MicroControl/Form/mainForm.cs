using System;
using System.Windows.Forms;
using MCL;

namespace MicroControl
{
    public partial class mainForm : Form
    {
        DB dataBase = new DB();
        Micro micro = new Micro();
        public mainForm(Micro micro = null)
        {
            InitializeComponent();
            this.micro = dataBase.micro;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = micro.NameMicro;
        }
    }
}
