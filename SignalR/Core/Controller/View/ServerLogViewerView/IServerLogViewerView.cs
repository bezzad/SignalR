using System;
using System.Collections.Generic;
using SignalR.Core.Model;
using SignalR.Core.Presenter;

namespace SignalR.Core.View
{
    public interface IServerLogViewerView : IView<IServerLogViewerView>
    {
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        LevelType CheckedLevel { get; set; }
        List<LogModel> Logs { get; set; }

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
