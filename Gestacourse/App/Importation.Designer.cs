namespace App
{
    partial class Importation
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
            this.TextCSV = new System.Windows.Forms.Label();
            this.CheminFichier = new System.Windows.Forms.TextBox();
            this.ImportationReussie = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Importer = new System.Windows.Forms.Button();
            this.GestionnaireFichier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextCSV
            // 
            this.TextCSV.AutoSize = true;
            this.TextCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextCSV.Location = new System.Drawing.Point(41, 56);
            this.TextCSV.Name = "TextCSV";
            this.TextCSV.Size = new System.Drawing.Size(325, 17);
            this.TextCSV.TabIndex = 0;
            this.TextCSV.Text = "Veuillez saisir l\'emplacement de votre fichier CSV :";
            // 
            // CheminFichier
            // 
            this.CheminFichier.Location = new System.Drawing.Point(242, 96);
            this.CheminFichier.Name = "CheminFichier";
            this.CheminFichier.Size = new System.Drawing.Size(357, 20);
            this.CheminFichier.TabIndex = 1;
            // 
            // ImportationReussie
            // 
            this.ImportationReussie.AutoSize = true;
            this.ImportationReussie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ImportationReussie.Location = new System.Drawing.Point(246, 279);
            this.ImportationReussie.Name = "ImportationReussie";
            this.ImportationReussie.Size = new System.Drawing.Size(140, 17);
            this.ImportationReussie.TabIndex = 2;
            this.ImportationReussie.Text = "Importation Réussie !";
            this.ImportationReussie.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(200, 398);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(234, 31);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Retourner sur Gestacourse";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Importer
            // 
            this.Importer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Importer.Location = new System.Drawing.Point(200, 161);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(234, 31);
            this.Importer.TabIndex = 4;
            this.Importer.Text = "Démarrer l\'importation";
            this.Importer.UseVisualStyleBackColor = true;
            this.Importer.Click += new System.EventHandler(this.Importer_Click);
            // 
            // GestionnaireFichier
            // 
            this.GestionnaireFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GestionnaireFichier.Location = new System.Drawing.Point(54, 90);
            this.GestionnaireFichier.Name = "GestionnaireFichier";
            this.GestionnaireFichier.Size = new System.Drawing.Size(172, 31);
            this.GestionnaireFichier.TabIndex = 5;
            this.GestionnaireFichier.Text = "Importer un fichier...";
            this.GestionnaireFichier.UseVisualStyleBackColor = true;
            this.GestionnaireFichier.Click += new System.EventHandler(this.GestionnaireFichier_Click);
            // 
            // Importation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 560);
            this.Controls.Add(this.GestionnaireFichier);
            this.Controls.Add(this.Importer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ImportationReussie);
            this.Controls.Add(this.CheminFichier);
            this.Controls.Add(this.TextCSV);
            this.Name = "Importation";
            this.Text = "Importation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextCSV;
        private System.Windows.Forms.TextBox CheminFichier;
        private System.Windows.Forms.Label ImportationReussie;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Importer;
        private System.Windows.Forms.Button GestionnaireFichier;
    }
}