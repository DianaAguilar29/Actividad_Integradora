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
    public partial class ChangePasswordForm : Form
    {
        Profesor professor; 

        public ChangePasswordForm(Profesor professor)
        {
            InitializeComponent();
            this.professor = professor;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(currentPassTextBox.Text == professor.getPassword())
            {
                if(newPassTextBox.Text == confirmTextBox.Text)
                {
                    professor.setPassword(newPassTextBox.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("The password do not match");
                }
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}
