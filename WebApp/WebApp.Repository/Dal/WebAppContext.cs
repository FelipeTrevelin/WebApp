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
        static string _connection;
        public WebAppContext()
    : base(_connection ?? "DefaultConection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebAppContext, Migrations.Configuration>());
        }
        public WebAppContext(string connection)
    : base(connection)
        {
            _connection = connection;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebAppContext, Migrations.Configuration>());
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
