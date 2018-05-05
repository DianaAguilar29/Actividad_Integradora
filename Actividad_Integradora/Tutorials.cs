using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora
{
    public class Tutorials
    {
        String name;
        String lastName;
        String startDate;
        String endDate;
        int hours;

        public Tutorials(String name, String lastName, String startDate, String endDate, int hours)
        {
            this.name = name;
            this.lastName = lastName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hours = hours;
        }
    }
}
