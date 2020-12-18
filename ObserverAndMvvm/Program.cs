using ObserverAndMvvm.CollectionChanged;
using ObserverAndMvvm.Command;
using ObserverAndMvvm.PropertyChanged;
using System;

namespace ObserverAndMvvm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INotifyPropertyChanged
            View view = new View();
            ViewModel viewModel = new ViewModel();
            view.DataContext = viewModel;

            viewModel.Value = 10;
            viewModel.Value = 20;
            viewModel.Value = 30;
            #endregion

            #region ICommand
            Bouton button = new Bouton();
            ButtonViewModel buttonViewModel = new ButtonViewModel();
            //binding ICommand avec la propriété Command du bouton
            button.Command = buttonViewModel.MyCommand;

            button.OnClick();
            #endregion

            #region INotifyCollectionChanged
            ItemsControl itemsControl = new ItemsControl();
            ObservableCollection<int> items = new ObservableCollection<int>();
            itemsControl.ItemsSource = items;

            items.Add(1);
            items.Add(2);
            items.Add(3);
            Console.WriteLine();
            Console.WriteLine("Current Values");
            foreach(int i in items)
                Console.WriteLine(i);

            items[1] = 5;

            Console.WriteLine();
            Console.WriteLine("Current Values");
            foreach (int i in items)
                Console.WriteLine(i);

            items.Remove(5);
            Console.WriteLine();
            Console.WriteLine("Current Values");
            foreach (int i in items)
                Console.WriteLine(i);

            items.Clear();
            if(items.Count == 0)
                Console.WriteLine("la collection est vide");
            #endregion
        }
    }
}
