namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezervareClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RezervareClients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeEveniment = c.String(),
                        Data = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Adresa = c.String(),
                        NumarTelefon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RezervareClients");
        }
    }
}
