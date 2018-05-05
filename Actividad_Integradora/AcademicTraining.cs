using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora
{
    public class AcademicTraining
    {
        String name;
        String school;
        String startDate;
        String endDate;
        String dateObtained;
        String professionalCard;
        
        public AcademicTraining (String name, String school, String startDate, String endDate, String dateObtained, String professionalCard)
        {
            this.name = name;
            this.school = school;
            this.startDate = startDate;
            this.endDate = endDate;
            this.dateObtained = dateObtained;
            this.professionalCard = professionalCard;
        }
    }
}
