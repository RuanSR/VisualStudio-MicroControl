using MCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MicroControlAdmin
{
    public partial class frmPrincipal : Form
    {
        DB dataBase = new DB();
        Micro micro = new Micro();
        DataTable dt = new DataTable();
        List<Micro> listMicro = new List<Micro>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private async void FrmPrincipal_Load(object sender, EventArgs e)
        {
            listMicro = await dataBase.LoadListMicro();
            LoadDataGridView();
            LoadGridView();
        }
        private void GridViewMicro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            micro.IDMicro = int.Parse(gridViewMicro.Rows[e.RowIndex].Cells[0].Value.ToString());
            micro.SerialLogin = gridViewMicro.Rows[e.RowIndex].Cells[1].Value.ToString();

            micro.NameMicro = gridViewMicro.Rows[e.RowIndex].Cells[2].Value.ToString();
            //micro.StatusMicro = int.Parse(gridViewMicro.Rows[e.RowIndex].Cells[3].Value.ToString());
            micro.CommandMicro = 0;
            micro.ComplementMicro = "null";
            if (gridViewMicro.Rows[e.RowIndex].Cells[3].Value.ToString() == "Online")
            {
                micro.StatusMicro = 1;
            }
            new frmCommand(micro).ShowDialog();
        }
        private void LoadDataGridView()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Serial");
            dt.Columns.Add("Micro");
            dt.Columns.Add("Status");
            dt.Columns.Add("Command");
            dt.Columns.Add("Complement");

            gridViewMicro.DataSource = dt;
            gridViewMicro.Columns[0].Width = 50;
            gridViewMicro.Columns[2].Width = 260;
            gridViewMicro.Columns[3].Width = 70;

            gridViewMicro.Columns[1].Visible = false;
            gridViewMicro.Columns[4].Visible = false;
            gridViewMicro.Columns[5].Visible = false;

        }
        private void LoadMicro()
        {
            dataBase = new DB();
            dt.Clear();
            dt = dataBase.GetAllMicro(dt);
        }
        private void LoadGridView()
        {
            dt.Clear();
            for (int i = 0; i != listMicro.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = listMicro[i].IDMicro;
                row["Serial"] = listMicro[i].SerialLogin;
                row["Micro"] = listMicro[i].NameMicro;
                row["Status"] = "Online";
                row["Command"] = listMicro[i].CommandMicro;
                row["Complement"] = listMicro[i].ComplementMicro;
                dt.Rows.Add(row);
            }
        }
        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            listMicro = await dataBase.LoadListMicro();
            LoadGridView();
        }
        private void BtnCommandAll_Click(object sender, EventArgs e)
        {
            new frmCommand(micro,listMicro,"advanced").ShowDialog();
        }
        private void BtnCleanerDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("QUER MESMO ZERAR A BASE DE DADOS?","ATENÇÃO!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataBase.DeleteAll();
            }
        }
        private void TimerSync_Tick(object sender, EventArgs e)
        {

        }
    }
}
