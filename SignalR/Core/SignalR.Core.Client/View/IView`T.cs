using SignalR.Core.Presenter;

namespace SignalR.Core.View
{
    public interface IView<TView> : IView where TView : class, IView<TView>
    {
        Presenter<TView> Presenter { get; set; }
    }
}
