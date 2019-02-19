namespace App
{
    partial class NouvelleCourse
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
            this.Distance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValiderNouvelleCourse = new System.Windows.Forms.Button();
            this.RetourAccueil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(137, 51);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(133, 20);
            this.Distance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance : ";
            // 
            // ValiderNouvelleCourse
            // 
            this.ValiderNouvelleCourse.Location = new System.Drawing.Point(199, 114);
            this.ValiderNouvelleCourse.Name = "ValiderNouvelleCourse";
            this.ValiderNouvelleCourse.Size = new System.Drawing.Size(90, 33);
            this.ValiderNouvelleCourse.TabIndex = 2;
            this.ValiderNouvelleCourse.Text = "Valider";
            this.ValiderNouvelleCourse.UseVisualStyleBackColor = true;
            this.ValiderNouvelleCourse.Click += new System.EventHandler(this.ValiderNouvelleCourse_Click);
            // 
            // RetourAccueil
            // 
            this.RetourAccueil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RetourAccueil.Location = new System.Drawing.Point(15, 114);
            this.RetourAccueil.Name = "RetourAccueil";
            this.RetourAccueil.Size = new System.Drawing.Size(90, 33);
            this.RetourAccueil.TabIndex = 3;
            this.RetourAccueil.Text = "Retour";
            this.RetourAccueil.UseVisualStyleBackColor = true;
            this.RetourAccueil.Click += new System.EventHandler(this.RetourAccueil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Créer une nouvelle course";
            // 
            // MessageErreur
            // 
            this.MessageErreur.AutoSize = true;
            this.MessageErreur.Location = new System.Drawing.Point(67, 87);
            this.MessageErreur.Name = "MessageErreur";
            this.MessageErreur.Size = new System.Drawing.Size(163, 13);
            this.MessageErreur.TabIndex = 5;
            this.MessageErreur.Text = "Erreur : Veuillez entrer un nombre";
            this.MessageErreur.Visible = false;
            // 
            // NouvelleCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 159);
            this.Controls.Add(this.MessageErreur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetourAccueil);
            this.Controls.Add(this.ValiderNouvelleCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Distance);
            this.Name = "NouvelleCourse";
            this.Text = "Nouvelle Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ValiderNouvelleCourse;
        private System.Windows.Forms.Button RetourAccueil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MessageErreur;
    }
}