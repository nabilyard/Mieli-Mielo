namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifytablesignUP5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Utilisateurs", name: "SignUps_SignUpId", newName: "SignUpId_SignUpId");
            RenameIndex(table: "dbo.Utilisateurs", name: "IX_SignUps_SignUpId", newName: "IX_SignUpId_SignUpId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Utilisateurs", name: "IX_SignUpId_SignUpId", newName: "IX_SignUps_SignUpId");
            RenameColumn(table: "dbo.Utilisateurs", name: "SignUpId_SignUpId", newName: "SignUps_SignUpId");
        }
    }
}
