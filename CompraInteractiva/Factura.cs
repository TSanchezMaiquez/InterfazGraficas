using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraInteractiva
{
    public partial class Factura : Form
    {
        private Presupuesto presupuesto;
        private double precio = 0;
        private const double iva = 0.21;
        private int contadorFactura = 1;
        public Factura(Presupuesto presupuestoEnFactura1)
        {
            InitializeComponent();
            this.presupuesto = presupuestoEnFactura1;
        }
        private void importe()
        {
            rtbFactura.Text = ("                    ---PRESUPUESTO---    \n\n");
            rtbFactura.Text += ("    " + txtNombre.Text + "\t\t\t   Toñi Sanchez\n");
            rtbFactura.Text += ("    " + txtDni.Text + "\t\t\t   12345678D\n");
            rtbFactura.Text += ("    " + txtEmail.Text + "\t\t\t   Toñi@hotmail.com\n\n");
            rtbFactura.Text += ("    Dispositivos                   Importe   \n\n");
            equipo();
            oficina();
            periferico();
            mostrarPresupuesto();
        }
        private void equipo()
        {
            String equipo = presupuesto.Equipo;

            switch (equipo)
            {
                case "pc":
                    precio += 700;
                    rtbFactura.Text += ("    " + presupuesto.Equipo + "                                     700€\n");
                    break;
                case "macintosh":
                    precio += 1000;
                    rtbFactura.Text += ("    " + presupuesto.Equipo + "                       1000€\n");
                    break;
                case "portatil":
                    precio += 500;
                    rtbFactura.Text += ("    " + presupuesto.Equipo + "                               500€\n");
                    break;
            }
        }
        private void oficina()
        {
            if (!String.Equals(presupuesto.Oficina[0], ""))
            {
                precio += 50;
                rtbFactura.Text += ("    " + presupuesto.Oficina[0] + "                        50€\n");
            }
            if (!String.Equals(presupuesto.Oficina[1], ""))
            {
                precio += 20;
                rtbFactura.Text += ("    " + presupuesto.Oficina[1] + "                        20€\n");
            }
            if (!String.Equals(presupuesto.Oficina[2], ""))
            {
                precio += 100;
                rtbFactura.Text += ("    " + presupuesto.Oficina[2] + "                   100€\n");
            }


        }
        private void periferico()
        {
            String periferico = presupuesto.Periferico;
            switch (periferico)
            {
                case "disco duro":
                    precio += 75;
                    rtbFactura.Text += ("    " + presupuesto.Periferico + "                           75€\n");
                    break;
                case "impresora":
                    precio += 90;
                    rtbFactura.Text += ("    " + presupuesto.Periferico + "                            90€\n");
                    break;
                case "antena":
                    precio += 50;
                    rtbFactura.Text += ("    " + presupuesto.Periferico + "                                50€\n");
                    break;
                case "":
                    break;
            }
        }
        private void mostrarPresupuesto()
        {
            rtbFactura.Text += ("\n\nTotal:                                         " + precio + "€ " + "\nIVA(21%):                                "
                + (precio + (precio * iva)) + "€");
            rtbFactura.Text += ("\n\n Forma de pago: " + presupuesto.Pago);
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            importe();
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {

            string contenido = rtbFactura.Text;


            string nombreArchivo = $"factura{contadorFactura}.txt";


            try
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.Write(contenido);
                }

                MessageBox.Show($"Factura guardada como {nombreArchivo}", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                contadorFactura++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerArchvo_Click(object sender, EventArgs e)
        {
            string nombreArchivo = Interaction.InputBox("Ingrese el nombre del archivo a leer:", "Leer Archivo", "factura1.txt");

            if (string.IsNullOrEmpty(nombreArchivo))
                return;

            try
            {
              
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string contenidoLeido = sr.ReadToEnd();
                    rtbFichero.Text = contenidoLeido;

                    MessageBox.Show("Factura leída exitosamente", "Lectura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

