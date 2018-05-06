using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora
{
    public partial class PrincipalMenuForm : Form
    {
        Profesor professor;


        public PrincipalMenuForm(Profesor professor)
        {
            this.professor = professor;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfessorProfile professorProfile = new ProfessorProfile(professor);
            professorProfile.ShowDialog();
        }
    }
}
