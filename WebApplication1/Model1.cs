namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.RezervareClient> RezervareClients { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Evenimente> Evenimentes { get; set; }
    }
}
