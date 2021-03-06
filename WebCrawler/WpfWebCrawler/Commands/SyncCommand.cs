﻿using System;
using System.Windows.Input;

namespace WpfWebCrawler.Commands
{
    public class SyncCommand : ICommand
    {
        #region Private Members

        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        #endregion

        #region Ctor

        public SyncCommand(Action<object> execute,Predicate<object> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        #endregion

        #region Public Methods

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion
    }
}
