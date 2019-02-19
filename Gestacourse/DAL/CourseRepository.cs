﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {
        public List<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }

        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
            Session.Flush();
        }
    }
}
