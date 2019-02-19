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
    public class ResultatRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            string attendu = "Participant : Jean - Course : 300";

            // Sauvegarde du participant
            Participant p = new Participant("Jean", "Claude", "jc", new DateTime(2001, 01, 01), "M");
            Participant p2 = new Participant("Van", "Dam", "vd", new DateTime(2001, 01, 01), "M");
            ParticipantRepository pr = new ParticipantRepository();
            pr.Save(p);
            pr.Save(p2);       
            List<Participant> participants = pr.GetAll();

            //Sauvegarde de la course
            Course c = new Course(300);
            CourseRepository cr = new CourseRepository();
            cr.Save(c);
            List<Course> courses = cr.GetAll();

            //Sauvegarde du résultat
            Resultat r = new Resultat(p, c,new DateTime(2001,10,10,00,00,23));
            Resultat r2 = new Resultat(p2, c,new DateTime(2001, 10, 10, 00, 00,55));
            c.ClasserResultats();
            ResultatRepository rr = new ResultatRepository();
            rr.Save(r);
            rr.Save(r2);
            List<Resultat> resultats = rr.GetAll();
            string sortie = r.ToString();

            //test
            Assert.AreEqual(attendu,sortie);
        }
        
    }
}