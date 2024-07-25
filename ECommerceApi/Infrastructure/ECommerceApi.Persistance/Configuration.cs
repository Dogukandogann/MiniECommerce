using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistance
{
    static class Configuration
    {
        public static string ConnectionString { 
            get
            {
                ConfigurationManager manager = new();
                manager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceApi.Api"));
                manager.AddJsonFile("appsettings.json");
                return manager.GetConnectionString("PostgreSql");

            }
        }
    }
}
