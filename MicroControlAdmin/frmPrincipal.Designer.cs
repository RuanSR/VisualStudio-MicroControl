namespace MicroControlAdmin
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCommandAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewMicro = new System.Windows.Forms.DataGridView();
            this.btnCleanerDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMicro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCommandAll);
            this.groupBox1.Controls.Add(this.btnCleanerDB);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // btnCommandAll
            // 
            this.btnCommandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommandAll.Location = new System.Drawing.Point(124, 18);
            this.btnCommandAll.Name = "btnCommandAll";
            this.btnCommandAll.Size = new System.Drawing.Size(147, 23);
            this.btnCommandAll.TabIndex = 0;
            this.btnCommandAll.Text = "COMMAND ALL";
            this.btnCommandAll.UseVisualStyleBackColor = true;
            this.btnCommandAll.Click += new System.EventHandler(this.BtnCommandAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(6, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewMicro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MICRO";
            // 
            // gridViewMicro
            // 
            this.gridViewMicro.AllowUserToAddRows = false;
            this.gridViewMicro.AllowUserToDeleteRows = false;
            this.gridViewMicro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridViewMicro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMicro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewMicro.Location = new System.Drawing.Point(3, 19);
            this.gridViewMicro.Name = "gridViewMicro";
            this.gridViewMicro.ReadOnly = true;
            this.gridViewMicro.RowHeadersVisible = false;
            this.gridViewMicro.Size = new System.Drawing.Size(395, 211);
            this.gridViewMicro.TabIndex = 0;
            this.gridViewMicro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMicro_CellContentClick);
            // 
            // btnCleanerDB
            // 
            this.btnCleanerDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanerDB.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCleanerDB.Location = new System.Drawing.Point(291, 18);
            this.btnCleanerDB.Name = "btnCleanerDB";
            this.btnCleanerDB.Size = new System.Drawing.Size(98, 23);
            this.btnCleanerDB.TabIndex = 0;
            this.btnCleanerDB.Text = "CLEANER";
            this.btnCleanerDB.UseVisualStyleBackColor = true;
            this.btnCleanerDB.Click += new System.EventHandler(this.BtnCleanerDB_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: MICRO CONTROL ADMIN ::";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMicro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewMicro;
        private System.Windows.Forms.Button btnCommandAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCleanerDB;
    }
}

