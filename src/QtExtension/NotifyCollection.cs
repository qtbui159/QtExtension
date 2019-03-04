using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Qt
{
    public class NotifyCollection<T> : ObservableCollection<T>, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        public NotifyCollection()
        {

        }

        public void NotifyCollectionChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }
    }
}
