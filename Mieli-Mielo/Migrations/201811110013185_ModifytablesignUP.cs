namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifytablesignUP : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SignUps", "User_Login");
            DropColumn("dbo.SignUps", "MotDePasse");
            DropColumn("dbo.SignUps", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SignUps", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.SignUps", "MotDePasse", c => c.String());
            AddColumn("dbo.SignUps", "User_Login", c => c.String());
        }
    }
}
