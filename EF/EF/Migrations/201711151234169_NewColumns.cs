namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "Grade", c => c.String(nullable: true));
            AddColumn("dbo.Students", "BirthDay", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDay");
            DropColumn("dbo.Classes", "Grade");
        }
    }
}
