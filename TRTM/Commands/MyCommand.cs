using System;
using System.Windows.Input;

namespace TRTM.Commands
{
    public class MyCommand : ICommand
    {
        private Action<object?> _execute;
        private Func<bool> _canExecute;
        public MyCommand(Action<object> execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute();
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public event EventHandler? CanExecuteChanged;
    }
}
