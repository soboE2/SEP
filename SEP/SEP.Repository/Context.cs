using SEP.Contract.DbSet;
using SEP.Model.Model;
using SEP.Repository.Config;
using System.Data.Entity;

namespace SEP.Repository
{
    public class Context : DbContext, IDbContext
    {
        public Context(string connectionName)
            : base(connectionName)
        {
        }
        public Context()
            : base("Name=InsuranceDb")
        {
        }

        public DbSet<InsuranceType> InsuranceTypes { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<InsuranceRisk> InsuranceRisks { get; set; }
        public DbSet<RiskItem> RiskItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InsuranceTypeConfig());
            modelBuilder.Configurations.Add(new RiskConfig());
            modelBuilder.Configurations.Add(new InsuranceRiskConfig());
            modelBuilder.Configurations.Add(new RiskItemConfig());
        }

        public int Complete()
        {
            return SaveChanges();
        }

        public void Rollback()
        {
            Rollback();
        }
    }
}