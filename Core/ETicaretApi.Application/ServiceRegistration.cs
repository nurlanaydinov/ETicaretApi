﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApi.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
