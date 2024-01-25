using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archivosTextoTSM
{
    public partial class Form1 : Form
    {
        private List<Contacto> listin = new List<Contacto>();
        private Contacto contacto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            if (comprobarCampos())
            {
                lblAltasError.Visible = false;
                lblAltasCreacion.Visible = true;

                int id = Int32.Parse(txtId.Text);
                int phone = Int32.Parse(txtPhone.Text);
               
                contacto = new Contacto(id, txtName.Text, phone);
                listin.Add(contacto);
            }else
            {
                lblAltasError.Visible = true;
            }
        }
        private Boolean comprobarCampos()
        {
            Boolean nombre = Regex.IsMatch(txtName.Text, "[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]");
            Boolean phone = Regex.IsMatch(txtPhone.Text, @"\d{9}");
            bool numero = Regex.IsMatch(txtId.Text, @"^-?\d+$");

            if (!nombre) txtName.Text = "";           
            if (!phone) txtPhone.Text = "";
            if (!numero) txtId.Text = "";

            return nombre && phone && numero;       
         
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbAltas.Visible = true;
        }
        private void btnAltasBorrar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            lblAltasCreacion.Visible = false;
            lblAltasError.Visible = false;
        }
        private void CerrarGruposYLimpiar()
        {
            grbAltas.Visible= false;
            grbConsulta.Visible= false;
            grbGuardar.Visible= false;
            grbGuardarPorInicial.Visible = false;
            grbLectura.Visible= false;
            grbEliminar.Visible= false;

            btnGuardarGuardarI.Visible= false;

            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtNombreConsultas.Text = "";
            txtGuardarI.Text = "";
            txtEliminar.Text = "";

            ltbEliminar.Items.Clear();

            rtbConsultas.Clear();
            rtbGuardar.Clear();
            rtbLectura.Clear();

            lblAltasError.Visible = false;
            lblAltasCreacion.Visible = false;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbConsulta.Visible = true;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            String cadena = "";
            for (int i = 0; i < listin.Count; i++)
            {
                if (string.Equals(listin[i].Name, txtNombreConsultas.Text, StringComparison.OrdinalIgnoreCase))
                {
                    cadena += "Nombre: " + listin[i].Name + "\nTelefono: " + listin[i].Phone+ "\n";
                }
            }
            if (string.IsNullOrWhiteSpace(cadena))
            {
                rtbConsultas.Text = "No hay registros con ese nombre";
            }else
            {
                rtbConsultas.Text = "Datos de contacto\n";
                rtbConsultas.Text += cadena;
            }
        }
        private void guardarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbGuardar.Visible = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "Agenda.txt";

            try
            {
                string rutaCompleta = Path.Combine(Environment.CurrentDirectory, nombreArchivo);

                List<string> lineasAGuardar = new List<string>();
                foreach (Contacto contacto in listin)
                {
                    string linea = $"{contacto.Id},{contacto.Name},{contacto.Phone}";
                    lineasAGuardar.Add(linea);
                }
                File.WriteAllLines(rutaCompleta, lineasAGuardar);
                MessageBox.Show("Archivo guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido crear el archivo: {ex.Message}");
            }


        }

        private void guardarAgendaPorInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbGuardarPorInicial.Visible = true;
        }

        private void btnBuscarGuardarI_Click(object sender, EventArgs e)
        {
            char primerCaracter=' ';
            String cadena = "";

            if (txtGuardarI.Text.Length > 0 && txtGuardarI.Text.Length <2)
            {
                primerCaracter = char.ToLower(txtGuardarI.Text[0]);

            }
            for (int i = 0; i < listin.Count; i++)
            {
                if (primerCaracter.Equals(char.ToLower(listin[i].Name[0])))
                {
                    cadena += listin[i]+ "\n";
                    btnGuardarGuardarI.Visible = true;
                }
            }

            if (string.IsNullOrWhiteSpace(cadena))
            {
                rtbGuardar.Text = "No se han encontrado registros";
            }else
            {
                rtbGuardar.Text = cadena;
            }

            
        }

        private void btnGuardarGuardarI_Click(object sender, EventArgs e)
        {
            string contenido = rtbGuardar.Text;
            string nombreArchivo = "AgendaPorInicial.text";

            try
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.Write(contenido);
                }

                MessageBox.Show($"Archivo guardado como {nombreArchivo}", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leerAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbLectura.Visible = true;
            ToolStripItem menuItem = sender as ToolStripItem;
            String nombreArchivo;

            if (menuItem.Text.Equals("Leer agenda por inicial"))
            {
                nombreArchivo = "AgendaPorInicial.text";
            }else
            {
                nombreArchivo = "Agenda.txt";
            }

            try
            {

                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string contenidoLeido = sr.ReadToEnd();
                    rtbLectura.Text = contenidoLeido;

                    MessageBox.Show("Archivo leída exitosamente", "Lectura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarGruposYLimpiar();
            grbEliminar.Visible = true;
        }

        private void btnBuscarElim_Click(object sender, EventArgs e)
        {
            String nombre = "";
            for (int i = 0; i < listin.Count; i++)
            {              
                if (listin[i].Name.Contains(txtEliminar.Text))
                {
                    ltbEliminar.Items.Add(listin[i].Name);
                }
            }
            ltbEliminar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<int> indicesParaEliminar = new List<int>();

            foreach (int index in ltbEliminar.SelectedIndices)
            {
                indicesParaEliminar.Add(index);
            }
            for (int i = indicesParaEliminar.Count - 1; i >= 0; i--)
            {
                ltbEliminar.Items.RemoveAt(indicesParaEliminar[i]);
                listin.RemoveAt(i);
            }
            MessageBox.Show("Elementos eliminados");
        }
    }
}
