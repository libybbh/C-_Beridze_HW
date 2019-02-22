using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Beridze_1
{
    public class RelayCommand : ICommand
    {
        private Predicate<object> m_canExecute;
        private Action<object> m_execute;

        public RelayCommand(Action<object> execute)
        {
            m_execute = execute;
        }

        public RelayCommand(Predicate<object> canExecute, Action<object> execute)
        {
            m_canExecute = CanExecute;
            m_execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            if (m_canExecute == null)
            {
                return true;
            }

            return m_canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (m_execute != null)
            {
                m_execute(parameter);
            }
        }
    }
}
