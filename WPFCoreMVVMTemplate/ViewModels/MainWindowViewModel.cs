using WPFCoreMVVMTemplate.Services.Interfaces;
using WPR.MVVM.ViewModels;
using System;

namespace WPFCoreMVVMTemplate.ViewModels
{
    internal class MainWindowViewModel : WindowViewModel
    {
        private readonly IUserDialog _UserDialog;

        public MainWindowViewModel(IUserDialog UserDialog)
        {
            Title = "Главное окно";
            _UserDialog = UserDialog;
        }
    }
}
