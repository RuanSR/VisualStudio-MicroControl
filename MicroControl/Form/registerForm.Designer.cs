namespace MicroControl
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMicroName = new System.Windows.Forms.TextBox();
            this.btnNewMicro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(12, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 22);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Micro Name";
            // 
            // txtMicroName
            // 
            this.txtMicroName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMicroName.Location = new System.Drawing.Point(12, 99);
            this.txtMicroName.Name = "txtMicroName";
            this.txtMicroName.Size = new System.Drawing.Size(228, 22);
            this.txtMicroName.TabIndex = 1;
            // 
            // btnNewMicro
            // 
            this.btnNewMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMicro.Location = new System.Drawing.Point(12, 126);
            this.btnNewMicro.Name = "btnNewMicro";
            this.btnNewMicro.Size = new System.Drawing.Size(228, 23);
            this.btnNewMicro.TabIndex = 2;
            this.btnNewMicro.Text = "SALVAR";
            this.btnNewMicro.UseVisualStyleBackColor = true;
            this.btnNewMicro.Click += new System.EventHandler(this.BtnNewMicro_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 162);
            this.Controls.Add(this.btnNewMicro);
            this.Controls.Add(this.txtMicroName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: NEW MICRO ::";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMicroName;
        private System.Windows.Forms.Button btnNewMicro;
    }
}