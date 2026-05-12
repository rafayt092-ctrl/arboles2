using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES
{
    public class Nodo
    {
        public int Dato;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(int dato)
        {
            Dato = dato;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
