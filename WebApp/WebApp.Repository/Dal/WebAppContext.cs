using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApp.Core;
using WebApp.Core.Models;
namespace WebApp.Repository.Dal
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(string connectionString)
            : base(connectionString)
        {

        }
        public DbSet<User> User { get; set; }
    }


    public class DbInitializer : CreateDatabaseIfNotExists<WebAppContext>
    {
        protected override void Seed(WebAppContext context)
        {
           // Task.Run(() => Seeds.InitializeData(context)).Wait();
        }
    }
}
