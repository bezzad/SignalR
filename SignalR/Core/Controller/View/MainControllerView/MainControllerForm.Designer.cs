namespace SignalR.Core.View
{
    partial class MainControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.btnShowServerEventLogs = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnControlUsers = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbServerConnection = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new AlertButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new Windows.Forms.HintTextBox(this.components);
            this.txtIP = new Windows.Forms.HintTextBox(this.components);
            this.txtUsername = new Windows.Forms.HintTextBox(this.components);
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbServerConnection.SuspendLayout();
            this.statusBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsers.Controls.Add(this.btnShowServerEventLogs);
            this.gbUsers.Controls.Add(this.btnRefreshUsers);
            this.gbUsers.Controls.Add(this.btnControlUsers);
            this.gbUsers.Controls.Add(this.dgvUsers);
            this.gbUsers.Enabled = false;
            this.gbUsers.Location = new System.Drawing.Point(0, 129);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(874, 394);
            this.gbUsers.TabIndex = 1;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // btnShowServerEventLogs
            // 
            this.btnShowServerEventLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowServerEventLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowServerEventLogs.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowServerEventLogs.Location = new System.Drawing.Point(612, 350);
            this.btnShowServerEventLogs.Name = "btnShowServerEventLogs";
            this.btnShowServerEventLogs.Size = new System.Drawing.Size(243, 38);
            this.btnShowServerEventLogs.TabIndex = 5;
            this.btnShowServerEventLogs.Text = "Show Server Event Logs";
            this.btnShowServerEventLogs.UseVisualStyleBackColor = true;
            this.btnShowServerEventLogs.Click += new System.EventHandler(this.btnShowServerEventLogs_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUsers.Location = new System.Drawing.Point(243, 350);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(179, 38);
            this.btnRefreshUsers.TabIndex = 3;
            this.btnRefreshUsers.Text = "Refresh Users List";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // btnControlUsers
            // 
            this.btnControlUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnControlUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlUsers.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlUsers.Location = new System.Drawing.Point(20, 350);
            this.btnControlUsers.Name = "btnControlUsers";
            this.btnControlUsers.Size = new System.Drawing.Size(217, 38);
            this.btnControlUsers.TabIndex = 1;
            this.btnControlUsers.Text = "Control Users";
            this.btnControlUsers.UseVisualStyleBackColor = true;
            this.btnControlUsers.Click += new System.EventHandler(this.btnControlUsers_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 19);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(850, 341);
            this.dgvUsers.TabIndex = 4;
            // 
            // gbServerConnection
            // 
            this.gbServerConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServerConnection.Controls.Add(this.label3);
            this.gbServerConnection.Controls.Add(this.label2);
            this.gbServerConnection.Controls.Add(this.txtPassword);
            this.gbServerConnection.Controls.Add(this.btnConnect);
            this.gbServerConnection.Controls.Add(this.label1);
            this.gbServerConnection.Controls.Add(this.txtPort);
            this.gbServerConnection.Controls.Add(this.txtIP);
            this.gbServerConnection.Controls.Add(this.txtUsername);
            this.gbServerConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbServerConnection.ForeColor = System.Drawing.Color.Firebrick;
            this.gbServerConnection.Location = new System.Drawing.Point(12, 12);
            this.gbServerConnection.Name = "gbServerConnection";
            this.gbServerConnection.Size = new System.Drawing.Size(850, 111);
            this.gbServerConnection.TabIndex = 7;
            this.gbServerConnection.TabStop = false;
            this.gbServerConnection.Text = "Server Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(272, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(349, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 22);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Firebrick;
            this.btnConnect.Checked = false;
            this.btnConnect.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConnect.Location = new System.Drawing.Point(651, 27);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(181, 60);
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
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
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
            this.txtPort.Location = new System.Drawing.Point(352, 27);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "Port: 50023";
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
            this.txtIP.Location = new System.Drawing.Point(126, 27);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(220, 22);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "IP: 192.168.X.X";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextForeColor = System.Drawing.Color.Black;
            this.txtIP.Value = "";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.EnterToTab = false;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.ForeColor = System.Drawing.Color.Maroon;
            this.txtUsername.HintValue = "Username";
            this.txtUsername.Location = new System.Drawing.Point(92, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "User Director";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextForeColor = System.Drawing.Color.Maroon;
            this.txtUsername.Value = "User Director";
            // 
            // statusBottom
            // 
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblMessage});
            this.statusBottom.Location = new System.Drawing.Point(0, 544);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBottom.Size = new System.Drawing.Size(874, 22);
            this.statusBottom.TabIndex = 8;
            this.statusBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "Message:";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(803, 17);
            this.lblMessage.Spring = true;
            // 
            // MainControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 566);
            this.Controls.Add(this.statusBottom);
            this.Controls.Add(this.gbServerConnection);
            this.Controls.Add(this.gbUsers);
            this.Name = "MainControllerForm";
            this.Text = "Clients Controller";
            this.gbUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbServerConnection.ResumeLayout(false);
            this.gbServerConnection.PerformLayout();
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbServerConnection;
        private AlertButton btnConnect;
        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtPort;
        private Windows.Forms.HintTextBox txtIP;
        private System.Windows.Forms.Button btnControlUsers;
        private System.Windows.Forms.StatusStrip statusBottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private Windows.Forms.HintTextBox txtUsername;
        private System.Windows.Forms.Button btnShowServerEventLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

