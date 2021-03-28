using Microsoft.Extensions.DependencyInjection;

namespace WPFCoreMVVMTemplate.ViewModels.Base
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection AddViews(this IServiceCollection services) => services
           .AddSingleton<MainWindowViewModel>()
        ;
    }
}