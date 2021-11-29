using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class AanvullendGegeven
    {
        public string Omschrijving { get; set; }
    }

    public class AantalModel  : AanvullendGegeven
    {
        public int? Aantal { get; set; }
    }

    public class BedragModel : AanvullendGegeven
    {
        public decimal? Bedrag { get; set; }
    }

    public class Container
    {
        public string A { get; set; }
        public string B { get; set; }
        public List<AanvullendGegeven> People { get; set; }
    }
}
