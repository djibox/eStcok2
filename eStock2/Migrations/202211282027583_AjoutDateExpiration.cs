namespace eStock2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutDateExpiration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produits", "DateExpiration", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produits", "DateExpiration");
        }
    }
}
