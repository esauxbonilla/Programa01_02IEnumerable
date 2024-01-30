using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosActividad
{
    internal class CSalon : IEnumerable
    {
        private CAlumno[] PorCal;

        public CSalon()
        {
            PorCal = new CAlumno[5];

            PorCal[0] = new CAlumno("Esaú", 9.6, 8.3, 9.2);
            PorCal[1] = new CAlumno("Edgar", 9.8, 8.5, 6.4);
            PorCal[2] = new CAlumno("Pablo", 7.2, 4.5, 7.8);
            PorCal[3] = new CAlumno("Arturo", 8.4, 4.3, 2.1);
            PorCal[4] = new CAlumno("Gabriel", 6.7, 5.8, 9.8);
        }
        public IEnumerator GetEnumerator()
        {
            //Regresamos la estructura que nos interese que 
            // recorra el foreach, esta debe de implementar IEnumerator

            return PorCal.GetEnumerator();
        }
    }
}
