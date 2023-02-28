using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_articulos
{
    internal class Interfase
    {
        interface IVendedor1
        {
            void VentasContado();
        }

        interface IVendedor2
        {
            string VentasCredito();
        }

        class Interfaces : IVendedor1, IVendedor2
        {
            public void VentasContado()
            {
                // código para el método VentasContado de IVendedor1
            }

            public string VentasCredito()
            {
                // código para el método VentasCredito de IVendedor2
                return "";
            }
        }


    }
}
