using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo
{
    public class RepositoryCovid
    {
        public List<Codiv19_Data> LoadCovidUmbria()
        {
            List<Codiv19_Data> listNuoviPostivi = new List<Codiv19_Data>();

            Codiv19_Data r0 = new Codiv19_Data(new DateTime(2020, 03, 12), "Umbria", 30);
            listNuoviPostivi.Add(r0);
            Codiv19_Data r1 = new Codiv19_Data(new DateTime(2020, 03, 15), "Umbria", 36);
            listNuoviPostivi.Add(r1);
            Codiv19_Data r2 = new Codiv19_Data(new DateTime(2020, 03, 16), "Umbria", 20);
            listNuoviPostivi.Add(r2);
            Codiv19_Data r4 = new Codiv19_Data(new DateTime(2020, 03, 21), "Umbria", 14);
            listNuoviPostivi.Add(r4);

            return listNuoviPostivi;
        }
    }
}
