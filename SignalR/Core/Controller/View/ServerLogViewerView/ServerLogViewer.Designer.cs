namespace SignalR.Core.View.ServerLogViewerView
{
    partial class ServerLogViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.chkAuditFailure = new System.Windows.Forms.CheckBox();
            this.chkAuditSuccess = new System.Windows.Forms.CheckBox();
            this.chkInformations = new System.Windows.Forms.CheckBox();
            this.chkWarnings = new System.Windows.Forms.CheckBox();
            this.chkErrors = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFetchLogs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.grbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.btnClearLogs);
            this.grbFilters.Controls.Add(this.chkAuditFailure);
            this.grbFilters.Controls.Add(this.chkAuditSuccess);
            this.grbFilters.Controls.Add(this.chkInformations);
            this.grbFilters.Controls.Add(this.chkWarnings);
            this.grbFilters.Controls.Add(this.chkErrors);
            this.grbFilters.Controls.Add(this.dtpTo);
            this.grbFilters.Controls.Add(this.label2);
            this.grbFilters.Controls.Add(this.btnFetchLogs);
            this.grbFilters.Controls.Add(this.label1);
            this.grbFilters.Controls.Add(this.dtpFrom);
            this.grbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFilters.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilters.Location = new System.Drawing.Point(0, 0);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Size = new System.Drawing.Size(833, 123);
            this.grbFilters.TabIndex = 0;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Log Filters";
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLogs.Font = new System.Drawing.Font("Californian FB", 14.25F);
            this.btnClearLogs.Location = new System.Drawing.Point(601, 30);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(107, 67);
            this.btnClearLogs.TabIndex = 10;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // chkAuditFailure
            // 
            this.chkAuditFailure.AutoSize = true;
            this.chkAuditFailure.Checked = true;
            this.chkAuditFailure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuditFailure.Location = new System.Drawing.Point(404, 80);
            this.chkAuditFailure.Name = "chkAuditFailure";
            this.chkAuditFailure.Size = new System.Drawing.Size(105, 22);
            this.chkAuditFailure.TabIndex = 9;
            this.chkAuditFailure.Text = "Audit Failure";
            this.chkAuditFailure.UseVisualStyleBackColor = true;
            // 
            // chkAuditSuccess
            // 
            this.chkAuditSuccess.AutoSize = true;
            this.chkAuditSuccess.Checked = true;
            this.chkAuditSuccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuditSuccess.Location = new System.Drawing.Point(288, 80);
            this.chkAuditSuccess.Name = "chkAuditSuccess";
            this.chkAuditSuccess.Size = new System.Drawing.Size(110, 22);
            this.chkAuditSuccess.TabIndex = 8;
            this.chkAuditSuccess.Text = "Audit Success";
            this.chkAuditSuccess.UseVisualStyleBackColor = true;
            // 
            // chkInformations
            // 
            this.chkInformations.AutoSize = true;
            this.chkInformations.Checked = true;
            this.chkInformations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInformations.Location = new System.Drawing.Point(178, 80);
            this.chkInformations.Name = "chkInformations";
            this.chkInformations.Size = new System.Drawing.Size(104, 22);
            this.chkInformations.TabIndex = 7;
            this.chkInformations.Text = "Informations";
            this.chkInformations.UseVisualStyleBackColor = true;
            // 
            // chkWarnings
            // 
            this.chkWarnings.AutoSize = true;
            this.chkWarnings.Checked = true;
            this.chkWarnings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarnings.Location = new System.Drawing.Point(86, 80);
            this.chkWarnings.Name = "chkWarnings";
            this.chkWarnings.Size = new System.Drawing.Size(86, 22);
            this.chkWarnings.TabIndex = 6;
            this.chkWarnings.Text = "Warnings";
            this.chkWarnings.UseVisualStyleBackColor = true;
            // 
            // chkErrors
            // 
            this.chkErrors.AutoSize = true;
            this.chkErrors.Checked = true;
            this.chkErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkErrors.Location = new System.Drawing.Point(15, 80);
            this.chkErrors.Name = "chkErrors";
            this.chkErrors.Size = new System.Drawing.Size(65, 22);
            this.chkErrors.TabIndex = 5;
            this.chkErrors.Text = "Errors";
            this.chkErrors.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.CustomFormat = "";
            this.dtpTo.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(340, 29);
            this.dtpTo.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.ShowUpDown = true;
            this.dtpTo.Size = new System.Drawing.Size(119, 22);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date:";
            // 
            // btnFetchLogs
            // 
            this.btnFetchLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetchLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchLogs.Font = new System.Drawing.Font("Californian FB", 14.25F);
            this.btnFetchLogs.Location = new System.Drawing.Point(714, 30);
            this.btnFetchLogs.Name = "btnFetchLogs";
            this.btnFetchLogs.Size = new System.Drawing.Size(107, 67);
            this.btnFetchLogs.TabIndex = 2;
            this.btnFetchLogs.Text = "Fetch Logs";
            this.btnFetchLogs.UseVisualStyleBackColor = true;
            this.btnFetchLogs.Click += new System.EventHandler(this.btnFetchLogs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.CustomFormat = "";
            this.dtpFrom.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(91, 29);
            this.dtpFrom.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.ShowUpDown = true;
            this.dtpFrom.Size = new System.Drawing.Size(119, 22);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(0, 123);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowTemplate.Height = 40;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(833, 427);
            this.dgvLogs.TabIndex = 1;
            this.dgvLogs.VirtualMode = true;
            // 
            // ServerLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 550);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.grbFilters);
            this.Name = "ServerLogViewer";
            this.Text = "Server Log Viewer";
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.Button btnFetchLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkErrors;
        private System.Windows.Forms.CheckBox chkAuditFailure;
        private System.Windows.Forms.CheckBox chkAuditSuccess;
        private System.Windows.Forms.CheckBox chkInformations;
        private System.Windows.Forms.CheckBox chkWarnings;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Button btnClearLogs;
    }
}