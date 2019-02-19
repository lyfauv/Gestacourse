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
using CsvHelper;
using Domain;
using App.CSV;
using DAL;

namespace App
{
    public partial class Importation : Form
    {
        Course course { get; set; }
        int choix;
        ParticipantRepository Pr { get; set; }
        private CourseRepository cr;
        ResultatRepository Rr { get; set; }

        OpenFileDialog Ofd { get; set; }
        static int compteur = 0;
        Button BoutonAModifier { get; set; }
        public Importation(int mode, Course laCourse, Button bouton)
        {
            InitializeComponent();
            choix = mode;
            course = laCourse;
            Pr = new ParticipantRepository();
            Rr = new ResultatRepository();
            cr = new CourseRepository();
            BoutonAModifier = bouton;
            Ofd= new OpenFileDialog();
        }
        private void GestionnaireFichier_Click(object sender, EventArgs e)
        {
            Ofd.Filter = "CSV|*.csv";
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                CheminFichier.Text = Ofd.FileName;
            }

        }
        /// <summary>
        /// Lis un fichier CSV et retourne son contenu sous forme de liste suivant le séparateur choisi
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chemin"></param>
        /// <returns></returns>
        public void lireCSV(string chemin, int choix)
        {
            ImportationReussie.Visible = true;

            using (var tr = new StreamReader(chemin))
            {
                
                var csv = new CsvReader(tr);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.HasHeaderRecord = true;

                if (choix == 1) //On veut importer des résultats
                {
                    try
                    {
                        csv.Configuration.RegisterClassMap<CSVResultats>();
                        var resultat = csv.GetRecords<Resultat>().ToList();

                        // Mise à jour des résultats
                        foreach (Resultat res in resultat)
                        {
                            course.ListeResultat.Add(res);
                        }
                        course.ClasserResultats();

                        //Enregistrement des résultats dans la bdd
                        
                        foreach (Resultat res in resultat)
                        {
                            Rr.Save(res);
                        }
                        ImportationReussie.Text = "Importation Réussie !";
                        BoutonAModifier.Enabled = true;
                    }
                    catch (Exception e)
                    {
                        ImportationReussie.Text = "Problème d'importation, réessayer";
                    }
                }

                if (choix == 2) //On veut importer des participants
                {
                    try
                    {
                        csv.Configuration.RegisterClassMap<CSVParticipant>();
                        var resultat = csv.GetRecords<Participant>().ToList();

                        // Mise à jour des participants
                        foreach (Participant participe in resultat)
                        {
                            participe.NbDossard += compteur;
                            course.ListeParticipants.Add(participe);
                            compteur++;
                        }
                        ImportationReussie.Text = "Importation Réussie !";
                        BoutonAModifier.Enabled = true;

                        // Save Course
                        cr.Save(course);
                    }
                    catch (Exception e)
                    {
                        ImportationReussie.Text = "Problème d'importation, réessayer";
                    }

                }



            }
        }
        
        /// <summary>
        /// Au clic sur démarrer l'importation, va chercher le fichier CSV à l'emplacement donné dans le text field et le convertit en une liste de participants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Importer_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> listeCaracteristiques = new List<string>();
            string fichier = CheminFichier.Text;

            if (fichier == "")
            {
                ImportationReussie.Visible = true;
                ImportationReussie.Text = "Veuillez entrer un chemin pour votre fichier";
            }
            else
                lireCSV(fichier, choix);

            //faire exception chemin invalide / fichier non trouvé 

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
