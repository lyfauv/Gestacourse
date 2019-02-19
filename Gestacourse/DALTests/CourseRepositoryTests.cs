using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace DAL.Tests
{
    [TestClass()]
    public class CourseRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            string attendu = "Course - Distance : 200 m";
            Course c = new Course(200);
            CourseRepository cr = new CourseRepository();
            cr.Save(c);
            List<Course> courses = cr.GetAll();
            string sortie = c.ToString();
            Assert.AreEqual(attendu, sortie);
        }
        
    }
}