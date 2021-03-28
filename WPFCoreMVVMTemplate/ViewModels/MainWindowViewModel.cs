using WPFCoreMVVMTemplate.Services.Interfaces;
using WPFCoreMVVMTemplate.ViewModels.Base;

namespace WPFCoreMVVMTemplate.ViewModels
{
    internal class MainWindowViewModel : WindowViewModel
    {
        private readonly IUserDialog _UserDialog;
        private readonly IDataService _DataService;

        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;
        }
    }
}
