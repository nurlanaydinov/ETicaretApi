using ETicaretApi.Application.Abstractions.Hubs;
using ETicaretApi.SignalR.HubServices;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApi.SignalR
{
    static public class ServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection collection)
        {
            collection.AddTransient<IProductHubService, ProductHubService>();
            collection.AddSignalR();
        }
    }
}
