using System;
using System.Windows;
using WPFCoreMVVMTemplate.Infrastructure.Commands.Base;

namespace WPFCoreMVVMTemplate.Infrastructure.Commands
{
    class CloseWindow : BaseCommand
    {

        private static Window GetWindow(object p) => p as Window ?? App.ActiveWindow;

        protected override bool CanExecute(object p) => GetWindow(p) != null;

        protected override void Execute(object p) => GetWindow(p)?.Close();
    }
}
