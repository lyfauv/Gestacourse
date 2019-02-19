using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;
namespace App
{
    public partial class NouvelleCourse : Form
    {
        ComboBox Liste { get; set; }
        List<Course> ListeCourse { get; set; }
        public NouvelleCourse(ComboBox liste,List<Course> listecourse)
        {
            InitializeComponent();
            Liste = liste;
            ListeCourse = listecourse;
        }

        private void ValiderNouvelleCourse_Click(object sender, EventArgs e)
        {
            try
            {
                CourseRepository cr = new CourseRepository();
                int dist = Convert.ToInt32(Distance.Text);
                Course course = new Course(dist);
                cr.Save(course);
                Liste.Items.Add("Course " + course.Id);
                ListeCourse.Add(course);
                
                Close();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageErreur.Visible = true;
            }
        }

        private void RetourAccueil_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
