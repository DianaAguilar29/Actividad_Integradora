using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Actividad_Integradora
{
    public partial class ProfessorProfile : Form
    {
        //variables Professor Class

        Profesor newProfesor;
        String name;
        String lastName;
        String street;
        String number;
        String colony;
        String city;
        String phoneNumber;
        String email;
        String userName;
        String password;
        byte[] picture;

        List<Dependent> dependentList;


        //variables aux
        String strFilePath = "";
        //Image DEFAULTIMAGE;


        public ProfessorProfile(Profesor newProfesor)
        {
            InitializeComponent();
            this.newProfesor = newProfesor;
            NameTextBox.Text = newProfesor.getName();
            lastNameTextBox.Text = newProfesor.getLastName();
            streetTextBox.Text = newProfesor.getStreet();
            numTextBox.Text = newProfesor.getNumber().ToString();
            colonyTextBox.Text = newProfesor.getColony();
            cityTextBox.Text = newProfesor.getCity();
            phoneTextBox.Text = newProfesor.getPhoneNumber().ToString();
            emailTextBox.Text = newProfesor.getEmail();
            
            profilePictureBox.Image = ConvertByteArrayToImage(newProfesor.getpicture());

            ToolTip.SetToolTip(NameTextBox, "Enter your Name");
            ToolTip.SetToolTip(lastNameTextBox, "Enter your Last Name");
            ToolTip.SetToolTip(streetTextBox, "Enter your Street");
            ToolTip.SetToolTip(numTextBox, "Enter your Street Number");
            ToolTip.SetToolTip(colonyTextBox, "Enter your Colony");
            ToolTip.SetToolTip(cityTextBox, "Enter your City");
            ToolTip.SetToolTip(phoneTextBox, "Enter your Phone Number ");
            ToolTip.SetToolTip(emailTextBox, "Enter your Email");
        }

        public byte[] ConvertImageToByteArray(Image image, string extension)
        {
            using (var memoryStream = new MemoryStream())
            {
                switch (extension)
                {
                    case ".jpeg":
                    case ".jpg":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".png":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".gif":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                return memoryStream.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }



        private void submitButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                letterErrorProvider.SetError(NameTextBox, "Enter Name");
                NameTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(NameTextBox, "");

            if (lastNameTextBox.Text == "")
            {
                letterErrorProvider.SetError(lastNameTextBox, "Enter Last Name");
                lastNameTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(lastNameTextBox, "");

            if (streetTextBox.Text == "")
            {
                letterErrorProvider.SetError(streetTextBox, "Enter Street");
                streetTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(streetTextBox, "");

            if (numTextBox.Text == "")
            {
                letterErrorProvider.SetError(numTextBox, "Enter Streer Number");
                numTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(numTextBox, "");

            if (colonyTextBox.Text == "")
            {
                letterErrorProvider.SetError(colonyTextBox, "Enter Colony");
                colonyTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(colonyTextBox, "");

            if (cityTextBox.Text == "")
            {
                letterErrorProvider.SetError(cityTextBox, "Enter City");
                cityTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(cityTextBox, "");

            if (phoneTextBox.Text == "")
            {
                letterErrorProvider.SetError(phoneTextBox, "Enter Phone Number");
                phoneTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(phoneTextBox, "");


            if (emailTextBox.Text == "")
            {
                letterErrorProvider.SetError(emailTextBox, "Enter Email");
                emailTextBox.Focus();
                return;
            }
            letterErrorProvider.SetError(emailTextBox, "");

            newProfesor.setName(NameTextBox.Text);
            newProfesor.setLastName(lastNameTextBox.Text);
            newProfesor.setStreet(streetTextBox.Text);
            newProfesor.setNumber(numTextBox.Text);
            newProfesor.setColony(colonyTextBox.Text);
            newProfesor.setCity(cityTextBox.Text);
            newProfesor.setPhoneNumber(phoneTextBox.Text);
            newProfesor.setEmail(cityTextBox.Text);


            newProfesor.setPicture(ConvertImageToByteArray(profilePictureBox.Image, ".png"));

            Close();

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFolder = new OpenFileDialog();
            openFolder.Filter = "Images(.jpg, .png)|*.png;*jpg";
            if(openFolder.ShowDialog() == DialogResult.OK)
            {
                strFilePath = openFolder.FileName;
                profilePictureBox.Image = new Bitmap(strFilePath);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            profilePictureBox.Image = Actividad_Integradora.Properties.Resources.default_profile;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Validaciones
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if( Profesor.OnlyLetters(e))
            {
                letterErrorProvider.SetError(NameTextBox, "Only Letters");
                return;
            }
           else
            {
                letterErrorProvider.Clear();
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Profesor.OnlyLetters(e))
            {
                letterErrorProvider.SetError(lastNameTextBox, "Only Letters");
                return;
            }
            else
            {
                letterErrorProvider.Clear();
            }
        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Profesor.OnlyNumbers(e))
            {
                letterErrorProvider.SetError(numTextBox, "Only Numbers");
                return;
            }
            else
            {
                letterErrorProvider.Clear();
            }
        }

        private void cityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Profesor.OnlyLetters(e))
            {
                letterErrorProvider.SetError(cityTextBox, "Only Letters");
                return;
            }
            else
            {
                letterErrorProvider.Clear();
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Profesor.OnlyNumbers(e))
            {
                letterErrorProvider.SetError(phoneTextBox, "Only Numbers");
                return;
            }
            else
            {
                letterErrorProvider.Clear();
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string characters = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(emailTextBox.Text, characters))
            {
                emailTextBox.ForeColor = Color.Black;
                emailErrorProvider.Clear();
            }
            else
            {
                emailTextBox.ForeColor = Color.Red;
                emailErrorProvider.SetError(emailTextBox,"Provide a valid Email Address");
                return;
            }
        }

        private void editDependentButton_Click(object sender, EventArgs e)
        {
            DependentForm dependentWindow = new DependentForm(newProfesor.getDependentList());
            dependentWindow.ShowDialog();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePass = new ChangePasswordForm(newProfesor);
            changePass.ShowDialog();
        }
    }
}
