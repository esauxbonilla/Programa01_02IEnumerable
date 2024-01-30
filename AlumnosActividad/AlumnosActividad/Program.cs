using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosActividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos el Salón
            CSalon salon = new CSalon();

            //Recorremos cada uno de los elementos  de la 
            // estructura que expone

            foreach(CAlumno elAlumno in salon)
            {
                elAlumno.CalculaPromedio();
                elAlumno.MuestraInformacion();
            }
        }
    }
}
