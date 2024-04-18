using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajózás
{
    public class Kérdés
    {
        //Szam,Kerdes,V1,V2,V3,Kep,HelyesValasz
        public double Szam { get; set; }
        public string Kerdes { get; set; } = string.Empty;
        public string V1 { get; set; } = string.Empty;
        public string V2 { get; set; } = string.Empty;
        public string V3 { get; set; } = string.Empty;
        public string Kep { get; set; } = string.Empty;
        public int HelyesValasz { get; set; }
        public bool Igaz { get; set; }
    }
}
