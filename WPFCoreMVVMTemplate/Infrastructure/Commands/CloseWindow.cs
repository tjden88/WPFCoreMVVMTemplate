using System.Windows;
using WPR.MVVM.Commands;

namespace WPFCoreMVVMTemplate.Infrastructure.Commands
{
    /// <summary>Закрыть окно параметра, либо активное окно</summary>
    internal class CloseWindow : BaseCommand
    {

        private static Window GetWindow(object p) => p as Window ?? App.ActiveWindow;

        protected override bool CanExecute(object p) => GetWindow(p) != null;

        protected override void Execute(object p) => GetWindow(p)?.Close();
    }
}
