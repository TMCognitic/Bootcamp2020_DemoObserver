using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndMvvm.CollectionChanged
{
    public class ItemsControl
    {
        private IEnumerable _itemsSource;

        public IEnumerable ItemsSource
        {
            get
            {
                return _itemsSource;
            }

            set
            {
                if (_itemsSource is not null && _itemsSource is INotifyCollectionChanged oldItemsSource)
                    oldItemsSource.CollectionChanged -= OnCollectionChanged;

                _itemsSource = value;

                if (_itemsSource is not null && _itemsSource is INotifyCollectionChanged newItemsSource)
                    newItemsSource.CollectionChanged += OnCollectionChanged;
            }
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Un élément a été ajouté à l'index {e.NewStartingIndex} : {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"l'élément à l'index {e.OldStartingIndex} a été rétiré");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"l'élément à l'index {e.NewStartingIndex} ({e.OldItems[0]}) a été remplacé par : {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("La collection a été réinitialisée...");
                    break;
            }
        }
    }
}
