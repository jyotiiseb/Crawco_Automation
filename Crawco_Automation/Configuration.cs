using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace Crawco_Automation
{
    public static class Configuration
    {
        private static IConfigurationRoot _configuration;
        public static IConfigurationRoot AppConfig
        {
            get => _configuration;
            set => _configuration = value;
        }

        static Configuration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();
            AppConfig = builder.Build();
        }

        public static string getConfigValue(string key)
        {
            return Environment.GetEnvironmentVariable(key) ?? AppConfig[key];
        }

        public static string ComputerDatabaseUrl => string.Format(getConfigValue("computerDatabaseUrl"));
        public static string Browser => string.Format(getConfigValue("browser"));
    }
}