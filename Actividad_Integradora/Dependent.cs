using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora
{
    public class Dependent
    {
        String name;
        String lastName;
        //int age;
        DateTime birthdate;
        String relationship;


        public Dependent(String name, String lastName, DateTime birthdate, String relationship)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.relationship = relationship;
        }

        public String getName()
        {
            return name;
        }

        public String getLastName()
        {
            return lastName;
        }

        public DateTime getBirthdate()
        {
            return birthdate;
        }

        public String getRelationship()
        {
            return relationship;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        public void setRelationship(String relationship)
        {
            this.relationship = relationship;
        }

        public string[] toStringTabla()
        {
            string[] cad = new string[4];
            cad[0] = name;
            cad[1] = lastName;
            cad[2] = birthdate.ToString();
            cad[3] = relationship;

            return cad;
        }
    }


}
