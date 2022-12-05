namespace eStock2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fournisseur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        AdressePhysique = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Produits", "FournisseurId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produits", "FournisseurId");
            AddForeignKey("dbo.Produits", "FournisseurId", "dbo.Fournisseurs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "FournisseurId", "dbo.Fournisseurs");
            DropIndex("dbo.Produits", new[] { "FournisseurId" });
            DropColumn("dbo.Produits", "FournisseurId");
            DropTable("dbo.Fournisseurs");
        }
    }
}
