namespace Mieli_Mielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class confirmPassWord : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SignUps", "ConfirmPassWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SignUps", "ConfirmPassWord");
        }
    }
}
