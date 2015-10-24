using System;
using System.Collections.Generic;
using ClientsController.Presenter;
using SignalR.Core.Model;
using SignalR.Core.View;

namespace ClientsController.View
{
    public interface IServerLogViewerView : IView<IServerLogViewerView>
    {
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        LevelType CheckedLevel { get; set; }
        List<Log> Logs { get; set; }

        new ServerLogViewerPresenter Presenter { get; }
    }

    [Flags]
    public enum LevelType
    {
        Error = 1,
        Warning = 2,
        Information = 4,
        AuditSuccess = 8,
        AuditFailure = 16
    }
}
