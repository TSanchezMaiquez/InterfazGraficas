using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    internal class Articulo
    {
        private static int codigoCompartido = 0;
        private int codigoArt=0;
        private String nombreArt;
        private String categoriaArt;
        private double precioArt;
        private int existenciasArt;

        public Articulo()
        {

        }
        public Articulo(String nombreArt, String categoriaArt, double precioArt, int existenciasArt)
        {
            codigoCompartido++;
            this.nombreArt = nombreArt;
            this.categoriaArt = categoriaArt;
            this.precioArt = precioArt;
            this.existenciasArt = existenciasArt;
            this.codigoArt = codigoCompartido;

        }

        public int CodigoCompartido
        {
            get { return codigoCompartido; }
        }

        public int CodigoArt {
            get { return codigoArt; }
        }

        public String NombreArt
        {
            get { return nombreArt; }
        }

        public double PrecioArt
        {
            get { return precioArt; }
        }
        public String CategoriaArt
        {
            get { return categoriaArt; }
        }
        public int ExistenciasArt
        {
            get { return existenciasArt; }
            set { existenciasArt = value; }
        }


        public override string ToString()
        {
            return "Código: " + CodigoArt + "\nNombre: " + NombreArt + "\nPrecio: " + PrecioArt+ "\nCategoria: "+CategoriaArt +"\nStock: "+ExistenciasArt;
        }

    }
}
