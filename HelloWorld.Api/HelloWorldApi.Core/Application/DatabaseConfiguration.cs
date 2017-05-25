using System.Configuration;

namespace HelloWorldApi.Core.Application
{
    public class DatabaseConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("ConnectionString", IsRequired = true)]

        public string Connection
        {
            get => this["ConnectionString"].ToString();
            set => this["ConnectionString"] = value;
        }
    }
}
