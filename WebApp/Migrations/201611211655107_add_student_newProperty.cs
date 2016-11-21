namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_student_newProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "MyProperty", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 30));
            DropColumn("dbo.Students", "MyProperty");
        }
    }
}
