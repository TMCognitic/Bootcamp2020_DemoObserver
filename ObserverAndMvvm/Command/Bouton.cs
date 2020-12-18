using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ObserverAndMvvm.Command
{
    class Bouton
    {
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }

        public void OnClick()
        {
            if (Command is not null)
                if (Command.CanExecute(CommandParameter))
                    Command.Execute(CommandParameter);
        }
    }
}
