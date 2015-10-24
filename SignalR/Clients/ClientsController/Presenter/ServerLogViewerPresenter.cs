using ClientsController.View;
using SignalR.Core.Model;
using SignalR.Core.Presenter;

namespace ClientsController.Presenter
{
    public class ServerLogViewerPresenter : Presenter<IServerLogViewerView>
    {
        
        public ServerLogViewerPresenter(IServerLogViewerView view, Log model) : base(view)
        {
            Model = model;
        }
    }
}
