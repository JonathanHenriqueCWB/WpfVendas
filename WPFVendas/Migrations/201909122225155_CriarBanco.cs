namespace WPFVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
