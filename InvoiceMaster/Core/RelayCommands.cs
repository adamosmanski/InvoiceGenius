using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvoiceMaster.Core
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;

        private Func<object, bool> _canExecute;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else this._execute = execute;
            _canExecute = canExecute;
        }
        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            if (_canExecute == null) return true;
            else return _canExecute(parameter);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
        }

        public void Execute(object? parameter)
        {
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            _execute(parameter);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
        }
    }
}
