using Microsoft.Extensions.Configuration;
using System;

namespace AppiumTestProj.Configuration
{
    public static class ConfigurationLoader
    {
        private static readonly Lazy<IConfigurationRoot> _config = new Lazy<IConfigurationRoot>(() =>
           new ConfigurationBuilder().AddJsonFile("appsettings.json").Build());

        public static ISettings Settings => _config.Value.GetSection(nameof(Configuration.Settings)).Get<Settings>();
    }
}