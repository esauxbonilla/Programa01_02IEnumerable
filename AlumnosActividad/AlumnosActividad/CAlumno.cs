using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosActividad
{
    internal class CAlumno : IAlumnos
    {
        double cal;
        double cal1;
        double cal2;
        string nombre;
        double pro;

        //Constructor 
        public CAlumno(string pNombre, double pcal, double pcal1, double pcal2)
        {
            //Inicializamos los datos
            cal = pcal;
            cal1 = pcal1;
            cal2 = pcal2;
            nombre = pNombre;
        }

        //Metodos interfaz

        public void CalculaPromedio()
        {
            //Calculamos Promedio
            pro = (cal + cal1 + cal2) / 3;
        }

        public void MuestraInformacion()
        {
            //Mostramos la información necesaria
            Console.WriteLine("El alumno {0}", nombre);
            Console.WriteLine("Tiene un promedio de {0}", pro);
            Console.WriteLine("------------");
        }
    }
}
