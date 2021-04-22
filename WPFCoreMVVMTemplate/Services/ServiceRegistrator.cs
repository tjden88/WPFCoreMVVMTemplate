using Microsoft.Extensions.DependencyInjection;
using WPFCoreMVVMTemplate.Services.Interfaces;

namespace WPFCoreMVVMTemplate.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<IUserDialog, UserDialog>()
        ;
    }
}
