using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuGet.Frameworks;

namespace POO3.Models
{
    public class Episodio
    {
        public int Id { get; set; }
        public int Idserie { set; get; }
        public string Nomeepisodio { get; set; }
        public int Numeroepisodio { get; set; }
        public int Temporada { get; set; }
        public int Avaliacao { get; set; }

        public Episodio()
        {

        }
    }
}
