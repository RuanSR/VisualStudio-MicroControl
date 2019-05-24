using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            new registerForm().ShowDialog();
        }
    }
}
