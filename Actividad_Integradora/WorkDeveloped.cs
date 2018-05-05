using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora
{
    public class WorkDeveloped
    {
        String title;
        String date;
        String authors;
        String institution;
        int registryNumber;

        public WorkDeveloped ( String title, String date, String authors, String institution, int registryNumber)
        {
            this.title = title;
            this.date = date;
            this.authors = authors;
            this.institution = institution;
            this.registryNumber = registryNumber;
        }
    }
}
