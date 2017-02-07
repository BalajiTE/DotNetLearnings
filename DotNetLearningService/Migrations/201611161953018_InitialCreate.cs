namespace DotNetLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LanguageConcept",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        TechnologyLanguageID = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TechnologyLanguage", t => t.TechnologyLanguageID, cascadeDelete: true)
                .Index(t => t.TechnologyLanguageID);
            
            CreateTable(
                "dbo.TechnologyLanguage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        TechnologyTypeID = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TechnologyType", t => t.TechnologyTypeID, cascadeDelete: true)
                .Index(t => t.TechnologyTypeID);
            
            CreateTable(
                "dbo.TechnologyType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LanguageConcept", "TechnologyLanguageID", "dbo.TechnologyLanguage");
            DropForeignKey("dbo.TechnologyLanguage", "TechnologyTypeID", "dbo.TechnologyType");
            DropIndex("dbo.TechnologyLanguage", new[] { "TechnologyTypeID" });
            DropIndex("dbo.LanguageConcept", new[] { "TechnologyLanguageID" });
            DropTable("dbo.TechnologyType");
            DropTable("dbo.TechnologyLanguage");
            DropTable("dbo.LanguageConcept");
        }
    }
}
