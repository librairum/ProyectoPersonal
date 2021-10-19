using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion
{
   
    public class Ventas
    {

        public Ventas() { 
        
        }

        public  string nombreCategoria {get;set;}
        public double monto { get; set; }

        public Ventas(string n, double m) {
            this.nombreCategoria = n;
            this.monto = m;
        }
        Ventas venta;
        public List<Ventas> listaVentas() {
            List<Ventas> lista = new List<Ventas>();
            venta = new Ventas("Dulces", 1500);
            lista.Add(venta);
            venta = new Ventas("Lacteos", 2700.30);
            lista.Add(venta);
            venta = new Ventas("Abarrotes", 400.20);
            lista.Add(venta);
            return lista;
        }
        public List<Ventas> listaVentas2016() {
            List<Ventas> lista = new List<Ventas>();
            venta = new Ventas("Dulces", 500);
            lista.Add(venta);
            venta = new Ventas("Lacteos", 700.30);
            lista.Add(venta);
            venta = new Ventas("Abarrotes", 2536.1);
            lista.Add(venta);
            return lista;
        }
    }
}
