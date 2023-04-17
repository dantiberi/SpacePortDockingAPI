using Serilog;
using Microsoft.EntityFrameworkCore;
using SpacePortDockingAPI.Models.DatabaseModels;

namespace SpacePortDockingAPI.Objects
{
    //https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
    public class DBDriver : DbContext
    {
        public string DbPath { get; }
        public DBDriver() 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "database.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        public DbSet<SpacePortDockingAPI.Models.DatabaseModels.Starship>? Starship { get; set; }
        public DbSet<SpacePortDockingAPI.Models.DatabaseModels.Captain>? Captain { get; set; }
        public DbSet<SpacePortDockingAPI.Models.DatabaseModels.DockingInvoice>? DockingInvoice { get; set; }
        public DbSet<SpacePortDockingAPI.Models.DatabaseModels.Faction>? Faction { get; set; }
        public DbSet<SpacePortDockingAPI.Models.DatabaseModels.ShipClass>? ShipClass { get; set; }
  
    }
}
