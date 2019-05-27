using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RezervareClient
    {
        public int ID { get; set; }
        public string NumeEveniment { get; set; }
        public string Data { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public int NumarTelefon { get; set; }

    }
}