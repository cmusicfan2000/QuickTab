using System.ComponentModel;

namespace QuickTab.Generics
{
    /// <summary>
    /// Provides the PropertyChanged event and a handler for the event
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
