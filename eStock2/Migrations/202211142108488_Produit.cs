namespace eStock2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Prix = c.Int(nullable: false),
                        Quantite = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
        }
    }
}
