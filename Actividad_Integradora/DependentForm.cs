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
    public partial class DependentForm : Form
    {
        List<Dependent> dependentList;
        int index = -1;

        public DependentForm(List<Dependent> dependentList)
        {
            this.dependentList = dependentList;
            InitializeComponent();
            fillDependentList();
        }

        private void fillDependentList()
        {
            dependentListView.Items.Clear();
            foreach (Dependent dependent in dependentList)
            {
                int age = DateTime.Today.AddTicks(-dependent.getBirthdate().Ticks).Year - 1;
                String[] dataArray = dependent.toStringTabla();
                dataArray[2] = age.ToString();
                ListViewItem item = new ListViewItem(dataArray);
                dependentListView.Items.Add(item);
            }
        }

        private void addRelationshipButton_Click(object sender, EventArgs e)
        {
            AddDependentForm addDependentWindow = new AddDependentForm(dependentList, true);
            addDependentWindow.ShowDialog();
            fillDependentList();
            index = -1;
            EnableButtons();
        }

        private void editRelationshipButton_Click(object sender, EventArgs e)
        {
            Dependent newDependent = dependentList[index];
            AddDependentForm addDependentWindow = new AddDependentForm(newDependent, index, false);
            addDependentWindow.ShowDialog();
            fillDependentList();
            index = -1;
            EnableButtons();
        }

        private void dependentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dependentListView.FocusedItem.Selected)
            {
                index = dependentListView.FocusedItem.Index;
            }
            else
            {
                index = -1;
            }

            EnableButtons();
        }

        private void EnableButtons()
        {
            if (index == -1)
            {
                editRelationshipButton.Enabled = false;
                deleteRelationshipButton.Enabled = false;
            }
            else
            {
                editRelationshipButton.Enabled = true;
                deleteRelationshipButton.Enabled = true;
            }
        }

        private void deleteRelationshipButton_Click(object sender, EventArgs e)
        {
            dependentList.RemoveAt(index);
            fillDependentList();
            index = -1;
            EnableButtons();
        }
    }
   
}
