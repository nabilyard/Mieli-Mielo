namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApllyAnnotationsToCommande : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produits", "Nom", c => c.String(nullable: false));
            AlterColumn("dbo.Utilisateurs", "Nom", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilisateurs", "Nom", c => c.String());
            AlterColumn("dbo.Produits", "Nom", c => c.String());
        }
    }
}
