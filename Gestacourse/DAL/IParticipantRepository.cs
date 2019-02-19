using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IParticipantRepository
    {
        /// <summary>
        /// Return all participants
        /// </summary>
        /// <returns></returns>
        List<Participant> GetAll();

        /// <summary>
        /// Save a participants
        /// </summary>
        /// <param name="participant">Participant</param>
        void Save(Participant participant);
    }
}
