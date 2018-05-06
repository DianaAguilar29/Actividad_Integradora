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
    public partial class TutorialsForm : Form
    {
        Profesor professor;
        public TutorialsForm(Profesor professor)
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddTutorialForm addTutorialForm = new AddTutorialForm();
            addTutorialForm.ShowDialog();
        }
    }
}
