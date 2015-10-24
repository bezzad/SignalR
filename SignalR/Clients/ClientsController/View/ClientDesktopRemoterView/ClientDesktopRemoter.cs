using System;
using System.Drawing;
using System.Windows.Forms;

namespace SignalR.Core.View
{
    public partial class ClientDesktopRemoter : Form
    {
        private Image img;


        public ClientDesktopRemoter(string data, string username)
        {
            InitializeComponent();

            img = data.Base64ToImage();

            this.Text = username + " Desktop Image";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (InvokeRequired)
            {
                this.Invoke(new Action(() => imgBox.Image = img));
            }
            else
            {
                imgBox.Image = img;
            }
        }

    }
}
