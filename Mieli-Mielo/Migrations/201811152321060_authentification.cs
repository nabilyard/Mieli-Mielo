namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authentification : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SignUps", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SignUps", "Email", c => c.String());
        }
    }
}
