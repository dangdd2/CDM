using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tmag.ConsumerData.Models;

namespace Tmag.ConsumerData
{
    public enum ConnectionType
    {
        Local,
        Dev,
        Prod
    }

    public class Context : DbContext
    {
        private readonly string _connectionString;

        string GetConnectionString(ConnectionType type)
        {
            string connection= string.Empty;
            switch (type)
            {
                case ConnectionType.Local:
                    connection = "Data Source=.;Initial Catalog=TmagCdm2Dev;Integrated Security=True;";                   
                    break;

                case ConnectionType.Dev:
                    connection = "Server=tcp:tmcdmdev.database.windows.net,1433;Initial Catalog=TmagCdm2Dev;Persist Security Info=False;User ID=TmagSqlDevuser;Password=Tm@gDev#Pass;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=600;";
                    break;

                case ConnectionType.Prod:
                    connection = "Server=tcp:tmcdmprod.database.windows.net,1433;Initial Catalog=TmagCdm2;Persist Security Info=False;User ID=TmagSqlProduser;Password=Tm@gP0d#Golf3r;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    break;
                default:
                    throw new ArgumentException("The connection type is not valid.");
            }

            return connection;
        }
        public Context()
        {
            _connectionString = GetConnectionString(ConnectionType.Local);           
        }

        public Context(string connectionString)
        {
            _connectionString = connectionString;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                                                .SelectMany(t => t.GetForeignKeys())
                                                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<Consumer>().HasIndex(x => x.PrimaryEmail).IsUnique();
            modelBuilder.Entity<ConsumerProfile>().HasIndex(x => x.RegionId).IsUnique();
            modelBuilder.Entity<ConsumerProfile>().HasIndex(x => new { x.RegionId, x.ConsumerId }).IsUnique();
            modelBuilder.Entity<ConsumerOptIn>().HasIndex(x => new { x.ConsumerProfileId, x.Key }).IsUnique();

            var strings = modelBuilder.Model.GetEntityTypes()
                            .SelectMany(t => t.GetProperties().Where(y => y.ClrType == typeof(string)));

            foreach (var s in strings)
                s.SetMaxLength(2000);
            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Address> Addresses { get; set; }
        public DbSet<ClubCategoryType> ClubCategoryTypes { get; set; }
        public DbSet<ClubLoftAdjustment> ClubLoftAdjustments { get; set; }
        public DbSet<BagModel> BagModels { get; set; }
        public DbSet<BagPanelFont> BagPanelFonts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ClubCategory> ClubCategorys { get; set; }
        public DbSet<ClubLie> ClubLies { get; set; }
        public DbSet<ClubLoft> ClubLofts { get; set; }
        public DbSet<ClubShaftFlex> ClubShaftFlexs { get; set; }
        public DbSet<ClubShaftLength> ClubShaftLengths { get; set; }
        public DbSet<ConsumerBagPanelCampaign> ConsumerBagPanelCampaigns { get; set; }
        public DbSet<ConsumerEmail> ConsumerEmails { get; set; }
        public DbSet<ConsumerExperience> ConsumerExperiences { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<ConsumerAudit> ConsumersAudit { get; set; }
        public DbSet<ConsumerOptIn> ConsumerOptIns { get; set; }
        public DbSet<ConsumerProfile> ConsumerProfiles { get; set; }
        public DbSet<ExperienceLocation> ExperienceLocations { get; set; }
        public DbSet<GolferProfile> GolferProfiles { get; set; }
        public DbSet<HandicapRange> HandicapRanges { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<PointOfPurchase> PointOfPurchases { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RetailStore> RetailStores { get; set; }
        public DbSet<WhatsInTheBag> WhatsInTheBags { get; set; }
        public DbSet<SystemToConsumerProfile> SystemToConsumerProfiles { get; set; }
        public DbSet<Models.System> Systems { get; set; }
        public DbSet<ConsumerExperienceTransfer> ConsumerExperienceTransfer { get; set; }
        public DbSet<MfeUserIds> MfeUserIds { get; set; }
    }
}
