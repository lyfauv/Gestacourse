using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipantRepository : Repository, IParticipantRepository
    {
        public List<Participant> GetAll()
        {
            return Session.Query<Participant>().ToList();
        }

        public void Save(Participant participant)
        {
            Session.SaveOrUpdate(participant);
            Session.Flush();
        }
    }
}
