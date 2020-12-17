using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndMvvm.PropertyChanged
{
    class View
    {
        private object _dataContext;

        public object DataContext
        {
            get
            {
                return _dataContext;
            }

            set
            {
                if(_dataContext is not null && _dataContext is INotifyPropertyChanged oldDataContext)
                {
                    oldDataContext.PropertyChanged -= OnPropertyChanged;
                }

                _dataContext = value;

                if (_dataContext is not null && _dataContext is INotifyPropertyChanged newDataContext)
                {
                    newDataContext.PropertyChanged += OnPropertyChanged;
                }
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Type senderType = sender.GetType();
            PropertyInfo property = senderType.GetProperty(e.PropertyName);
            object newValue = property.GetMethod.Invoke(sender, null);

            Console.WriteLine($"la propriété '{e.PropertyName}' de mon ViewModel a changée : {newValue}");
        }
    }
}
