using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SignalR.Core;
using SignalR.Core.Model;

namespace ClientsController.View
{
    public partial class UsersControlPanelForm : Form
    {
        private readonly List<User> _selectedUser;

        private List<string> GetSelectedUsers
        {
            get { return _selectedUser.Select(x => x.Username).ToList(); }
        }

        public UsersControlPanelForm(List<User> selectedUsers)
        {
            InitializeComponent();

            //
            // set user data
            //
            _selectedUser = selectedUsers;
            //
            // set server connection
            //
            CustomClient.Instance.ThrowExceptionIfDisposed();
            CustomClient.Instance.Closed += Close;
            // 
            // dgvUsers
            // 
            this.dgvUsers.DataSource = _selectedUser;
            //
            // picNotifyIcon
            //
            picNotifyIcon.Image = SystemIcons.Error.ToBitmap();
            //
            // cmbSelectSystemIcons
            //
            cmbSelectSystemIcons.Items.Add("Error");
            cmbSelectSystemIcons.Items.Add("Information");
            cmbSelectSystemIcons.Items.Add("Warning");
            cmbSelectSystemIcons.SelectedIndex = 0;
            cmbSelectSystemIcons.SelectedValueChanged += (s, e) =>
            {
                var selectedIcon = (Icon)typeof(SystemIcons).GetProperty(cmbSelectSystemIcons.Text).GetValue(this);
                picNotifyIcon.Image = selectedIcon.ToBitmap();
            };
            //
            // cmbImageFormat
            //
            cmbImageFormat.SelectedIndex = 0;
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Value;
            string message = txtMessage.Value;
            long time;
            if (!long.TryParse(txtTimeout.Value, out time))
                time = 5000;

            string icon = cmbSelectSystemIcons.Text;


            if (rdbtnAlertNotiry.Checked)
            {
                await CustomClient.Instance.CallClientsAsync(GetSelectedUsers, "AlertNotify", title, message, time, icon);
            }
            else if (rdbtnLabelNotify.Checked)
            {
                await CustomClient.Instance.CallClientsAsync(GetSelectedUsers, "OnStatusNotify", title, message, icon);
            }
            else if (rdbtnMessageBox.Checked)
            {
                await CustomClient.Instance.CallClientsAsync(GetSelectedUsers, "MessageShower", title, message, icon);
            }
        }

        private async void btnSP_ShowDesktop_Click(object sender, EventArgs e)
        {
            long width = chkResizeImage.Checked ? (long)numWidth.Value : 0;
            long height = chkResizeImage.Checked ? (long)numHeight.Value : 0;

            await CustomClient.Instance.CallClientsAsync(GetSelectedUsers, "GetDesktopCapture", CustomClient.Instance.Username, width, height, cmbImageFormat.Text);
        }


        private async void btnSendCloudMessage_Click(object sender, EventArgs e)
        {
            var pImei = txtIMEI.Value;
            if (String.IsNullOrEmpty(pImei)) pImei = "352961067289634";
            
            var args = new { func = 17, imei = pImei, messages = txtSentMessage.Value, userid = 100 };
            var result = await CustomClient.Instance.InvokeAsync<string>("ApiPostAsync", Properties.Settings.Default.CloudMessagingUrl, args.SplitProperties());

            // respons sample: {"text":"true","err":"ir.shoniz.NO_ERRORS_MESSAGE"}

            MessageBox.Show(result);
        }

        private async void closeClientApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure to close [" + string.Join(", ", GetSelectedUsers) + "] clients ?",
                "Close Client Warning!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    var result = await CustomClient.Instance.InvokeAsync<bool>("RemoveUserManuallyAsync", GetSelectedUsers);
                    MessageBox.Show("All users manually removed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error - Remove User From Server Manually", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void closeActionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            forms[forms.Count - 1].Close();
        }

        private void customeProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dom = new RuntimeCompiler(CustomClient.Instance, GetSelectedUsers);
            dom.ShowDialog(this);
        }


    }
}
