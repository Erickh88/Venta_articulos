using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_articulos
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Mostrar();
            SubmenuArticulos();
            AgregarArticulo();
            BorrarArticulo();
            ConsultarArticulo();
            Facturacion();
            Reporte();
            
            
        }
        public static void Mostrar()
        {
            bool salir = false;
            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("a - Artículos");
                Console.WriteLine("b - Facturación");
                Console.WriteLine("c - Reporte");
                Console.WriteLine("d - Salir");

                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        SubmenuArticulos();
                        break;
                    case "b":
                        Facturacion();
                        break;
                    case "c":
                        Reporte();
                        break;
                    case "d":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (!salir);
        }

        private static void SubmenuArticulos()
        {
            bool salir = false;
            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("a - Agregar");
                Console.WriteLine("b - Borrar");
                Console.WriteLine("c - Consultar");
                Console.WriteLine("d - Volver");

                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        AgregarArticulo();
                        break;
                    case "b":
                        BorrarArticulo();
                        break;
                    case "c":
                        ConsultarArticulo();
                        break;
                    case "d":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (!salir);
        }

        public static void AgregarArticulo()
        {
            Articulos articulos = new Articulos();
            {
               // articulos.AgregarArticulo("", "", "");
                //esta comentado porque no entendemos el error 

            }
        }


        private static void BorrarArticulo()
        {

            Articulos articulos = new Articulos();
            {
                articulos.BorrarArticulo("");
            }                
            
            
        }

        private static void ConsultarArticulo()
        {
            Articulos articulos = new Articulos();
            {
                articulos.ConsultarArticulo("");

            }
           
            
        }

        private static void Facturacion()
        {
            Console.WriteLine("Ingrese el código del artículo a facturar:");
            string codigoArticulo = Console.ReadLine();
           
        }

        private static void Reporte()
        {
            // código para el reporte
        }
    }
}

