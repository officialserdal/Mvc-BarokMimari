namespace Biyografi_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdate : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Kraliçeler");
            DropTable("dbo.Krallars");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Krallars",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        Açiklama = c.String(),
                        Başlik = c.String(),
                        Fotourl = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
            CreateTable(
                "dbo.Kraliçeler",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        Açiklama = c.String(),
                        Başlik = c.String(),
                        Fotourl = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
        }
    }
}
