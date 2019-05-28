using MCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroControlAdmin
{
    public partial class frmPrincipal : Form
    {
        DB dataBase;

        DataTable dt = new DataTable();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadMicro();
        }
        private void LoadDataGridView()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Micro");
            dt.Columns.Add("Status");

            gridViewMicro.DataSource = dt;
        }
        private void LoadMicro()
        {
            dataBase = new DB();
            dataBase.ConnectServer();
            dt.Clear();
            dt = dataBase.ReturnTable(dt);

        }
        private void Pesquisa(string pesquisa)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadMicro();
        }
    }
}
