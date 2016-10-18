﻿namespace SimpleSoft.DependencyInjection.Tests.ServiceMocks.ForConfigurator
{
    using Microsoft.Extensions.DependencyInjection;

    public class MockServiceConfigurator : IServiceConfigurator
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IMockServiceConfiguratorService, MockServiceConfiguratorService>();
        }
    }
}
