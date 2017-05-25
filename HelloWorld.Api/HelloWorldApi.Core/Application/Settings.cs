using System.Configuration;

namespace HelloWorldApi.Core.Application
{
    public static class Settings
    {
        public static DatabaseConfiguration DatabaseConfig { get; internal set; }
        public static void Initialize()
        {
            DatabaseConfig = ConfigurationManager.GetSection("Connection") as DatabaseConfiguration;
        }
    }
}
