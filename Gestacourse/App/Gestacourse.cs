using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Domain;
using DAL;

namespace App
{
    public partial class Gestacourse : Form
    {
        Course course { get; set; }
        CourseRepository Cr { get; set; }
        ResultatRepository Rr { get; set; } 
        ParticipantRepository Pr { get; set; }
        List<Course> ListeCourses { get; set; }

        public Gestacourse()
        {
            InitializeComponent();
            Cr = new CourseRepository();
            Rr = new ResultatRepository();
            Pr = new ParticipantRepository();
            ListeCourses = new List<Course>();
            Initialisation();
            
        }

        public void ActiverBoutonsResultats()
        {
            TriCoureur.Enabled = true;
            resCourse.Enabled = true;

        }
        /// <summary>
        /// Initialise les valeurs des composants à l'ouverture de l'application 
        /// </summary>
        public void Initialisation()
        {
            //On va chercher toutes les courses dans la bdd
            ListeCourses = Cr.GetAll();
            foreach (Resultat r in Rr.GetAll())
            {
                if (r.Course == course)
                    course.ListeResultat.Add(r);
            }
            //On remplit le menu déroulant
            foreach (Course cours in ListeCourses)
            {
                SelectionCourse.Items.Add("Course " + cours.Id);
            }
            //On permet d'importer des participants dans une course si on a une course de disponible
            if (SelectionCourse.Items.Count != 0)
            {
                SelectionCourse.SelectedIndex = 0;
                ChargerCourse(0);
                ImporterParticipant.Enabled = true;
                afficherParticipants.Enabled = true;
            }
            
        }

        public void ChargerCourse(int id)
        {
            course = ListeCourses[id];
            RemplissageGrilleCoureurs();
        }

        /// <summary>
        /// Remplit les lignes du DataGrid qui permet d'afficher les informations relatives aux participants
        /// </summary>
        public void RemplissageGrilleCoureurs()
        {
            Participants.Rows.Clear();

            Participants.Visible = true;
            ResultatCourse.Visible = false;

            // Remplissage du DataGrid
            foreach (Participant p in course.ListeParticipants)
            {
                string[] ligne = { p.NbDossard.ToString(), p.Nom, p.Prenom, p.Age.ToString(), p.Sexe, p.Courriel, p.NumLicenceFFA };
                Participants.Rows.Add(ligne);
            }
        }

        public void RemplissageClassement()
        {
            ResultatCourse.Visible = true;
            Participants.Visible = false;

            // Remplissage du DataGrid
            foreach (Resultat res in course.ListeResultat)
            {
                string[] ligne = { res.Classement.ToString(), res.Coureur.NbDossard.ToString(), res.Coureur.Nom, res.Coureur.Prenom, res.VitMoy.ToString(), res.AllureMoy.ToString() };
                ResultatCourse.Rows.Add(ligne);
            }
        }

        /// <summary>
        /// Redirection vers le formulaire d'importation pour des résultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImporterRes_Click(object sender, EventArgs e)
        {
            Form formulaire = new Importation(1,course,ImporterRes);
            if(ImporterRes.Enabled == true)
            {
                ActiverBoutonsResultats();
            }
            formulaire.ShowDialog();
        }

        /// <summary>
        /// Redirection vers le formulaire d'importation pour des participants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImporterParticipant_Click(object sender, EventArgs e)
        {
            Form formulaire = new Importation(2,course,ImporterRes);
            formulaire.ShowDialog();
            RemplissageGrilleCoureurs();
        }

        /// <summary>
        /// Tri les coureurs via leur classement par ordre croissant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriCoureur_Click(object sender, EventArgs e)
        {
            course.ClasserResultats();

            if(Participants.Visible == true)
                RemplissageGrilleCoureurs();
        }
        

        /// <summary>
        /// Affiche la grille des résultats de la course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resCourse_Click(object sender, EventArgs e)
        {
            RemplissageClassement();
        }

        /// <summary>
        /// Affiche la grille des résultats de la course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherParticipants_Click_1(object sender, EventArgs e)
        {
            RemplissageGrilleCoureurs();
        }

        /// <summary>
        /// Recherche par nom ou numéro de dossard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Imgloupe_Click(object sender, EventArgs e)
        {
            GroupeResRecherche.Visible = true;
            InfoRecherche.Visible = true;
            bool dossard = false;
            Participant resultatCherche = new Participant();

            if (Recherche.Text == "")
                InfoRecherche.Text = "Veuillez entrer un nom ou un numéro de dossard dans la barre de recherche";
            else
            {
                try
                {
                    Convert.ToInt32(Recherche.Text);
                    dossard = true;
                }
                catch (System.FormatException)
                {
                    dossard = false;
                }

                foreach (Participant res in course.ListeParticipants)
                {
                    if (dossard)
                    {
                        if (res.NbDossard == Convert.ToInt32(Recherche.Text))
                            resultatCherche = res;
                    }
                    else
                    {
                        if (res.Nom == Recherche.Text)
                            resultatCherche = res;
                    }
                }

                try
                {
                    // Affichage des informations
                    InfoRecherche.Text = "Numéro de Dossard : " + resultatCherche.NbDossard + "\nNom : " + resultatCherche.Nom + " Prénom : " + resultatCherche.Prenom
                        + "\nSexe : " + resultatCherche.Sexe
                    + "Age : " + resultatCherche.Age + "\nCourriel : " + resultatCherche.Courriel + "\nNuméro de Licence : " + resultatCherche.NumLicenceFFA;
                }
                catch (Exception)
                {
                    InfoRecherche.Text = "Aucun résultat ne correspond à votre recherche :'(";
                }

            }
        }

        public void ChangementCourse(int index)
        {
            // nomCourse = SelectionCourse.Text;
            ChargerCourse(SelectionCourse.SelectedIndex);
            RemplissageGrilleCoureurs();
        }

        /// <summary>
        /// Change de course lorsqu'on clique sur une nouvelle course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerCourse(SelectionCourse.SelectedIndex);
            RemplissageGrilleCoureurs();
        }

        /// <summary>
        /// Créer une nouvelle course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreerCourse_Click(object sender, EventArgs e)
        {
            Form nouvelleCourse = new NouvelleCourse(SelectionCourse,ListeCourses);

            if(nouvelleCourse.ShowDialog() == DialogResult.OK)
            {
                ImporterParticipant.Enabled = true;
            }

        }

        private void Gestacourse_Load(object sender, EventArgs e)
        {

        }
    }
}
