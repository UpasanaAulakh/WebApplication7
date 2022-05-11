namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        subject = c.String(),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
