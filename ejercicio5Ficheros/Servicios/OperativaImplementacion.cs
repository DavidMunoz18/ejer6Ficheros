using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Ficheros.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void lineaEspecifica(string rutaFichero)
        {
            Console.WriteLine("Introduzca la linea que quieres modificar");
            int numLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el texto");
            string texto = Console.ReadLine();

            try
            {
                string[] leerTexto = File.ReadAllLines(rutaFichero);

                if(numLinea >= 0 && numLinea <= leerTexto.Length)
                {
                    leerTexto[numLinea - 1] = texto;

                    File.WriteAllLines(rutaFichero, leerTexto);
                }
                else
                {
                    Console.WriteLine("La linea introducida no se encuentra dentro del rango");
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Se ha producido un error al leer/modificar el fichero: " + ex.Message);
            }
        }

        public void posicionEspecifica(string rutaFichero)
        {
            Console.WriteLine("Introduzca la posicion en la que desea introducir el texto");
            int posicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el texto");
            string texto = Console.ReadLine();

            try
            {
                string leerTexto = File.ReadAllText(rutaFichero);
                if(posicion >= 0 && posicion <= leerTexto.Length)
                {
                    string nuevoC = leerTexto.Insert(posicion, texto);

                    File.WriteAllText(rutaFichero, nuevoC);

                    Console.WriteLine("El texto se ha escrito correctamente en la posición especificada.");
                }
                else
                {
                    Console.WriteLine("La posicion introducida se sobrepasa");
                }


            }catch(Exception ex)
            {
                Console.WriteLine("Se ha producido un error al escribir/leer el fichero" + ex.Message); 
            }
        }
    }
}
