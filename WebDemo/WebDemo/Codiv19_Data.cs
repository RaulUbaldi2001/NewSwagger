using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo
{
    public class Codiv19_Data
    {
        public DateTime Data { get; set; }

        public int NuoviPositivi { get; set; }

        public string Regione { get; set; }

        public Codiv19_Data(DateTime data, string regione, int positivi)
        {
            Data = data;
            Regione = regione;
            NuoviPositivi = positivi;
        }
    }
}
