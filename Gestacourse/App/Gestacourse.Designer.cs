namespace App
{
    partial class Gestacourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestacourse));
            this.Participants = new System.Windows.Forms.DataGridView();
            this.NumDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.CreerCourse = new System.Windows.Forms.Button();
            this.SelectionCourse = new System.Windows.Forms.ComboBox();
            this.resCourse = new System.Windows.Forms.Button();
            this.afficherParticipants = new System.Windows.Forms.Button();
            this.TriCoureur = new System.Windows.Forms.Button();
            this.ImporterParticipant = new System.Windows.Forms.Button();
            this.ImporterRes = new System.Windows.Forms.Button();
            this.Imgloupe = new System.Windows.Forms.PictureBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.InfoRecherche = new System.Windows.Forms.Label();
            this.GroupeResRecherche = new System.Windows.Forms.GroupBox();
            this.ResultatCourse = new System.Windows.Forms.DataGridView();
            this.NDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCoureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomCoureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassementCoureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitesseMoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Participants)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imgloupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // Participants
            // 
            this.Participants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Participants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDossard,
            this.Nom,
            this.Prenom,
            this.Age,
            this.Sexe,
            this.Courriel,
            this.NumLicence});
            this.Participants.Location = new System.Drawing.Point(181, 247);
            this.Participants.Name = "Participants";
            this.Participants.Size = new System.Drawing.Size(479, 327);
            this.Participants.TabIndex = 0;
            this.Participants.Visible = false;
            // 
            // NumDossard
            // 
            this.NumDossard.HeaderText = "N°Dossard";
            this.NumDossard.Name = "NumDossard";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            // 
            // Courriel
            // 
            this.Courriel.HeaderText = "Courriel";
            this.Courriel.Name = "Courriel";
            // 
            // NumLicence
            // 
            this.NumLicence.HeaderText = "N°Licence";
            this.NumLicence.Name = "NumLicence";
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.CreerCourse);
            this.Menu.Controls.Add(this.SelectionCourse);
            this.Menu.Controls.Add(this.resCourse);
            this.Menu.Controls.Add(this.afficherParticipants);
            this.Menu.Controls.Add(this.TriCoureur);
            this.Menu.Controls.Add(this.ImporterParticipant);
            this.Menu.Controls.Add(this.ImporterRes);
            this.Menu.Location = new System.Drawing.Point(13, 13);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(160, 561);
            this.Menu.TabIndex = 1;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // CreerCourse
            // 
            this.CreerCourse.Location = new System.Drawing.Point(22, 154);
            this.CreerCourse.Name = "CreerCourse";
            this.CreerCourse.Size = new System.Drawing.Size(116, 39);
            this.CreerCourse.TabIndex = 7;
            this.CreerCourse.Text = "Créer une Course";
            this.CreerCourse.UseVisualStyleBackColor = true;
            this.CreerCourse.Click += new System.EventHandler(this.CreerCourse_Click);
            // 
            // SelectionCourse
            // 
            this.SelectionCourse.FormattingEnabled = true;
            this.SelectionCourse.Location = new System.Drawing.Point(22, 83);
            this.SelectionCourse.Name = "SelectionCourse";
            this.SelectionCourse.Size = new System.Drawing.Size(116, 21);
            this.SelectionCourse.TabIndex = 6;
            this.SelectionCourse.SelectedIndexChanged += new System.EventHandler(this.SelectionCourse_SelectedIndexChanged);
            // 
            // resCourse
            // 
            this.resCourse.Enabled = false;
            this.resCourse.Location = new System.Drawing.Point(22, 322);
            this.resCourse.Name = "resCourse";
            this.resCourse.Size = new System.Drawing.Size(116, 39);
            this.resCourse.TabIndex = 5;
            this.resCourse.Text = "Afficher les résultats de la course";
            this.resCourse.UseVisualStyleBackColor = true;
            this.resCourse.Click += new System.EventHandler(this.resCourse_Click);
            // 
            // afficherParticipants
            // 
            this.afficherParticipants.Enabled = false;
            this.afficherParticipants.Location = new System.Drawing.Point(22, 391);
            this.afficherParticipants.Name = "afficherParticipants";
            this.afficherParticipants.Size = new System.Drawing.Size(116, 39);
            this.afficherParticipants.TabIndex = 4;
            this.afficherParticipants.Text = "Afficher les Participants";
            this.afficherParticipants.UseVisualStyleBackColor = true;
            this.afficherParticipants.Click += new System.EventHandler(this.afficherParticipants_Click_1);
            // 
            // TriCoureur
            // 
            this.TriCoureur.Enabled = false;
            this.TriCoureur.Location = new System.Drawing.Point(22, 250);
            this.TriCoureur.Name = "TriCoureur";
            this.TriCoureur.Size = new System.Drawing.Size(116, 39);
            this.TriCoureur.TabIndex = 3;
            this.TriCoureur.Text = "Trier par classement";
            this.TriCoureur.UseVisualStyleBackColor = true;
            this.TriCoureur.Click += new System.EventHandler(this.TriCoureur_Click);
            // 
            // ImporterParticipant
            // 
            this.ImporterParticipant.Enabled = false;
            this.ImporterParticipant.Location = new System.Drawing.Point(22, 455);
            this.ImporterParticipant.Name = "ImporterParticipant";
            this.ImporterParticipant.Size = new System.Drawing.Size(116, 39);
            this.ImporterParticipant.TabIndex = 1;
            this.ImporterParticipant.Text = "Importer des Participants";
            this.ImporterParticipant.UseVisualStyleBackColor = true;
            this.ImporterParticipant.Click += new System.EventHandler(this.ImporterParticipant_Click);
            // 
            // ImporterRes
            // 
            this.ImporterRes.Enabled = false;
            this.ImporterRes.Location = new System.Drawing.Point(22, 516);
            this.ImporterRes.Name = "ImporterRes";
            this.ImporterRes.Size = new System.Drawing.Size(116, 39);
            this.ImporterRes.TabIndex = 0;
            this.ImporterRes.Text = "Importer des Résultats";
            this.ImporterRes.UseVisualStyleBackColor = true;
            this.ImporterRes.Click += new System.EventHandler(this.ImporterRes_Click);
            // 
            // Imgloupe
            // 
            this.Imgloupe.Image = ((System.Drawing.Image)(resources.GetObject("Imgloupe.Image")));
            this.Imgloupe.Location = new System.Drawing.Point(549, 10);
            this.Imgloupe.Margin = new System.Windows.Forms.Padding(2);
            this.Imgloupe.Name = "Imgloupe";
            this.Imgloupe.Size = new System.Drawing.Size(37, 41);
            this.Imgloupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgloupe.TabIndex = 2;
            this.Imgloupe.TabStop = false;
            this.Imgloupe.Click += new System.EventHandler(this.Imgloupe_Click);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(306, 20);
            this.Recherche.Margin = new System.Windows.Forms.Padding(2);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(240, 20);
            this.Recherche.TabIndex = 3;
            this.Recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoRecherche
            // 
            this.InfoRecherche.Location = new System.Drawing.Point(183, 72);
            this.InfoRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoRecherche.Name = "InfoRecherche";
            this.InfoRecherche.Size = new System.Drawing.Size(472, 167);
            this.InfoRecherche.TabIndex = 4;
            this.InfoRecherche.Text = "label1";
            this.InfoRecherche.Visible = false;
            // 
            // GroupeResRecherche
            // 
            this.GroupeResRecherche.Location = new System.Drawing.Point(178, 57);
            this.GroupeResRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.GroupeResRecherche.Name = "GroupeResRecherche";
            this.GroupeResRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.GroupeResRecherche.Size = new System.Drawing.Size(482, 184);
            this.GroupeResRecherche.TabIndex = 5;
            this.GroupeResRecherche.TabStop = false;
            this.GroupeResRecherche.Text = "Résultats de la recherche";
            this.GroupeResRecherche.Visible = false;
            // 
            // ResultatCourse
            // 
            this.ResultatCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NDossard,
            this.NomCoureur,
            this.PrenomCoureur,
            this.ClassementCoureur,
            this.VitesseMoy,
            this.AllureMoy});
            this.ResultatCourse.Location = new System.Drawing.Point(181, 350);
            this.ResultatCourse.Margin = new System.Windows.Forms.Padding(2);
            this.ResultatCourse.Name = "ResultatCourse";
            this.ResultatCourse.RowTemplate.Height = 24;
            this.ResultatCourse.Size = new System.Drawing.Size(479, 224);
            this.ResultatCourse.TabIndex = 6;
            this.ResultatCourse.Visible = false;
            // 
            // NDossard
            // 
            this.NDossard.HeaderText = "N°Dossard";
            this.NDossard.Name = "NDossard";
            // 
            // NomCoureur
            // 
            this.NomCoureur.HeaderText = "Nom";
            this.NomCoureur.Name = "NomCoureur";
            // 
            // PrenomCoureur
            // 
            this.PrenomCoureur.HeaderText = "Prénom";
            this.PrenomCoureur.Name = "PrenomCoureur";
            // 
            // ClassementCoureur
            // 
            this.ClassementCoureur.HeaderText = "Classement";
            this.ClassementCoureur.Name = "ClassementCoureur";
            // 
            // VitesseMoy
            // 
            this.VitesseMoy.HeaderText = "Vitesse Moyenne";
            this.VitesseMoy.Name = "VitesseMoy";
            // 
            // AllureMoy
            // 
            this.AllureMoy.HeaderText = "Allure Moyenne";
            this.AllureMoy.Name = "AllureMoy";
            // 
            // Gestacourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 586);
            this.Controls.Add(this.InfoRecherche);
            this.Controls.Add(this.ResultatCourse);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Imgloupe);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Participants);
            this.Controls.Add(this.GroupeResRecherche);
            this.Name = "Gestacourse";
            this.Text = "Gestacourse";
            this.Load += new System.EventHandler(this.Gestacourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Participants)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imgloupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Participants;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button ImporterParticipant;
        private System.Windows.Forms.Button ImporterRes;
        private System.Windows.Forms.Button TriCoureur;
        private System.Windows.Forms.PictureBox Imgloupe;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.Label InfoRecherche;
        private System.Windows.Forms.GroupBox GroupeResRecherche;
        private System.Windows.Forms.Button afficherParticipants;
        private System.Windows.Forms.Button resCourse;
        private System.Windows.Forms.DataGridView ResultatCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCoureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCoureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassementCoureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitesseMoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoy;
        private System.Windows.Forms.ComboBox SelectionCourse;
        private System.Windows.Forms.Button CreerCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLicence;
    }
}