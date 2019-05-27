using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    // public DbSet<Evenimente> Evenimentes { get; set; }

    public class Evenimente
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Data { get; set; }
        public string Locatie { get; set; }
    };
}