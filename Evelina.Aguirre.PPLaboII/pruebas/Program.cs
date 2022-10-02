using System;
using System.Collections.Generic;
using Entidades;


namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aux =0;

            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                aux++;
                //TiendaElectronica.CarritoCliente = TiendaElectronica.Cliente + item.Value;
                if(aux ==5)
                {
                    break;
                }
            }
            
          //  Console.WriteLine(TiendaElectronica.Cliente.MostrarCompra());
        }
    }
}
