using System;
using System.Collections.Generic;

class Vendedores
{
    private Dictionary<string, string> vendedores;

    public Vendedores()
    {
        vendedores = new Dictionary<string, string>();
        vendedores.Add("V001", "Vendedor1");
        vendedores.Add("V002", "Vendedor2");
    }

    public Dictionary<string, string> ListadoVendedores()
    {
        return vendedores;
    }

    public string BuscarVendedor(string codigoVendedor)
    {
        if (vendedores.ContainsKey(codigoVendedor))
        {
            return vendedores[codigoVendedor];
        }
        else
        {
            return "No existe un vendedor con el código ingresado";
        }
    }
}

interface IVendedor1
{
    string NombreVendedor { get; set; }
}

interface IVendedor2
{
    string NombreVendedor { get; set; }
}

class Vendedor1 : IVendedor1
{
    public string NombreVendedor { get; set; }

    public Vendedor1(string nombreVendedor)
    {
        NombreVendedor = nombreVendedor;
    }
}

class Vendedor2 : IVendedor2
{
    public string NombreVendedor { get; set; }

    public Vendedor2(string nombreVendedor)
    {
        NombreVendedor = nombreVendedor;
    }
}
