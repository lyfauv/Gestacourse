using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IResultatRepository
    {
        /// <summary>
        /// Return all Resultats
        /// </summary>
        /// <returns></returns>
        List<Resultat> GetAll();

        /// <summary>
        /// Save a Resultats
        /// </summary>
        /// <param name="Resultat">Resultat</param>
        void Save(Resultat resultat);
    }
}