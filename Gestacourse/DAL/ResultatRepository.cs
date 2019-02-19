﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ResultatRepository : Repository, IResultatRepository
    {
        public List<Resultat> GetAll()
        {
            return Session.Query<Resultat>().ToList();
        }

        public void Save(Resultat resultat)
        {
            Session.SaveOrUpdate(resultat);
            Session.Flush();
        }
    }
}
