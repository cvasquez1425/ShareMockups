namespace ShareMockups.DataContexts.ShareMockupsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mockups.ShareMockups",
                c => new
                    {
                        ShareMockupId = c.Int(nullable: false, identity: true),
                        MockupName = c.String(nullable: false),
                        Url = c.String(nullable: false, maxLength: 150),
                        Description = c.String(nullable: false, maxLength: 100),
                        Rate = c.Int(nullable: false),
                        Available = c.Boolean(nullable: false),
                        UserDefined = c.Int(nullable: false),
                        UserDefined2 = c.Boolean(nullable: false),
                        UserDefined3 = c.String(),
                    })
                .PrimaryKey(t => t.ShareMockupId);
            
        }
        
        public override void Down()
        {
            DropTable("mockups.ShareMockups");
        }
    }
}
