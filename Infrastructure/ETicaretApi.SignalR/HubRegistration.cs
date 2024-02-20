using ETicaretApi.SignalR.Hubs;
using Microsoft.AspNetCore.Builder;

namespace ETicaretApi.SignalR
{
    static public class HubRegistration
    {
        public static void MapHubs(this WebApplication webApplication)
        {
            webApplication.MapHub<ProductHub>("/products-hub");
        }
    }
}
