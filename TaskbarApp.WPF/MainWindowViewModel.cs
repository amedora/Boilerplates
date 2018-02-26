using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;

namespace TaskbarApp.WPF
{
    class MainWindowViewModel
    {
        #region コマンド
        private ReactiveCommand _ApplicationExitCommand;
        public ReactiveCommand ApplicationExitCommand => _ApplicationExitCommand;
        #endregion

        public MainWindowViewModel()
        {
            InitializeCommand();
        }

        private void InitializeCommand()
        {
            _ApplicationExitCommand = ReactiveCommand.Create(() => Application.Current.Shutdown());
        }
    }
}
