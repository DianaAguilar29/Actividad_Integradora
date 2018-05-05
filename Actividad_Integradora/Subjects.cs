using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora
{
  public class Subjects
    {
        String name;
        String startDate;
        String endDate;
        //programa educativo
        int hours;

        public Subjects(String name, String startDate, String endDate, int hours)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hours = hours;
        }
    }
}
