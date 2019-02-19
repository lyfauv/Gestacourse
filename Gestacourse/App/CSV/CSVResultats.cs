using CsvHelper.Configuration;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CSV
{
    class CSVResultats : ClassMap<Resultat>
    {
        public CSVResultats()
        {
            Map(m => m.Coureur.NbDossard).Name("dossard");
            Map(m => m.Temps).Name("temps");
        }
    }
}
