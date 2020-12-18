using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tools.Mvvm.Commands;

namespace ObserverAndMvvm.Command
{
    class ButtonViewModel
    {
        private ICommand _myCommand;

        public ICommand MyCommand
        {
            get
            {
                return _myCommand ??= new DelegateCommand(() => Console.WriteLine("Je fais quelque chose"));
            }
        }
    }
}
