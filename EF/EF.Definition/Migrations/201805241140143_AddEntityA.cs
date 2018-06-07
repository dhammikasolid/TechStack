namespace EFAndDapper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntityA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntityWithCommonDataAnnotations",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        S1 = c.String(nullable: false, maxLength: 128),
                        D1 = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntityWithCommonDataAnnotations");
        }
    }
}
