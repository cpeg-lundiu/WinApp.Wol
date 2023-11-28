namespace WinApp.Wol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMac = new Label();
            txtMac = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPort = new TextBox();
            lblPort = new Label();
            btnWake = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMac
            // 
            lblMac.AutoSize = true;
            lblMac.Location = new Point(12, 12);
            lblMac.Name = "lblMac";
            lblMac.Size = new Size(80, 15);
            lblMac.TabIndex = 0;
            lblMac.Text = "Mac Address";
            // 
            // txtMac
            // 
            txtMac.Location = new Point(112, 9);
            txtMac.Name = "txtMac";
            txtMac.Size = new Size(120, 23);
            txtMac.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(112, 35);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(120, 23);
            txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 38);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(98, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Internet Address";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(112, 61);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(120, 23);
            txtPort.TabIndex = 5;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(12, 64);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(30, 15);
            lblPort.TabIndex = 4;
            lblPort.Text = "Port";
            // 
            // btnWake
            // 
            btnWake.Location = new Point(157, 90);
            btnWake.Name = "btnWake";
            btnWake.Size = new Size(75, 23);
            btnWake.TabIndex = 6;
            btnWake.Text = "Wake Up";
            btnWake.UseVisualStyleBackColor = true;
            btnWake.Click += BtnWake_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 119);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(244, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 141);
            Controls.Add(statusStrip1);
            Controls.Add(btnWake);
            Controls.Add(txtPort);
            Controls.Add(lblPort);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtMac);
            Controls.Add(lblMac);
            MaximizeBox = false;
            MaximumSize = new Size(260, 180);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Wol";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
