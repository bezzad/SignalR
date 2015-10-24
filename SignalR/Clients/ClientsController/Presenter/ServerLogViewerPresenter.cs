using SignalR.Core.Model;
using SignalR.Core.View;

namespace SignalR.Core.Presenter
{
    public class ServerLogViewerPresenter : Presenter<IServerLogViewerView>
    {
        
        public ServerLogViewerPresenter(IServerLogViewerView view, Log model) : base(view)
        {
            Model = model;
        }
    }
}
