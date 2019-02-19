using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Domain;
using CsvHelper.Configuration;

namespace App
{
    class CSVParticipant : ClassMap<Participant>
    {
        public CSVParticipant()
        {
            Map(m => m.Nom).Name("nom");
            Map(m => m.Prenom).Name("prenom");
            Map(m => m.DateNaissance).Name("annee_naissance");
            Map(m => m.Sexe).Name("sexe");
            Map(m => m.Courriel).Name("courriel");
            Map(m => m.NumLicenceFFA).Name("licence");
        }
    }
}
