namespace WinFormClient
{
    partial class ClientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategory = new Windows.Forms.HintTextBox(this.components);
            this.btnConnect = new AlertButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new Windows.Forms.HintTextBox(this.components);
            this.txtIP = new Windows.Forms.HintTextBox(this.components);
            this.txtPassword = new Windows.Forms.HintTextBox(this.components);
            this.txtUsername = new Windows.Forms.HintTextBox(this.components);
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(751, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Connection";
            // 
            // txtCategory
            // 
            this.txtCategory.EnterToTab = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCategory.ForeColor = System.Drawing.Color.Gray;
            this.txtCategory.HintValue = "Category Name";
            this.txtCategory.Location = new System.Drawing.Point(316, 80);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(181, 26);
            this.txtCategory.TabIndex = 11;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategory.TextForeColor = System.Drawing.Color.Black;
            this.txtCategory.Value = "";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Firebrick;
            this.btnConnect.Checked = false;
            this.btnConnect.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConnect.Location = new System.Drawing.Point(529, 31);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(204, 71);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Tickness = 5;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server Address: ";
            // 
            // txtPort
            // 
            this.txtPort.AutoCompleteCustomSource.AddRange(new string[] {
            "8088",
            "9000",
            "1394",
            "80",
            "8080",
            "3114",
            "3131",
            "1080",
            "1020",
            "1433",
            "1990",
            "1900",
            "1395",
            "33333",
            "88888"});
            this.txtPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPort.EnterToTab = false;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPort.ForeColor = System.Drawing.Color.Gray;
            this.txtPort.HintValue = "Port: 50023";
            this.txtPort.Location = new System.Drawing.Point(383, 28);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 26);
            this.txtPort.TabIndex = 1;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort.TextForeColor = System.Drawing.Color.Black;
            this.txtPort.Value = "";
            // 
            // txtIP
            // 
            this.txtIP.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost",
            "192.168.0.253",
            "192.168.30.41",
            "192.168.30.40",
            "192.168.0.6",
            "192.168.30.30",
            "192.168.0.10",
            "192.168.0.15"});
            this.txtIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIP.EnterToTab = false;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIP.ForeColor = System.Drawing.Color.Gray;
            this.txtIP.HintValue = "IP: 192.168.X.X";
            this.txtIP.Location = new System.Drawing.Point(168, 27);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(205, 26);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextForeColor = System.Drawing.Color.Black;
            this.txtIP.Value = "";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterToTab = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintValue = "Password";
            this.txtPassword.Location = new System.Drawing.Point(168, 80);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextForeColor = System.Drawing.Color.Black;
            this.txtPassword.Value = "";
            // 
            // txtUsername
            // 
            this.txtUsername.EnterToTab = false;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintValue = "Username";
            this.txtUsername.Location = new System.Drawing.Point(20, 80);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextForeColor = System.Drawing.Color.Black;
            this.txtUsername.Value = "";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(16, 190);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(717, 528);
            this.txtLog.TabIndex = 7;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // txtSender
            // 
            this.txtSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSender.Enabled = false;
            this.txtSender.Location = new System.Drawing.Point(16, 130);
            this.txtSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSender.Multiline = true;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(717, 51);
            this.txtSender.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 733);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientForm";
            this.Text = "WinForm Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.HintTextBox txtUsername;
        private Windows.Forms.HintTextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtPort;
        private Windows.Forms.HintTextBox txtIP;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtSender;
        private AlertButton btnConnect;
        private Windows.Forms.HintTextBox txtCategory;
    }
}

