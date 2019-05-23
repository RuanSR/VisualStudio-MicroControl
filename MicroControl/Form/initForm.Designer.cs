namespace MicroControl
{
    partial class initForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMicroID = new System.Windows.Forms.TextBox();
            this.btnLogarMicro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewMicro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM-VINDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "MICRO CONTROL SETTINGS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(76, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MICRO ID";
            // 
            // txtMicroID
            // 
            this.txtMicroID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMicroID.Location = new System.Drawing.Point(12, 91);
            this.txtMicroID.Name = "txtMicroID";
            this.txtMicroID.Size = new System.Drawing.Size(192, 21);
            this.txtMicroID.TabIndex = 3;
            // 
            // btnLogarMicro
            // 
            this.btnLogarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogarMicro.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogarMicro.Location = new System.Drawing.Point(12, 165);
            this.btnLogarMicro.Name = "btnLogarMicro";
            this.btnLogarMicro.Size = new System.Drawing.Size(192, 23);
            this.btnLogarMicro.TabIndex = 4;
            this.btnLogarMicro.Text = "LOGAR MICRO";
            this.btnLogarMicro.UseVisualStyleBackColor = true;
            this.btnLogarMicro.Click += new System.EventHandler(this.btnLogarMicro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "OU";
            // 
            // btnNewMicro
            // 
            this.btnNewMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMicro.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMicro.Location = new System.Drawing.Point(12, 213);
            this.btnNewMicro.Name = "btnNewMicro";
            this.btnNewMicro.Size = new System.Drawing.Size(192, 23);
            this.btnNewMicro.TabIndex = 4;
            this.btnNewMicro.Text = "CADASTRAR MICRO";
            this.btnNewMicro.UseVisualStyleBackColor = true;
            this.btnNewMicro.Click += new System.EventHandler(this.btnNewMicro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(65, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "SUPER PASS";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Location = new System.Drawing.Point(12, 139);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(192, 21);
            this.txtPass.TabIndex = 3;
            // 
            // initForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewMicro);
            this.Controls.Add(this.btnLogarMicro);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMicroID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 246);
            this.Name = "initForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: AUTENTICAR-SE ::";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMicroID;
        private System.Windows.Forms.Button btnLogarMicro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewMicro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
    }
}