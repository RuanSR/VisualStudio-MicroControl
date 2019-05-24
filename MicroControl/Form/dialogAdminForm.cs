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
    public partial class dialogAdminForm : Form
    {
        public dialogAdminForm()
        {
            InitializeComponent();
        }

        private void BtnAutentication_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            new registerForm().ShowDialog();
            
        }
    }
}
