namespace DotNetLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DotNetLearningContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LanguageConcept", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TechnologyLanguage", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TechnologyType", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TechnologyType", "Name", c => c.String());
            AlterColumn("dbo.TechnologyLanguage", "Name", c => c.String());
            AlterColumn("dbo.LanguageConcept", "Name", c => c.String());
        }
    }
}
