using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_articulos

{
    internal class Articulo

    {


        public class Articulos
        {
            protected string[] codigo = new string[5];
            protected string[] nombre = new string[5];
            protected double[] precio = new double[5];
            protected int contador = 0;

            public void AgregarArticulos(string cod, string nom, double pre)
            {
                if (contador < 5)
                {
                    codigo[contador] = cod;
                    nombre[contador] = nom;
                    precio[contador] = pre;
                    contador++;
                }
                else
                {
                    Console.WriteLine("No se pueden ingresar más de 5 artículos");
                }
            }

            public void BorrarArticulo(string cod)
            {
                bool encontrado = false;
                for (int i = 0; i < contador; i++)
                {
                    if (codigo[i] == cod)
                    {
                        encontrado = true;
                        for (int j = i; j < contador - 1; j++)
                        {
                            codigo[j] = codigo[j + 1];
                            nombre[j] = nombre[j + 1];
                            precio[j] = precio[j + 1];
                        }
                        contador--;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Artículo no encontrado");
                }
            }

            public void ConsultarArticulo(string cod)
            {
                bool encontrado = false;
                for (int i = 0; i < contador; i++)
                {
                    if (codigo[i] == cod)
                    {
                        encontrado = true;
                        Console.WriteLine("Código: " + codigo[i]);
                        Console.WriteLine("Nombre: " + nombre[i]);
                        Console.WriteLine("Precio: " + precio[i]);
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Artículo no encontrado");
                }
            }
        }

    }
    public class Articulos

        {
            protected string[] codigos;
            protected string[] nombres;
            protected double[] precios;
            protected int cantidadArticulos;

        public Articulos()
        {
            codigos = new string[5];
            nombres = new string[5];
            precios = new double[5];
            cantidadArticulos = 0;
        }

        public Articulos(string[] codigos, string[] nombres, double[] precios)
        {
            if (codigos.Length > 5 || nombres.Length > 5 || precios.Length > 5)
            {
            throw new ArgumentException("No se pueden ingresar más de 5 artículos");
            }

            this.codigos = codigos;
            this.nombres = nombres;
            this.precios = precios;
            this.cantidadArticulos = codigos.Length;
        }

        public string[] Codigos
        {
            get { return codigos; }
            set { codigos = value; }
        }

        public string[] Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public double[] Precios
        {
            get { return precios; }
            set { precios = value; }
        }

        public void AgregarArticulo(string codigo, string nombre, double precio)
        {
            if (cantidadArticulos >= 5)
            {
                throw new InvalidOperationException("No se pueden agregar más de 5 artículos");
            }

            codigos[cantidadArticulos] = codigo;
            nombres[cantidadArticulos] = nombre;
            precios[cantidadArticulos] = precio;
            cantidadArticulos++;
        }

        public void BorrarArticulo(string codigo)
        {
            int indice = Array.IndexOf(codigos, codigo);
            if (indice == -1)
            {
                throw new ArgumentException($"El artículo con código {codigo} no existe");
            }

            for (int i = indice; i < cantidadArticulos - 1; i++)
            {
                codigos[i] = codigos[i + 1];
                nombres[i] = nombres[i + 1];
                precios[i] = precios[i + 1];
            }

            cantidadArticulos--;
            }

        public string ConsultarArticulo(string codigo)
        {
            int indice = Array.IndexOf(codigos, codigo);
            if (indice == -1)
            {
                throw new ArgumentException($"El artículo con código {codigo} no existe");
            }

            return $"{codigos[indice]} - {nombres[indice]}: ${precios[indice]}";
        }

    }

}
