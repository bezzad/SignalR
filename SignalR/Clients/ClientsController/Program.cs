using System;
using System.Windows.Forms;
using ClientsController.Presenter;
using ClientsController.View;
using SignalR.Core.Model;
using SignalR.Core.Presenter;
using SignalR.Core.View;

namespace ClientsController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            IModel model = new User();
            IMainControllerView mainForm = new MainControllerForm();
            Presenter<IMainControllerView> presenter = new MainControllerPresenter(mainForm, model);

            Application.Run((Form)mainForm);
        }
    }
}