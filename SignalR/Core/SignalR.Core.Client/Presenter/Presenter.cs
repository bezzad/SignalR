using System;
using System.Windows.Forms;
using SignalR.Core.Model;
using SignalR.Core.View;

namespace SignalR.Core.Presenter
{
    public class Presenter<TView> : IPresenter where TView : class, IView<TView>
    {
        public TView View { get; protected set; }
        public IModel Model { get; protected set; }

        public Presenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            View = view;
            View.Presenter = this;
            View.Initialize += OnViewInitialize;
            View.Load += OnViewLoad;
        }

        protected virtual void OnViewInitialize(object sender, EventArgs e)
        {
        }

        protected virtual void OnViewLoad(object sender, EventArgs e)
        {
        }

        public virtual void SafeInvoker(Action action)
        {
            var frmView = View as Form;

            if (frmView == null) return;


            if (frmView.InvokeRequired)
            {
                frmView.Invoke(new Action(action));
            }
            else
            {
                action();
            }
        }
    }
}
