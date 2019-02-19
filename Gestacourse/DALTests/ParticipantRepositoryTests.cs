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
    public class ParticipantRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            string attendu = "Jean Claude";

            Participant p = new Participant("Jean", "Claude", "jc", new DateTime(2001, 01, 01), "M");
            ParticipantRepository pr = new ParticipantRepository();
            pr.Save(p);
            List<Participant> participants = pr.GetAll();
            string sorti = p.ToString();
            Assert.AreEqual(attendu, sorti);
        }
    }
}