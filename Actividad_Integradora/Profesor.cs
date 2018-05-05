using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora
{
    public class Profesor
    {
        String name;
        String lastName;
        String street;
        String number;
        String colony;
        String city;
        String address;
        String phoneNumber;
        String email;
        String userName;
        String password;
        byte[] picture;
        List<Dependent> dependentList;
        List<AcademicTraining> academicList;
        List<WorkDeveloped> workList;
        List<Subjects> subjectList;
        List<Tutorials> tutorialList;
        public Profesor(String name, String lastName, String street, String number, String colony, String city, String phoneNumber, String email, byte[] picture, String userName, String password)
        {
            this.name = name;
            this.lastName = lastName;
            this.street = street;
            this.number = number;
            this.colony = colony;
            address = street + " " + number + " " + colony;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.picture = picture;
            this.userName = userName;
            this.password = password;

            //Lists
            dependentList = new List<Dependent>();
            academicList = new List<AcademicTraining>();
            workList = new List<WorkDeveloped>();
            subjectList = new List<Subjects>();
            tutorialList = new List<Tutorials>();

        }

        //Validaciones
        public static bool OnlyNumbers(KeyPressEventArgs pE)
        {
            bool correct = true;
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
                correct = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
            return correct;
        }

        public static bool OnlyLetters(KeyPressEventArgs pE)
        {
            bool correct = true;
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
                correct = false;

            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else
            {
                pE.Handled = true;
            }
            return correct;
        }


        public String getName()
        {
            return name;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getStreet()
        {
            return street;
        }

        public String getNumber()
        {
            return number;
        }

        public String getColony()
        {
            return colony;
        }

        public String getCity()
        {
            return city;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public String getEmail()
        {
            return email;
        }


        public byte[] getpicture()
        {
            return picture;
        }

        public String getUserName()
        {
            return userName;
        }

        public String getPassword()
        {
            return password;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setNumber(String number)
        {
            this.number = number;
        }

        public void setColony(String colony)
        {
            this.colony = colony;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void setPicture(byte[] picture)
        {
            this.picture = picture;
        }
        public List<Dependent> getDependentList()
        {
            return dependentList;
        }

        public List<AcademicTraining> getAcademicList()
        {
            return academicList;
        }

        public List<WorkDeveloped> getWorkDevelopedList()
        {
            return workList;
        }
        
        public List<Subjects> getSubjectList()
        {
            return subjectList;
        }

        public List<Tutorials> getTutorialList()
        {
            return tutorialList;
        }
    }
}
