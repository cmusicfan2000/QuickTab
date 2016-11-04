using System;
using System.Windows.Input;

namespace QuickTab.Generics
{
    public class RelayCommand : ICommand
    {
        #region [ Properties ]
        private Action<object> execute;
        private Predicate<object> canExecute;
        #endregion

        #region [ Events ]
        public event EventHandler CanExecuteChanged;
        #endregion

        #region [ Constructor ]
        /// <summary>
        /// Creates a new relay command
        /// </summary>
        /// <param name="executeAction">The action to ren when the command is executed</param>
        /// <param name="canExecutePredicate">A method used to determine if the command may execute</param>
        public RelayCommand(Action<object> executeAction, Predicate<object> canExecutePredicate = null)
        {
            execute = executeAction;
            canExecute = canExecutePredicate;
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Gets if the command may execute
        /// </summary>
        /// <param name="parameter">parameter to pass to the canExecute method</param>
        /// <returns>
        /// True if the command can execute or if no canExecute method was specified
        /// False if the command may not execute
        /// </returns>
        public bool CanExecute(object parameter)
        {
            if(canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute.Invoke(parameter);
            }
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="parameter">A parameter to pass to execute</param>
        public void Execute(object parameter)
        {
            execute(parameter);
        }
        #endregion

    }
}
