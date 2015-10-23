using System;

namespace SignalR.Core.View
{
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler Load;

        /// <summary>  
        /// Load Data into controls  
        /// </summary>  
        void LoadView(EventArgs e);
        
        /// <summary>  
        /// Property changed notification  
        /// </summary>  
        /// <param name="propertyName"></param>  
        void OnPropertyChanged(string propertyName);  
    }
}
