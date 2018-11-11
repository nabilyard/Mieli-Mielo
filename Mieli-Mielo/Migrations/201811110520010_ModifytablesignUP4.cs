namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifytablesignUP4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Utilisateurs", name: "Authentification_SignUpId", newName: "SignUps_SignUpId");
            RenameIndex(table: "dbo.Utilisateurs", name: "IX_Authentification_SignUpId", newName: "IX_SignUps_SignUpId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Utilisateurs", name: "IX_SignUps_SignUpId", newName: "IX_Authentification_SignUpId");
            RenameColumn(table: "dbo.Utilisateurs", name: "SignUps_SignUpId", newName: "Authentification_SignUpId");
        }
    }
}
