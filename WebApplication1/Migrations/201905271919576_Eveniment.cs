namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eveniment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evenimentes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Data = c.String(),
                        Locatie = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evenimentes");
        }
    }
}
