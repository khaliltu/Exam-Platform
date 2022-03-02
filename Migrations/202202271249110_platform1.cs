namespace Platform_Exam_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class platform1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        idExam = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        minScorPercent = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.idExam);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        idQuest = c.Int(nullable: false, identity: true),
                        content = c.String(),
                        answer = c.String(),
                        option1 = c.String(),
                        option2 = c.String(),
                        idExam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idQuest)
                .ForeignKey("dbo.Exams", t => t.idExam, cascadeDelete: true)
                .Index(t => t.idExam);
            
            CreateTable(
                "dbo.UserExams",
                c => new
                    {
                        idUserExam = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        score = c.Int(nullable: false),
                        idUser = c.Int(nullable: false),
                        idExam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUserExam)
                .ForeignKey("dbo.Exams", t => t.idExam, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.idUser, cascadeDelete: true)
                .Index(t => t.idUser)
                .Index(t => t.idExam);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        mail = c.String(),
                        password = c.String(),
                        name = c.String(),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.idUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserExams", "idUser", "dbo.Users");
            DropForeignKey("dbo.UserExams", "idExam", "dbo.Exams");
            DropForeignKey("dbo.Questions", "idExam", "dbo.Exams");
            DropIndex("dbo.UserExams", new[] { "idExam" });
            DropIndex("dbo.UserExams", new[] { "idUser" });
            DropIndex("dbo.Questions", new[] { "idExam" });
            DropTable("dbo.Users");
            DropTable("dbo.UserExams");
            DropTable("dbo.Questions");
            DropTable("dbo.Exams");
        }
    }
}
