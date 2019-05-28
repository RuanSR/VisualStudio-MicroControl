using MCL;
using System;
using System.Data;
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
        private void GridViewMicro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Micro micro = new Micro();

            micro.IDMicro = gridViewMicro.Rows[e.RowIndex].Cells[0].Value.ToString();
            micro.NameMicro = gridViewMicro.Rows[e.RowIndex].Cells[1].Value.ToString();
            micro.StatusMicro = int.Parse(gridViewMicro.Rows[e.RowIndex].Cells[2].Value.ToString());
            micro.CommandMicro = 0;
            micro.ComplementMicro = "null";
            new frmCommand(micro).ShowDialog();
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
            dt = dataBase.GetAllMicro(dt);

        }
        private void Pesquisa(string pesquisa)
        {

        }
    }
}
