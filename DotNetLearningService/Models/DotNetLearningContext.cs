using DotNetLearningModel.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DotNetLearningService.Models
{
    public class DotNetLearningContext : DbContext
    {
        public DotNetLearningContext() : base("DotNetLearnings")
            //: base("Data Source=DESKTOP-BSV3G59\\SQLEXPRESS;Initial Catalog=JusticeServices;Integrated Security=SSPI;MultipleActiveResultSets=True")
        {
            //Database.Initialize(false);            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<TechnologyType> TechnologyType { get; set; }

        public DbSet<TechnologyLanguage> TechnologyLanguage { get; set; }

        public DbSet<TechnologyConcept> TechnologyConcept { get; set; }

        public DbSet<LanguageConcept> LanguageConcept { get; set; }
    }
}