using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndMvvm.CollectionChanged
{
    class CollectionViewModel
    {
        private ObservableCollection<int> _items;
        
        public ObservableCollection<int> Items
        {
            get
            {
                return _items ??= new ObservableCollection<int>();
            }
        }
    }
}
