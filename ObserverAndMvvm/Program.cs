using ObserverAndMvvm.PropertyChanged;
using System;

namespace ObserverAndMvvm
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            ViewModel viewModel = new ViewModel();
            view.DataContext = viewModel;

            viewModel.Value = 10;
            viewModel.Value = 20;
            viewModel.Value = 30;
        }
    }
}
