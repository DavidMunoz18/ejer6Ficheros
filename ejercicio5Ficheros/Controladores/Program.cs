using ejercicio5Ficheros.Servicios;

namespace ejercicio5Ficheros.Controladores
{
    class program
    {
        public static void Main(String[] args)
        {
            

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            

            bool cerrarMenu = false;

            int opcion;

            while(!cerrarMenu)
            {
                string rutaFichero = "C:\\Users\\csi23-dmunnco\\Desktop\\ficheros\\fichero" + mi.mostrarMenuPrincipal() + ".txt";

                opcion = mi.editarLineaOPosicion();

                switch(opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.lineaEspecifica(rutaFichero);
                        break;
                    case 2:
                        oi.posicionEspecifica(rutaFichero);
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
