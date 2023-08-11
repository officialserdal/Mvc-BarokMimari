namespace Biyografi_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourMigrationName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kiliselers",
                c => new
                    {
                        YapımYılı = c.Int(nullable: false, identity: true),
                        kiliseAdi = c.String(),
                        Açiklama = c.String(),
                    })
                .PrimaryKey(t => t.YapımYılı);
            
            CreateTable(
                "dbo.Kraliçeler",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        Açiklama = c.String(),
                        Başlik = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
            CreateTable(
                "dbo.Krallars",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        Açiklama = c.String(),
                        Başlik = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
            CreateTable(
                "dbo.Saraylars",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        SarayAdi = c.String(),
                        Açiklama = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Saraylars");
            DropTable("dbo.Krallars");
            DropTable("dbo.Kraliçeler");
            DropTable("dbo.Kiliselers");
        }
    }
}
