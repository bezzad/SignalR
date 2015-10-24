using System.Windows.Forms;

namespace SignalR.Core.View
{
    partial class UsersControlPanelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersControlPanelForm));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.gbMessageSender = new System.Windows.Forms.GroupBox();
            this.cmbSelectSystemIcons = new System.Windows.Forms.ComboBox();
            this.picNotifyIcon = new System.Windows.Forms.PictureBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.chkSendToInbox = new System.Windows.Forms.CheckBox();
            this.rdbtnLabelNotify = new System.Windows.Forms.RadioButton();
            this.rdbtnMessageBox = new System.Windows.Forms.RadioButton();
            this.txtTimeout = new Windows.Forms.HintTextBox(this.components);
            this.rdbtnAlertNotiry = new System.Windows.Forms.RadioButton();
            this.txtTitle = new Windows.Forms.HintTextBox(this.components);
            this.txtMessage = new Windows.Forms.HintTextBox(this.components);
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.flPanelExecuteSP = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSP_CloseActiveForm = new System.Windows.Forms.Button();
            this.btnSP_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbImageFormat = new System.Windows.Forms.ComboBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkResizeImage = new System.Windows.Forms.CheckBox();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnSP_ShowDesktop = new System.Windows.Forms.Button();
            this.btnDynamicProcedure = new System.Windows.Forms.Button();
            this.gbExecuteSP = new System.Windows.Forms.GroupBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbUsers.SuspendLayout();
            this.gbMessageSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifyIcon)).BeginInit();
            this.flPanelExecuteSP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.gbExecuteSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 16);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(759, 228);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.Text = "radGridView1";
            // 
            // gbUsers
            // 
            this.gbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsers.Controls.Add(this.dgvUsers);
            this.gbUsers.Location = new System.Drawing.Point(12, 12);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(765, 247);
            this.gbUsers.TabIndex = 3;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Selected Users";
            // 
            // gbMessageSender
            // 
            this.gbMessageSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMessageSender.Controls.Add(this.cmbSelectSystemIcons);
            this.gbMessageSender.Controls.Add(this.picNotifyIcon);
            this.gbMessageSender.Controls.Add(this.btnSendMessage);
            this.gbMessageSender.Controls.Add(this.chkSendToInbox);
            this.gbMessageSender.Controls.Add(this.rdbtnLabelNotify);
            this.gbMessageSender.Controls.Add(this.rdbtnMessageBox);
            this.gbMessageSender.Controls.Add(this.txtTimeout);
            this.gbMessageSender.Controls.Add(this.rdbtnAlertNotiry);
            this.gbMessageSender.Controls.Add(this.txtTitle);
            this.gbMessageSender.Controls.Add(this.txtMessage);
            this.gbMessageSender.Location = new System.Drawing.Point(12, 265);
            this.gbMessageSender.Name = "gbMessageSender";
            this.gbMessageSender.Size = new System.Drawing.Size(765, 167);
            this.gbMessageSender.TabIndex = 0;
            this.gbMessageSender.TabStop = false;
            this.gbMessageSender.Text = "Send Message";
            // 
            // cmbSelectSystemIcons
            // 
            this.cmbSelectSystemIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectSystemIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSystemIcons.FormattingEnabled = true;
            this.cmbSelectSystemIcons.Location = new System.Drawing.Point(520, 45);
            this.cmbSelectSystemIcons.Name = "cmbSelectSystemIcons";
            this.cmbSelectSystemIcons.Size = new System.Drawing.Size(129, 21);
            this.cmbSelectSystemIcons.TabIndex = 3;
            this.toolTipHelper.SetToolTip(this.cmbSelectSystemIcons, "Select system icons");
            // 
            // picNotifyIcon
            // 
            this.picNotifyIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNotifyIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picNotifyIcon.Location = new System.Drawing.Point(551, 79);
            this.picNotifyIcon.Name = "picNotifyIcon";
            this.picNotifyIcon.Size = new System.Drawing.Size(80, 72);
            this.picNotifyIcon.TabIndex = 9;
            this.picNotifyIcon.TabStop = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnSendMessage.Location = new System.Drawing.Point(671, 61);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 47);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Send";
            this.toolTipHelper.SetToolTip(this.btnSendMessage, "Send message to selected clients");
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // chkSendToInbox
            // 
            this.chkSendToInbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSendToInbox.AutoSize = true;
            this.chkSendToInbox.Location = new System.Drawing.Point(418, 135);
            this.chkSendToInbox.Name = "chkSendToInbox";
            this.chkSendToInbox.Size = new System.Drawing.Size(91, 17);
            this.chkSendToInbox.TabIndex = 7;
            this.chkSendToInbox.Text = "Send to inbox";
            this.toolTipHelper.SetToolTip(this.chkSendToInbox, "Store this message on the user inbox.");
            this.chkSendToInbox.UseVisualStyleBackColor = true;
            // 
            // rdbtnLabelNotify
            // 
            this.rdbtnLabelNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnLabelNotify.AutoSize = true;
            this.rdbtnLabelNotify.Location = new System.Drawing.Point(418, 78);
            this.rdbtnLabelNotify.Name = "rdbtnLabelNotify";
            this.rdbtnLabelNotify.Size = new System.Drawing.Size(81, 17);
            this.rdbtnLabelNotify.TabIndex = 5;
            this.rdbtnLabelNotify.Text = "Label Notify";
            this.toolTipHelper.SetToolTip(this.rdbtnLabelNotify, "Display your message on the user system status toolbar label\'s.");
            this.rdbtnLabelNotify.UseVisualStyleBackColor = true;
            // 
            // rdbtnMessageBox
            // 
            this.rdbtnMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnMessageBox.AutoSize = true;
            this.rdbtnMessageBox.Location = new System.Drawing.Point(418, 50);
            this.rdbtnMessageBox.Name = "rdbtnMessageBox";
            this.rdbtnMessageBox.Size = new System.Drawing.Size(89, 17);
            this.rdbtnMessageBox.TabIndex = 4;
            this.rdbtnMessageBox.Text = "Message Box";
            this.toolTipHelper.SetToolTip(this.rdbtnMessageBox, "Display your message on the user system by a MessageBox.");
            this.rdbtnMessageBox.UseVisualStyleBackColor = true;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeout.EnterToTab = false;
            this.txtTimeout.ForeColor = System.Drawing.Color.Gray;
            this.txtTimeout.HintValue = "Timeout: 5000 ms";
            this.txtTimeout.IsNumerical = true;
            this.txtTimeout.Location = new System.Drawing.Point(520, 21);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(129, 20);
            this.txtTimeout.TabIndex = 2;
            this.txtTimeout.Text = "Timeout: 5000 ms";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeout.TextForeColor = System.Drawing.Color.Black;
            this.toolTipHelper.SetToolTip(this.txtTimeout, "Set notify display duration time\r\n(Example: 5000 ms)");
            this.txtTimeout.Value = "";
            // 
            // rdbtnAlertNotiry
            // 
            this.rdbtnAlertNotiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnAlertNotiry.AutoSize = true;
            this.rdbtnAlertNotiry.Checked = true;
            this.rdbtnAlertNotiry.Location = new System.Drawing.Point(418, 22);
            this.rdbtnAlertNotiry.Name = "rdbtnAlertNotiry";
            this.rdbtnAlertNotiry.Size = new System.Drawing.Size(76, 17);
            this.rdbtnAlertNotiry.TabIndex = 2;
            this.rdbtnAlertNotiry.TabStop = true;
            this.rdbtnAlertNotiry.Text = "Alert Notify";
            this.toolTipHelper.SetToolTip(this.rdbtnAlertNotiry, "Alert notify, display your message on the user system by notification balloon\'s.");
            this.rdbtnAlertNotiry.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.EnterToTab = false;
            this.txtTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtTitle.HintValue = "Title";
            this.txtTitle.Location = new System.Drawing.Point(6, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(384, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Title";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.TextForeColor = System.Drawing.Color.Black;
            this.toolTipHelper.SetToolTip(this.txtTitle, "Set Message Captions.");
            this.txtTitle.Value = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.EnterToTab = false;
            this.txtMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtMessage.HintValue = "\r\n\r\n\r\nEnter Message";
            this.txtMessage.Location = new System.Drawing.Point(6, 45);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(384, 116);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "\r\n\r\n\r\nEnter Message";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMessage.TextForeColor = System.Drawing.Color.Black;
            this.toolTipHelper.SetToolTip(this.txtMessage, "Message Texts.");
            this.txtMessage.Value = "";
            // 
            // toolTipHelper
            // 
            this.toolTipHelper.IsBalloon = true;
            this.toolTipHelper.ShowAlways = true;
            this.toolTipHelper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelper.ToolTipTitle = "Help";
            // 
            // flPanelExecuteSP
            // 
            this.flPanelExecuteSP.Controls.Add(this.btnSP_CloseActiveForm);
            this.flPanelExecuteSP.Controls.Add(this.btnSP_Exit);
            this.flPanelExecuteSP.Controls.Add(this.groupBox1);
            this.flPanelExecuteSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelExecuteSP.Location = new System.Drawing.Point(3, 16);
            this.flPanelExecuteSP.Name = "flPanelExecuteSP";
            this.flPanelExecuteSP.Size = new System.Drawing.Size(650, 107);
            this.flPanelExecuteSP.TabIndex = 0;
            this.toolTipHelper.SetToolTip(this.flPanelExecuteSP, "Stored Procedures");
            // 
            // btnSP_CloseActiveForm
            // 
            this.btnSP_CloseActiveForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSP_CloseActiveForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_CloseActiveForm.Location = new System.Drawing.Point(3, 3);
            this.btnSP_CloseActiveForm.Name = "btnSP_CloseActiveForm";
            this.btnSP_CloseActiveForm.Size = new System.Drawing.Size(100, 100);
            this.btnSP_CloseActiveForm.TabIndex = 0;
            this.btnSP_CloseActiveForm.Text = "Close Active Form";
            this.toolTipHelper.SetToolTip(this.btnSP_CloseActiveForm, "Click to close client application active form\'s.");
            this.btnSP_CloseActiveForm.UseVisualStyleBackColor = false;
            this.btnSP_CloseActiveForm.Click += new System.EventHandler(this.btnSP_CloseActiveForm_Click);
            // 
            // btnSP_Exit
            // 
            this.btnSP_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSP_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_Exit.Location = new System.Drawing.Point(109, 3);
            this.btnSP_Exit.Name = "btnSP_Exit";
            this.btnSP_Exit.Size = new System.Drawing.Size(100, 100);
            this.btnSP_Exit.TabIndex = 1;
            this.btnSP_Exit.Text = "Close Application";
            this.toolTipHelper.SetToolTip(this.btnSP_Exit, "Click to close client application.");
            this.btnSP_Exit.UseVisualStyleBackColor = false;
            this.btnSP_Exit.Click += new System.EventHandler(this.btnSP_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbImageFormat);
            this.groupBox1.Controls.Add(this.numHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkResizeImage);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Controls.Add(this.btnSP_ShowDesktop);
            this.groupBox1.Location = new System.Drawing.Point(215, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Items.AddRange(new object[] {
            "Jpeg",
            "Bmp",
            "Png",
            "Gif",
            "Tiff"});
            this.cmbImageFormat.Location = new System.Drawing.Point(228, 59);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(115, 21);
            this.cmbImageFormat.TabIndex = 3;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(272, 21);
            this.numHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(71, 20);
            this.numHeight.TabIndex = 2;
            this.numHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width:";
            // 
            // chkResizeImage
            // 
            this.chkResizeImage.AutoSize = true;
            this.chkResizeImage.Location = new System.Drawing.Point(119, 61);
            this.chkResizeImage.Name = "chkResizeImage";
            this.chkResizeImage.Size = new System.Drawing.Size(90, 17);
            this.chkResizeImage.TabIndex = 0;
            this.chkResizeImage.Text = "Resize Image";
            this.chkResizeImage.UseVisualStyleBackColor = true;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(138, 21);
            this.numWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(71, 20);
            this.numWidth.TabIndex = 1;
            this.toolTipHelper.SetToolTip(this.numWidth, "Resize Width");
            this.numWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // btnSP_ShowDesktop
            // 
            this.btnSP_ShowDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSP_ShowDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_ShowDesktop.Location = new System.Drawing.Point(8, 15);
            this.btnSP_ShowDesktop.Name = "btnSP_ShowDesktop";
            this.btnSP_ShowDesktop.Size = new System.Drawing.Size(80, 72);
            this.btnSP_ShowDesktop.TabIndex = 4;
            this.btnSP_ShowDesktop.Text = "Show User Desktop";
            this.toolTipHelper.SetToolTip(this.btnSP_ShowDesktop, "Click to display user system desktop snapshots.");
            this.btnSP_ShowDesktop.UseVisualStyleBackColor = false;
            this.btnSP_ShowDesktop.Click += new System.EventHandler(this.btnSP_ShowDesktop_Click);
            // 
            // btnDynamicProcedure
            // 
            this.btnDynamicProcedure.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDynamicProcedure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDynamicProcedure.Location = new System.Drawing.Point(674, 454);
            this.btnDynamicProcedure.Name = "btnDynamicProcedure";
            this.btnDynamicProcedure.Size = new System.Drawing.Size(100, 100);
            this.btnDynamicProcedure.TabIndex = 5;
            this.btnDynamicProcedure.Text = "Custom Procedure";
            this.toolTipHelper.SetToolTip(this.btnDynamicProcedure, "Click to run your codes dynamically on the client system.");
            this.btnDynamicProcedure.UseVisualStyleBackColor = false;
            this.btnDynamicProcedure.Click += new System.EventHandler(this.btnDynamicProcedure_Click);
            // 
            // gbExecuteSP
            // 
            this.gbExecuteSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExecuteSP.Controls.Add(this.flPanelExecuteSP);
            this.gbExecuteSP.Location = new System.Drawing.Point(12, 438);
            this.gbExecuteSP.Name = "gbExecuteSP";
            this.gbExecuteSP.Size = new System.Drawing.Size(656, 126);
            this.gbExecuteSP.TabIndex = 1;
            this.gbExecuteSP.TabStop = false;
            this.gbExecuteSP.Text = "Execute Stored Procedures";
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbResult.Location = new System.Drawing.Point(15, 570);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(762, 46);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // UsersControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 628);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbExecuteSP);
            this.Controls.Add(this.gbMessageSender);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.btnDynamicProcedure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersControlPanelForm";
            this.Text = "Users Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbUsers.ResumeLayout(false);
            this.gbMessageSender.ResumeLayout(false);
            this.gbMessageSender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifyIcon)).EndInit();
            this.flPanelExecuteSP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.gbExecuteSP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbMessageSender;
        private Windows.Forms.HintTextBox txtMessage;
        private Windows.Forms.HintTextBox txtTitle;
        private Windows.Forms.HintTextBox txtTimeout;
        private System.Windows.Forms.RadioButton rdbtnAlertNotiry;
        private System.Windows.Forms.RadioButton rdbtnMessageBox;
        private System.Windows.Forms.RadioButton rdbtnLabelNotify;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.CheckBox chkSendToInbox;
        private System.Windows.Forms.ToolTip toolTipHelper;
        private System.Windows.Forms.GroupBox gbExecuteSP;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.FlowLayoutPanel flPanelExecuteSP;
        private System.Windows.Forms.Button btnSP_CloseActiveForm;
        private System.Windows.Forms.Button btnSP_Exit;
        private System.Windows.Forms.Button btnSP_ShowDesktop;
        private System.Windows.Forms.Button btnDynamicProcedure;
        private System.Windows.Forms.PictureBox picNotifyIcon;
        private System.Windows.Forms.ComboBox cmbSelectSystemIcons;
        private System.Windows.Forms.CheckBox chkResizeImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.ComboBox cmbImageFormat;

    }
}