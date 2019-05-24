using System;
using System.Windows.Forms;

namespace MicroControl
{
    public partial class initForm : Form
    {
        public initForm()
        {
            InitializeComponent();
        }

        private void btnLogarMicro_Click(object sender, EventArgs e)
        {
            new mainForm().ShowDialog();
        }
        private void btnNewMicro_Click(object sender, EventArgs e)
        {
            new dialogAdminForm().ShowDialog();
        }
    }
}
