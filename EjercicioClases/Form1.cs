﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjercicioClases
{
    public partial class Form1 : Form
    {
        private int numero;
        private String precio="";
        private List<Articulo> articulos = new List<Articulo>();
        private Articulo articulo = new Articulo();
        public Form1()
        {
            InitializeComponent();
           
        }

      
        private void cerrarGrupos()
        {
            grbConsultas.Visible = false;
            grbListado.Visible = false;
            grbPedido.Visible = false;
            grbAltas.Visible = false;

            lblCodAct.Visible = false;
            lblInfoElim.Visible = false;
            lblElimArt.Visible = false;
            lblCatList.Visible = false;

            btnActArt.Visible = false;
            btnElimArt.Visible = false;

            txtcodAct.Visible = false;

       
            cbbListado.Visible = false;


        }
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            ToolStripItem menuItem = sender as ToolStripItem;

            if (string.Equals(menuItem.Text, "Actualizar", StringComparison.OrdinalIgnoreCase))
            {
                grbAltas.Visible=true;
                lblAltas.Text = "Actualizar";
                bloquearCamposAlta();
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCodigo.Enabled = false;
                lblCodAct.Visible = true;
                btnActArt.Visible = true;
                txtcodAct.Visible = true;
            }

            else if (string.Equals(menuItem.Text, "&Altas", StringComparison.OrdinalIgnoreCase))
            {
                int codigo = articulos.Count+1;
              
                grbAltas.Visible = true;
                lblAltas.Text = "Altas";
                txtCodigo.Enabled = false;
                txtCodigo.Text = codigo.ToString();

                reiniciarCampos();
            }
            else if (string.Equals(menuItem.Text, "&Pedidos", StringComparison.OrdinalIgnoreCase))
            {
               
                grbPedido.Visible = true;
                lblCodNoExiste.Visible = false;
            }
            else
            {
                Application.Exit();
            }
         }
        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            cerrarGrupos();
            lblConsultas.Text = "Consultas";
            rtbConsultas.Clear();
            grbConsultas.Visible = true;

            if (string.Equals(menuItem.Text, "Por &Nombre", StringComparison.OrdinalIgnoreCase))
            {
                lblCon.Text = "Nombre";
            }
            else if (string.Equals(menuItem.Text, "&Eliminar", StringComparison.OrdinalIgnoreCase))
            {
                lblConsultas.Text = "Eliminar";
                lblInfoElim.Visible = true;
            }
            else
            {
                lblCon.Text = "Código";
            }
        }
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            string mensaje = "Toñi Sánchez Maiquez";
            DialogResult result = MessageBox.Show(mensaje, "Autor");

        }
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            cerrarGrupos();
            rtbListado.Clear();
            
            grbListado.Visible = true;
           

            bool continuar = true;
           
            int tipoBusqueda = 0;

            if (string.Equals(menuItem.Text, "&Mínimos", StringComparison.OrdinalIgnoreCase))
            {
                lblTipoListado.Text = "por mínimos";
                tipoBusqueda = 1;
                listarArticulos(tipoBusqueda);

            }
            else if (string.Equals(menuItem.Text, "Por &Categoría", StringComparison.OrdinalIgnoreCase))
            {
                continuar = false;
                lblTipoListado.Text = "por categoría";
                lblCatList.Visible = true;
                cbbListado.Visible = true;

            }
            else
            {
                lblTipoListado.Text = "todos";
                listarArticulos(tipoBusqueda);
            }
            
        }
        private void btnActArt_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtcodAct.Text, out int num))
            {
                for (int i = 0; i < articulos.Count; i++)
                {
                    if (articulos[i].CodigoArt == num)
                    {
                        reiniciarCampos();
                        btnAceptar.Enabled = true;
                        btnCancelar.Enabled = true;
                        txtCodigo.Text = txtcodAct.Text;
                    }
                }
            }
            
        }
        private void cbbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarArticulos(2);
        }

        private void listarArticulos(int tipoBusqueda)
        {
            

            if (tipoBusqueda == 1)
            {
                for (int i = 0; i < articulos.Count; i++)
                {
                    if (articulos[i].ExistenciasArt < 10)
                    {
                        this.articulo = articulos[i];
                        rtbListado.AppendText("\n   ---Artículo " + (i + 1) + " ---   \n\n" + articulo.ToString() + Environment.NewLine);

                    }
                }
            }

            else if (tipoBusqueda == 2)
            {
                rtbListado.Clear();
                object elementoSeleccionado = cbbListado.SelectedItem;
                for (int i = 0; i < articulos.Count; i++)
                {
                    if (String.Equals(articulos[i].CategoriaArt, elementoSeleccionado.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        articulo = articulos[i];
                        rtbListado.AppendText("\n   ---Artículo " + (i + 1) + " ---   \n\n" + articulo.ToString() + Environment.NewLine);
                    }
                }
            }
            else
            {
                for (int i = 0; i < articulos.Count; i++)
                {
                        articulo = articulos[i];
                        rtbListado.AppendText("\n   ---Artículo " + (i + 1) + " ---   \n\n" + articulo.ToString() + Environment.NewLine); 
                }
            }

        }
        private void textBoxReinicio_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;


            if (textBox != null)
            {
                textBox.Text = "";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarCamposAltas();
            
        }

        private void validarCamposAltas()
        {
            lblNombreError.Visible = txtNombre.Text.Length < 3;

            precio = txtPrecio.Text;
            string pattern = @"^\d+,\d{2}$";
            lblPrecioError.Visible = !Regex.IsMatch(precio, pattern);

          
            bool esNumeroValido = int.TryParse(txtExistencias.Text, out numero);
            lblExistError.Visible = !esNumeroValido || numero <= 0;

            object elementoSeleccionado = cbbCategoria.SelectedItem;
            lblCategoriaError.Visible = elementoSeleccionado == null;
            

                if (!lblNombreError.Visible && !lblPrecioError.Visible && !lblExistError.Visible && !lblCategoriaError.Visible)
                {

                    bloquearCamposAlta();

                    if ((String.Equals(lblAltas.Text, "Actualizar", StringComparison.OrdinalIgnoreCase)))
                    {
                        actualizar();
                    }


                registrar();
                    
                }

        }
        private void bloquearCamposAlta()
        {
            txtNombre.Enabled = false;
            cbbCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtExistencias.Enabled = false;
        }
        private void actualizar()
        {
            int codigo = int.Parse(txtCodigo.Text);
            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].CodigoArt == codigo)
                {
                    articulos[i].NombreArt = txtNombre.Text;
                    articulos[i].CategoriaArt = cbbCategoria.Text;
                    articulos[i].PrecioArt = double.Parse(txtPrecio.Text);
                    articulos[i].ExistenciasArt =int.Parse(txtExistencias.Text);

                }
            }
        }
        private void registrar()
        {
            object elementoSeleccionado = cbbCategoria.SelectedItem;
            String eleSel = elementoSeleccionado.ToString();
            double precioArt = Double.Parse(precio);
            articulo = new Articulo(txtNombre.Text, eleSel, precioArt, numero);

            articulos.Add(articulo);
            lblRegistro.Visible = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }
        private void reiniciarCampos()
        {
            txtCodigo.Text = (articulos.Count + 1).ToString();
            cbbCategoria.Enabled = true;
            txtNombre.Enabled=true;
            txtPrecio.Enabled = true;
            txtExistencias.Enabled = true;
            cbbCategoria.SelectedIndex = -1;
            txtNombre.Text = "Al menos 3 carácteres";
            txtPrecio.Text = "2 decimales y coma";
            txtExistencias.Text = "ni nº negativos ni 0";
            lblRegistro.Visible= false;
        }


        private void bntStock_Click(object sender, EventArgs e)
        {
            lblCodNoExiste.Visible = false;
            lblPedRealizado.Visible = false;

            if ((int.TryParse(txtCantPed.Text, out int numCant)) && (int.TryParse(txtCodPed.Text, out int numCod))){
                buscarCodigo (numCod, numCant);
            }else
            {
                lblCodNoExiste.Visible = true;
              
            }
            
        }
        private void buscarCodigo (int numCod, int numCant)
        {
            bool existe = false;
            
            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].CodigoArt == numCod)
                {
                    articulo = articulos[i];
                    existe = true;
                }
            }
            if (existe)
            {
                actualizarExistencias(numCant);
            }
            else
            {
                lblCodNoExiste.Visible = true;
            }
        }

        private void actualizarExistencias(int cantidad)
        {

            if (articulo.ExistenciasArt >= cantidad)
            {
                string mensaje = "Puede realizar el pedido.\nCantidad restante tras realizar el pedido: " + (articulo.ExistenciasArt - cantidad) + "\n¿Realizar pedido?";
                DialogResult result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                if (result == DialogResult.Yes)
                {
                    articulo.ExistenciasArt -= cantidad;
                    lblPedRealizado.Visible = true;
                    lblCodNoExiste.Visible = false;
                    txtCodPed.Text = "";
                    txtCantPed.Text = "";
                }
            }          
            else
            {
                string mensaje2 = "Cantidad almacenada menor a la solicitada.\nNo se puede realizar el pedido.\nCantidad almacenada: " + articulo.ExistenciasArt;
                MessageBox.Show(mensaje2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   
        private void btnConsultas_Click(object sender, EventArgs e)
        {
                    
            bool articuloEncontrado = false;
            rtbConsultas.Clear();
            bool busquedaPorCodigo = false;
                  
            if((String.Equals(lblCon.Text, "Código", StringComparison.OrdinalIgnoreCase)))
            {
                busquedaPorCodigo = true;
            }
            int num = -1;
            if ((!int.TryParse(txtConsultas.Text, out num)) && (busquedaPorCodigo==true))
            {
                lblConError.Visible = true;
            }

            for (int i = 0; i < articulos.Count; i++)
            {
                if ( (string.Equals(articulos[i].NombreArt, txtConsultas.Text, StringComparison.OrdinalIgnoreCase)) 
                    ||  (busquedaPorCodigo=true &&num>-1 && articulos[i].CodigoArt == num) )
                {
                    articulo = articulos[i];
                    lblConError.Visible = false;
                    rtbConsultas.AppendText("\n   ---Artículo---   \n\n" + articulo.ToString() + Environment.NewLine);
                    articuloEncontrado = true;
                    if (articulo.ExistenciasArt == 0)
                    {
                        lblElimArt.Visible = true;
                        btnElimArt.Visible = true;
                    }
                }
            }
            if (!articuloEncontrado)
            {
                rtbConsultas.AppendText("Articulo no encontrado");
            }

        }
        private void btnElimArt_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Estás seguro de que quieres eliminar el producto?";
            DialogResult result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                articulos.Remove(articulo);
                mensaje = "Articulo eliminado";
                result = MessageBox.Show(mensaje);
            }
        }

       
    }
}
