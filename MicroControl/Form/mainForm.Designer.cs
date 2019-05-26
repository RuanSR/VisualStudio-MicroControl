namespace MicroControl
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMicroName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastCommand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblHide = new System.Windows.Forms.Label();
            this.lblDisconnect = new System.Windows.Forms.Label();
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(12, 72);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Micro Name";
            // 
            // txtMicroName
            // 
            this.txtMicroName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMicroName.Location = new System.Drawing.Point(12, 27);
            this.txtMicroName.Name = "txtMicroName";
            this.txtMicroName.ReadOnly = true;
            this.txtMicroName.Size = new System.Drawing.Size(192, 20);
            this.txtMicroName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Command";
            // 
            // txtLastCommand
            // 
            this.txtLastCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastCommand.Location = new System.Drawing.Point(12, 127);
            this.txtLastCommand.Name = "txtLastCommand";
            this.txtLastCommand.ReadOnly = true;
            this.txtLastCommand.Size = new System.Drawing.Size(74, 20);
            this.txtLastCommand.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(12, 179);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(74, 20);
            this.txtStatus.TabIndex = 1;
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide.Location = new System.Drawing.Point(108, 186);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(33, 13);
            this.lblHide.TabIndex = 2;
            this.lblHide.Text = "Hide";
            this.lblHide.Click += new System.EventHandler(this.LblHide_Click);
            // 
            // lblDisconnect
            // 
            this.lblDisconnect.AutoSize = true;
            this.lblDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisconnect.Location = new System.Drawing.Point(143, 186);
            this.lblDisconnect.Name = "lblDisconnect";
            this.lblDisconnect.Size = new System.Drawing.Size(71, 13);
            this.lblDisconnect.TabIndex = 2;
            this.lblDisconnect.Text = "Disconnect";
            this.lblDisconnect.Click += new System.EventHandler(this.LblDisconnect_Click);
            // 
            // timeUpdate
            // 
            this.timeUpdate.Interval = 5000;
            this.timeUpdate.Tick += new System.EventHandler(this.TimeUpdate_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 207);
            this.Controls.Add(this.lblDisconnect);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastCommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMicroName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 246);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 246);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: MICRO NAME HERE ::";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMicroName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Label lblDisconnect;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}