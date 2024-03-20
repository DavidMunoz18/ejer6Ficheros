using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Ficheros.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int editarLineaOPosicion()
        {
            int editar;
            Console.WriteLine("1. Introduzca la linea que desea editar");
            Console.WriteLine("2. Introduzca la posicion que desea editar");
            editar = Convert.ToInt32(Console.ReadLine());
            return editar;
        }

        public int mostrarMenuPrincipal()
        {
            int opcion;
            Console.WriteLine("################################");
            Console.WriteLine("¿Que archivo desea abrir?");
            Console.WriteLine("1. Fichero1");
            Console.WriteLine("2. Fichero2");
            Console.WriteLine("3. Fichero3");
            Console.WriteLine("################################");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
