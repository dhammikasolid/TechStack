namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntityA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        BirthDay = c.DateTime(),
                        Class1Id = c.Int(nullable: false),
                        Class2Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class1Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class2Id)
                .Index(t => t.Class1Id)
                .Index(t => t.Class2Id);
            
            CreateTable(
                "dbo.StudentProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ContactNo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ClassTeachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Participation = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.ClassId })
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subject = c.String(),
                        ReportsToId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.ReportsToId)
                .Index(t => t.ReportsToId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "ReportsToId", "dbo.Teachers");
            DropForeignKey("dbo.ClassTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.ClassTeachers", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Students", "Class2Id", "dbo.Classes");
            DropForeignKey("dbo.Students", "Class1Id", "dbo.Classes");
            DropForeignKey("dbo.StudentProfiles", "Id", "dbo.Students");
            DropIndex("dbo.Teachers", new[] { "ReportsToId" });
            DropIndex("dbo.ClassTeachers", new[] { "ClassId" });
            DropIndex("dbo.ClassTeachers", new[] { "TeacherId" });
            DropIndex("dbo.StudentProfiles", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "Class2Id" });
            DropIndex("dbo.Students", new[] { "Class1Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.ClassTeachers");
            DropTable("dbo.StudentProfiles");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
