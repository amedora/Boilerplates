using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;
using ReactiveUI;

namespace TaskbarApp.WPF
{
    class MainWindowViewModel
    {
        #region プロパティ
        public Action<string, string, BalloonIcon> ShowBalloonTip { get; set; }
        #endregion

        #region コマンド
        private ReactiveCommand _ApplicationExitCommand;
        public ReactiveCommand ApplicationExitCommand => _ApplicationExitCommand;
        #endregion

        public MainWindowViewModel()
        {
            InitializeCommand();

            // Show balloon example
            Observable
                .Timer(TimeSpan.FromSeconds(3))
                .Subscribe(_ => this.ShowBalloonTip("Balloon Title", "Balloon Contents", BalloonIcon.Info));
        }

        private void InitializeCommand()
        {
            _ApplicationExitCommand = ReactiveCommand.Create(() => Application.Current.Shutdown());
        }
    }
}
