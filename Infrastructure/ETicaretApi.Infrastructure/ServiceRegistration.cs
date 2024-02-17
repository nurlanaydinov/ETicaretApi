using ETicaretApi.Application.Abstractions;
using ETicaretApi.Application.Abstractions.Token;
using ETicaretApi.Infrastructure.Enums;
using ETicaretApi.Infrastructure.Services.Storage;
using ETicaretApi.Infrastructure.Services.Storage.Azure;
using ETicaretApi.Infrastructure.Services.Storage.Local;
using ETicaretApi.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
