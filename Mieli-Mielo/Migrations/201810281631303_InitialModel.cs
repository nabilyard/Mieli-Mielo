namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        CommandeID = c.Int(nullable: false, identity: true),
                        DateCommande = c.DateTime(nullable: false),
                        UtilisateurId = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.CommandeID)
                .ForeignKey("dbo.Utilisateurs", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prix = c.Double(nullable: false),
                        Com_CommandeID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Commandes", t => t.Com_CommandeID)
                .Index(t => t.Com_CommandeID);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commandes", "User_UserID", "dbo.Utilisateurs");
            DropForeignKey("dbo.Produits", "Com_CommandeID", "dbo.Commandes");
            DropIndex("dbo.Produits", new[] { "Com_CommandeID" });
            DropIndex("dbo.Commandes", new[] { "User_UserID" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Produits");
            DropTable("dbo.Commandes");
        }
    }
}
