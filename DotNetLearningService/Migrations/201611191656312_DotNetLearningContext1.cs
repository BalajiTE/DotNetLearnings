namespace DotNetLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DotNetLearningContext1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TechnologyConcept",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LanguageConcept", "TechnologyConceptID", c => c.Int(nullable: false));
            CreateIndex("dbo.LanguageConcept", "TechnologyConceptID");
            AddForeignKey("dbo.LanguageConcept", "TechnologyConceptID", "dbo.TechnologyConcept", "ID", cascadeDelete: true);
            DropColumn("dbo.LanguageConcept", "Name");
            DropColumn("dbo.LanguageConcept", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LanguageConcept", "Description", c => c.String());
            AddColumn("dbo.LanguageConcept", "Name", c => c.String(nullable: false));
            DropForeignKey("dbo.LanguageConcept", "TechnologyConceptID", "dbo.TechnologyConcept");
            DropIndex("dbo.LanguageConcept", new[] { "TechnologyConceptID" });
            DropColumn("dbo.LanguageConcept", "TechnologyConceptID");
            DropTable("dbo.TechnologyConcept");
        }
    }
}
