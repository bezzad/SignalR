using System.ComponentModel;

namespace SignalR.Core.Model
{
    public abstract class Model : IModel
    {
        #region IModel Members

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void Fire(string propertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
