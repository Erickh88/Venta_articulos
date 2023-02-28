using System;
using System.Collections.Generic;

class Categoria
{
    public virtual void Promocion()
    {
        Console.WriteLine("Descuentos y promociones");
    }

    public static List<int> categorias = new List<int>() { 1, 2, 3 };

    public static void ListadoCategorias()
    {
        Console.WriteLine("Listado de categorías:");
        foreach (int categoria in categorias)
        {
            Console.WriteLine(categoria);
        }
    }

    public static bool CategoriaExiste(int categoria)
    {
        return categorias.Contains(categoria);
    }
}

class Categoria1 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Descuento de 15%");
    }
}

class Categoria2 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Promoción dos por 1");
    }
}

class Categoria3 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Todo a mitad de precio");
    }
}

