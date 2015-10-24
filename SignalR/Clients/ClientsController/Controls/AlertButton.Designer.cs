partial class AlertButton
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.btnAlert = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnAlert
        // 
        this.btnAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.btnAlert.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAlert.Location = new System.Drawing.Point(5, 5);
        this.btnAlert.Margin = new System.Windows.Forms.Padding(10);
        this.btnAlert.Name = "btnAlert";
        this.btnAlert.Size = new System.Drawing.Size(140, 40);
        this.btnAlert.TabIndex = 0;
        this.btnAlert.Text = "button1";
        this.btnAlert.UseVisualStyleBackColor = true;
        // 
        // AlertButton
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Firebrick;
        this.Controls.Add(this.btnAlert);
        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.Name = "AlertButton";
        this.Size = new System.Drawing.Size(150, 50);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAlert;
}

