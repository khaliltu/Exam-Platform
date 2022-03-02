namespace Platform_Exam_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Platform : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserExams", "result", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserExams", "result");
        }
    }
}
