using System.Data.Entity;

namespace DotNetLearningService.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DotNetLearningContext>
    {
        protected override void Seed(DotNetLearningContext context)
        {
            context.SaveChanges();
        }
    }
}