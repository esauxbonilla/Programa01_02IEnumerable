﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    internal class CTiendaAutos : IEnumerable
    {
        private CAuto[] disponibles;

        public CTiendaAutos()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 175600.70);
            disponibles[2] = new CAuto("March", 168900.00);
            disponibles[3] = new CAuto("Spark", 160400.40);
        }

        public IEnumerator GetEnumerator() 
        { 
            /*Regresamos la estructura que nos interesa que 
             * recorra el foreach, esta debe implementar IEnumerator
             */
            return disponibles.GetEnumerator();
        }
    }
}
