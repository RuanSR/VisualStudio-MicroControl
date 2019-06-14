﻿namespace MicroControlAdmin
{
    partial class frmCommand
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
            this.groubMicro = new System.Windows.Forms.GroupBox();
            this.txtMicroStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMicroName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMicroID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCommand = new System.Windows.Forms.GroupBox();
            this.groupComplement = new System.Windows.Forms.GroupBox();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.btnSender = new System.Windows.Forms.Button();
            this.cbCommands = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groubMicro.SuspendLayout();
            this.groupCommand.SuspendLayout();
            this.groupComplement.SuspendLayout();
            this.groupTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // groubMicro
            // 
            this.groubMicro.Controls.Add(this.txtMicroStatus);
            this.groubMicro.Controls.Add(this.label3);
            this.groubMicro.Controls.Add(this.txtMicroName);
            this.groubMicro.Controls.Add(this.label2);
            this.groubMicro.Controls.Add(this.txtMicroID);
            this.groubMicro.Controls.Add(this.label1);
            this.groubMicro.Dock = System.Windows.Forms.DockStyle.Top;
            this.groubMicro.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groubMicro.Location = new System.Drawing.Point(0, 0);
            this.groubMicro.Name = "groubMicro";
            this.groubMicro.Size = new System.Drawing.Size(305, 170);
            this.groubMicro.TabIndex = 1;
            this.groubMicro.TabStop = false;
            this.groubMicro.Text = "MICRO";
            // 
            // txtMicroStatus
            // 
            this.txtMicroStatus.Location = new System.Drawing.Point(12, 137);
            this.txtMicroStatus.Name = "txtMicroStatus";
            this.txtMicroStatus.ReadOnly = true;
            this.txtMicroStatus.Size = new System.Drawing.Size(281, 23);
            this.txtMicroStatus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "MICRO STATUS";
            // 
            // txtMicroName
            // 
            this.txtMicroName.Location = new System.Drawing.Point(12, 88);
            this.txtMicroName.Name = "txtMicroName";
            this.txtMicroName.ReadOnly = true;
            this.txtMicroName.Size = new System.Drawing.Size(281, 23);
            this.txtMicroName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MICRO NAME";
            // 
            // txtMicroID
            // 
            this.txtMicroID.Location = new System.Drawing.Point(12, 38);
            this.txtMicroID.Name = "txtMicroID";
            this.txtMicroID.ReadOnly = true;
            this.txtMicroID.Size = new System.Drawing.Size(281, 23);
            this.txtMicroID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MICRO ID";
            // 
            // groupCommand
            // 
            this.groupCommand.Controls.Add(this.groupComplement);
            this.groupCommand.Controls.Add(this.groupTime);
            this.groupCommand.Controls.Add(this.btnSender);
            this.groupCommand.Controls.Add(this.cbCommands);
            this.groupCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCommand.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCommand.Location = new System.Drawing.Point(0, 170);
            this.groupCommand.Name = "groupCommand";
            this.groupCommand.Size = new System.Drawing.Size(305, 221);
            this.groupCommand.TabIndex = 2;
            this.groupCommand.TabStop = false;
            this.groupCommand.Text = "COMMAND";
            // 
            // groupComplement
            // 
            this.groupComplement.Controls.Add(this.txtComplement);
            this.groupComplement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupComplement.Enabled = false;
            this.groupComplement.Location = new System.Drawing.Point(3, 94);
            this.groupComplement.Name = "groupComplement";
            this.groupComplement.Size = new System.Drawing.Size(299, 101);
            this.groupComplement.TabIndex = 1;
            this.groupComplement.TabStop = false;
            this.groupComplement.Text = "COMPLEMENT";
            // 
            // txtComplement
            // 
            this.txtComplement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComplement.Location = new System.Drawing.Point(3, 19);
            this.txtComplement.Multiline = true;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(293, 79);
            this.txtComplement.TabIndex = 0;
            this.txtComplement.DoubleClick += new System.EventHandler(this.TxtComplement_DoubleClick);
            // 
            // groupTime
            // 
            this.groupTime.Controls.Add(this.rbOption4);
            this.groupTime.Controls.Add(this.rbOption3);
            this.groupTime.Controls.Add(this.rbOption2);
            this.groupTime.Controls.Add(this.rbOption1);
            this.groupTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTime.Location = new System.Drawing.Point(3, 43);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(299, 51);
            this.groupTime.TabIndex = 2;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "TIME";
            this.groupTime.Visible = false;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(204, 22);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(86, 20);
            this.rbOption4.TabIndex = 0;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Imediato";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(136, 22);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(49, 20);
            this.rbOption3.TabIndex = 0;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "10s";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(69, 23);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(49, 20);
            this.rbOption2.TabIndex = 0;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "30s";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(6, 22);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(47, 20);
            this.rbOption1.TabIndex = 0;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "1m";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // btnSender
            // 
            this.btnSender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSender.Enabled = false;
            this.btnSender.Location = new System.Drawing.Point(3, 195);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(299, 23);
            this.btnSender.TabIndex = 1;
            this.btnSender.Text = "ENVIAR COMANDO";
            this.btnSender.UseVisualStyleBackColor = true;
            this.btnSender.Click += new System.EventHandler(this.BtnSender_Click);
            // 
            // cbCommands
            // 
            this.cbCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommands.FormattingEnabled = true;
            this.cbCommands.Location = new System.Drawing.Point(3, 19);
            this.cbCommands.Name = "cbCommands";
            this.cbCommands.Size = new System.Drawing.Size(299, 24);
            this.cbCommands.TabIndex = 0;
            this.cbCommands.SelectedIndexChanged += new System.EventHandler(this.CbCommands_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 391);
            this.Controls.Add(this.groupCommand);
            this.Controls.Add(this.groubMicro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommand";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: MICRO CONTROL | COMMAND CENTER ::";
            this.Load += new System.EventHandler(this.FrmCommand_Load);
            this.groubMicro.ResumeLayout(false);
            this.groubMicro.PerformLayout();
            this.groupCommand.ResumeLayout(false);
            this.groupComplement.ResumeLayout(false);
            this.groupComplement.PerformLayout();
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groubMicro;
        private System.Windows.Forms.TextBox txtMicroID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMicroStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMicroName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCommand;
        private System.Windows.Forms.ComboBox cbCommands;
        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.GroupBox groupComplement;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
    }
}