using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientsController.Presenter;
using SignalR.Core.Model;
using SignalR.Core.Presenter;
using SignalR.Core.View;

namespace ClientsController.View
{
    public partial class ServerLogViewer : Form, IServerLogViewerView
    {
        public ServerLogViewer()
        {
            InitializeComponent();

            LoadView(new EventArgs());

            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = dtpTo.Value.AddMonths(-1);
        }

        private async void btnFetchLogs_Click(object sender, EventArgs e)
        {
            var parameters = new List<object>();

            if (dtpFrom.Checked)
            {
                parameters.Add(dtpFrom.Value);

                if (!dtpTo.Checked) // necessary to have two parameters for dateTime
                    parameters.Add(DateTime.Now);
            }
            if (dtpTo.Checked)
            {
                if (!dtpFrom.Checked) // necessary to have two parameters for dateTime
                    parameters.Add(dtpTo.Value.AddDays(-30));

                parameters.Add(dtpTo.Value);
            }
            if (!(chkErrors.Checked &&
                chkWarnings.Checked &&
                chkInformations.Checked &&
                chkAuditSuccess.Checked &&
                chkAuditFailure.Checked))
            {
                parameters.AddRange(new object[] { chkErrors.Checked, chkWarnings.Checked, chkInformations.Checked, chkAuditSuccess.Checked, chkAuditFailure.Checked });
            }


            List<Log> logs = await CustomClient.Instance.InvokeAsync<List<Log>>("DynamicMethodRunner",
                "SignalR.Core.WindowsEventLog",
                "GetEntryCollection",
                Type.GetTypeArray(parameters.ToArray()).Select(x => x.AssemblyQualifiedName),
                parameters);

            if (logs != null)
            {
                dgvLogs.DataSource = logs;
            }

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value >= dtpTo.Value)
            {
                dtpTo.Value = dtpFrom.Value.AddDays(1);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value >= dtpTo.Value)
            {
                dtpFrom.Value = dtpTo.Value.AddDays(-1);
            }
        }

        private async void btnClearLogs_Click(object sender, EventArgs e)
        {
            await CustomClient.Instance.InvokeAsync("DynamicMethodRunner",
                "SignalR.Core.WindowsEventLog",
                "DeleteCurrentSource",
                new Type[0],
                new object[0]);

            btnFetchLogs.PerformClick();
        }


        #region IServerLogViewerView Members

        public DateTime FromDate
        {
            get { return dtpFrom.Value; }
            set { Presenter.SafeInvoker(() => dtpFrom.Value = value); }
        }

        public DateTime ToDate
        {
            get { return dtpTo.Value; }
            set { Presenter.SafeInvoker(() => dtpTo.Value = value); }
        }

        public LevelType CheckedLevel
        {
            get
            {
                var level = new LevelType();

                if (chkErrors.Checked) level |= LevelType.Error;

                if (chkWarnings.Checked) level |= LevelType.Warning;

                if (chkInformations.Checked) level |= LevelType.Information;

                if (chkAuditSuccess.Checked) level |= LevelType.AuditSuccess;

                if (chkAuditFailure.Checked) level |= LevelType.AuditFailure;

                return level;
            }
            set
            {
                Presenter.SafeInvoker(() =>
                {
                    chkErrors.Checked = value.HasFlag(LevelType.Error);

                    chkWarnings.Checked = value.HasFlag(LevelType.Warning);

                    chkInformations.Checked = value.HasFlag(LevelType.Information);

                    chkAuditSuccess.Checked = value.HasFlag(LevelType.AuditSuccess);

                    chkAuditFailure.Checked = value.HasFlag(LevelType.AuditFailure);
                });
            }
        }

        public List<Log> Logs
        {
            get { return (List<Log>)dgvLogs.DataSource; }
            set { Presenter.SafeInvoker(() => dgvLogs.DataSource = value); }
        }

        public Presenter<IServerLogViewerView> Presenter { get; set; }

        ServerLogViewerPresenter IServerLogViewerView.Presenter
        {
            get { return (ServerLogViewerPresenter)((IView<IServerLogViewerView>)this).Presenter; }
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

        public void OnPropertyChanged(string propertyName)
        {
            
        }

        #endregion


    }
}
