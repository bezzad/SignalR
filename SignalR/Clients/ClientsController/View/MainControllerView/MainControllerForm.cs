// PM> Install-Package Microsoft.AspNet.SignalR.Client

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SignalR.Core.Extensions;
using SignalR.Core.Model;
using SignalR.Core.Presenter;

namespace SignalR.Core.View
{
    public partial class MainControllerForm : Form, IMainControllerView
    {
        public MainControllerForm()
        {
            InitializeComponent();

            LoadView(new EventArgs());
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            Presenter.Connect();
        }

        private void btnControlUsers_Click(object sender, EventArgs e)
        {
            Presenter.ControlSelectedUsers(GetSelectedUsers());
        }

        private async void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            await Presenter.FetchUsersData();
        }

        private void btnShowServerEventLogs_Click(object sender, EventArgs e)
        {
            Presenter.ShowServerEventLogs();
        }

        
        #region IMainControllerView Members

        public string ServerIP
        {
            get { return txtIP.Value; }
            set { Presenter.SafeInvoker(() => txtIP.Value = value); }
        }

        public string ServerPort
        {
            get { return txtPort.Value; }
            set { Presenter.SafeInvoker(() => txtPort.Value = value); }
        }

        public string Username
        {
            get { return txtUsername.Value; }
            set { Presenter.SafeInvoker(() => txtUsername.Value = value); }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { Presenter.SafeInvoker(() => txtPassword.Text = value); }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { Presenter.SafeInvoker(() => lblMessage.Text = value); }
        }

        public List<User> Users
        {
            get { return (List<User>)dgvUsers.DataSource; }
            set { Presenter.SafeInvoker(() => dgvUsers.DataSource = value); }
        }

        public event EventHandler Initialize;
        public void LoadView(EventArgs e)
        {
            EventHandler handler = Initialize;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void ActiveControls(bool active)
        {
            Presenter.SafeInvoker(() =>
            {
                btnConnect.Checked = active;
                gbServerConnection.Enabled = !active;
                gbUsers.Enabled = active;
                btnRefreshUsers.Enabled = active;
            });
        }


        public bool ServerControlsEnable
        {
            get { return gbServerConnection.Enabled; }
            set { Presenter.SafeInvoker(() => gbServerConnection.Enabled = value); }
        }

        public string ConnectionState
        {
            get { return btnConnect.Text; }
            set { Presenter.SafeInvoker(() => btnConnect.Text = value); }
        }

        Presenter<IMainControllerView> IView<IMainControllerView>.Presenter { get; set; }

        public MainControllerPresenter Presenter
        {
            get { return (MainControllerPresenter)((IView<IMainControllerView>)this).Presenter; }
        }

        public void OnPropertyChanged(string propertyName)
        {

        }

        public void SetColumns()
        {
            dgvUsers.SetColumns(true);

            dgvUsers.AddCheckBoxColumn();
        }

        public List<User> GetSelectedUsers()
        {
            return (from DataGridViewRow row in dgvUsers.Rows
                where row.Cells["CheckBox"].Value != null && (bool) row.Cells["CheckBox"].Value
                select Users[row.Index]).ToList();
        }

        #endregion
        
    }
}