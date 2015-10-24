using SignalR.Core.Properties;

sealed partial class WaitSplash
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
        this.lblMessage = new System.Windows.Forms.Label();
        this.picCenter = new System.Windows.Forms.PictureBox();
        this.picWaitGif = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.picWaitGif)).BeginInit();
        this.SuspendLayout();
        // 
        // lblMessage
        // 
        this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.lblMessage.AutoSize = true;
        this.lblMessage.BackColor = System.Drawing.Color.Transparent;
        this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.lblMessage.ForeColor = System.Drawing.Color.Pink;
        this.lblMessage.Location = new System.Drawing.Point(19, 14);
        this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblMessage.Name = "lblMessage";
        this.lblMessage.Size = new System.Drawing.Size(480, 104);
        this.lblMessage.TabIndex = 1;
        this.lblMessage.Text = "لطفا منتظر بمانید";
        this.lblMessage.UseCompatibleTextRendering = true;
        // 
        // picCenter
        // 
        this.picCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.picCenter.Image = Resources.sakht;
        this.picCenter.Location = new System.Drawing.Point(192, 269);
        this.picCenter.Margin = new System.Windows.Forms.Padding(4);
        this.picCenter.Name = "picCenter";
        this.picCenter.Size = new System.Drawing.Size(135, 113);
        this.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picCenter.TabIndex = 2;
        this.picCenter.TabStop = false;
        // 
        // picWaitGif
        // 
        this.picWaitGif.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.picWaitGif.BackColor = System.Drawing.Color.Transparent;
        this.picWaitGif.Image = Resources.loader;
        this.picWaitGif.Location = new System.Drawing.Point(5, 118);
        this.picWaitGif.Margin = new System.Windows.Forms.Padding(4);
        this.picWaitGif.Name = "picWaitGif";
        this.picWaitGif.Size = new System.Drawing.Size(507, 425);
        this.picWaitGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picWaitGif.TabIndex = 0;
        this.picWaitGif.TabStop = false;
        // 
        // WaitSplash
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.Controls.Add(this.picCenter);
        this.Controls.Add(this.picWaitGif);
        this.Controls.Add(this.lblMessage);
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "WaitSplash";
        this.Size = new System.Drawing.Size(518, 547);
        ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.picWaitGif)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picWaitGif;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.PictureBox picCenter;
}

