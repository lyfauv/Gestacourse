using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Participant
    {
        public virtual int Id
        {
            get;
            set;
        }
        public virtual string Nom
        {
            get;
            set;
        }

        public virtual string Prenom
        {
            get;
            set;
        }

        public virtual int NbDossard
        {
            get;
            set;
        }

        public virtual int Age
            //Modifier pour calculer en live pour avoir constamment le bon age
        {
            get { return CalculAge(); }
            set { }
        }

        public virtual string Sexe
        {
            get;
            set;
        }
        public virtual DateTime DateNaissance
        {
            get;
            set;
        }
        public virtual string Courriel
        {
            get;
            set;
        }

        public virtual string NumLicenceFFA
        {
            get;
            set;
        }
        

        public Participant():this("","","",new DateTime(01/01/2000), "F")
        {
        }

        public Participant(string nom, string prenom, string courriel, DateTime dnaissance, string sexe) 
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            DateNaissance = dnaissance;
            Sexe = sexe;
        }
        public Participant(string nom, string prenom, string courriel, DateTime dnaissance, string ffa, string sexe): this(nom,prenom,courriel,dnaissance,sexe)
        {
            NumLicenceFFA = ffa;
        }

        /// <summary>
        /// Calcule l'âge à partir de la date de naissance
        /// </summary>
        /// <returns></returns>
        public virtual int CalculAge()
        {
            int age;
            DateTime dateActuelle = DateTime.Today;
            age = dateActuelle.Year - DateNaissance.Year;

            return age;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}

