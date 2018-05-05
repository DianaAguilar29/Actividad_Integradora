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
    public partial class AddDependentForm : Form
    {

        List<Dependent> dependentList;
        Dependent dependent;
        int index;
        bool isNew;
        public AddDependentForm(List<Dependent> dependentList, bool flag)
        {
            this.dependentList = dependentList;
            isNew = flag;
            InitializeComponent();
            relationshipComboBox.Text = relationshipComboBox.Items[0].ToString();
            birthdateTextBox.Text = monthCalendar.TodayDate.ToString("dd/MM/yyyy");
        }

        public AddDependentForm(Dependent dependent, int index, bool flag)
        {
            this.dependent = dependent;
            this.index = index;
            isNew = flag;
            InitializeComponent();
            relationshipComboBox.Text = dependent.getRelationship();
            nameTextBox.Text = dependent.getName();
            lastNameTextBox.Text = dependent.getLastName();
            birthdateTextBox.Text = dependent.getBirthdate().ToString();
            
            monthCalendar.SetDate(dependent.getBirthdate());

            addButton.Text = "Save";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar.SelectionStart.CompareTo(DateTime.Today) == 1)
            {
                monthCalendar.SetDate(DateTime.Today);
                MessageBox.Show("Date out of range");
            }
            else
            {
                String birthdate = monthCalendar.SelectionStart.ToString("dd/MM/yyyy");
                birthdateTextBox.Text = birthdate;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(isNew)
            {
                Dependent newDependent = new Dependent(nameTextBox.Text, lastNameTextBox.Text, monthCalendar.SelectionStart, relationshipComboBox.Text);
                dependentList.Add(newDependent);
            }
            else
            {
                dependent.setName(nameTextBox.Text);
                dependent.setLastName(lastNameTextBox.Text);
                dependent.setRelationship(relationshipComboBox.Text);
                dependent.setBirthdate(monthCalendar.SelectionStart);
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to cancel?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                addButton.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "" || nameTextBox.Text == "")
            {
                addButton.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
            }
        }
    }
}
