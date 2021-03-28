using Microsoft.Extensions.DependencyInjection;

namespace WPFCoreMVVMTemplate.ViewModels.Base
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
