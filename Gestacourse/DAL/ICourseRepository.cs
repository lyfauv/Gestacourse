using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICourseRepository
    {
        /// <summary>
        /// Return all courses
        /// </summary>
        /// <returns></returns>
        List<Course> GetAll();

        /// <summary>
        /// Save a participants
        /// </summary>
        /// <param name="participant">Participant</param>
        void Save(Course course);
    }
}
