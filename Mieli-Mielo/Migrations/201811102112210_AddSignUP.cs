namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSignUP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SignUps",
                c => new
                    {
                        SignUpId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        PassWord = c.String(),
                        User_Login = c.String(),
                        MotDePasse = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SignUpId);
            
            AddColumn("dbo.Utilisateurs", "Authentification_SignUpId", c => c.Int());
            CreateIndex("dbo.Utilisateurs", "Authentification_SignUpId");
            AddForeignKey("dbo.Utilisateurs", "Authentification_SignUpId", "dbo.SignUps", "SignUpId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilisateurs", "Authentification_SignUpId", "dbo.SignUps");
            DropIndex("dbo.Utilisateurs", new[] { "Authentification_SignUpId" });
            DropColumn("dbo.Utilisateurs", "Authentification_SignUpId");
            DropTable("dbo.SignUps");
        }
    }
}
