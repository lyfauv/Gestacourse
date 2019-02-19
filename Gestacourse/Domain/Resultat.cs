using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Domain
{
    public class Resultat
    {
        public virtual int Id_participant
        {
            get;
            set;
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual int Classement
        {
            get;
            set;
        }

        public virtual double VitMoy
        {
            get;
            set;
        }

        public virtual double AllureMoy
        {
            get;
            set;
        }

        public virtual DateTime Temps // Mettre en date time je pense
            //En minutes
        {
            get;
            set;
        }

        public virtual Course Course
        {
            get;
            set;
        }

        public virtual Participant Coureur
        {
            get;
            set;
        }

        public Resultat()
        {

        }

        public Resultat(Participant coureur)
        {
            Coureur = coureur;
        }

        public Resultat(Participant coureur, DateTime temps) : this(coureur)
        {
            Temps = temps;
        }

        public Resultat(Participant coureur, Course course,DateTime temps) : this(coureur,temps)
        {
            Course = course;
            Course.ListeResultat.Add(this);
            VitMoy = Course.Distance / (Temps.Ticks / 60);// km/h
            AllureMoy = Temps.Ticks / Course.Distance;//min/km
        }

        public override string ToString()
        {
            return "Participant : " + Coureur.Nom + " - Course : " + Course.Distance;

        }

    }
}

