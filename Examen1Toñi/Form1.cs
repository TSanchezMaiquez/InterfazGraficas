using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Examen1Toñi
{
    public partial class Form1 : Form
    {
        private Cliente cliente;
        static List<Cliente>  clientes = new List<Cliente>();
        private int countCajero = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void menuCliente(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (string.Equals(menuItem.Text, "Alta", StringComparison.OrdinalIgnoreCase)) 
            {
                cerrarGrupos();
                grbAltas.Visible = true;
            }
            else
            {
                cerrarGrupos();
                grbConsulta.Visible = true;
                if (cliente.BloqueoCli){
                    ckbBloqueo.Checked = false;
                }else
                {
                    ckbBloqueo.Checked = true;
                }
            }
        }

        private void cerrarGrupos()
        {
            grbAltas.Visible = false;
            grbConsulta.Visible = false;
            grbCajero.Visible = false;
            grbTarjeta.Visible = false;

            ckbBloqueo.Visible = false;
            lblError.Visible = false;
            lblAltasExito.Visible = false;
            lblErrorTarjeta.Visible = false;
            txtDniTarjeta.Text = "";
            txtClaveTarjeta.Text = "";
            txtConsulta.Text = "";
            txtDniCajero.Text = "";
            txtClaveCajero.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtClave.Text = "";
            txtSaldo.Text = "";
            rtbConsulta.Clear();
            txtConsulta.Text = "";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            bool dni = Regex.IsMatch(txtDni.Text, @"\d{8}[A-Z]{1}");
            bool nombre = Regex.IsMatch(txtNombre.Text, @"[a-zA-ZñÑüÜáéíóúÁÉÍÓÚ]\s*");
            bool clave = Regex.IsMatch(txtClave.Text, @"\d{4}");
            bool saldo = Regex.IsMatch(txtSaldo.Text, @"^-?\d+(\.\d+)?$");
            double saldoC = Double.Parse(txtSaldo.Text);
            int claveC = Int32.Parse(txtClave.Text);

            if(dni && nombre && clave && saldo){
                cliente = new Cliente(txtDni.Text, txtNombre.Text, claveC, saldoC);
                clientes.Add(cliente);
                lblAltasExito.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            grbAltas.Visible = true;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (string.Equals(txtConsulta.Text, clientes[i].NombreCli, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    rtbConsulta.Text = "---Datos cliente---\n";
                    rtbConsulta.Text += "Dni: " + clientes[i].DniCli;
                    rtbConsulta.Text += "\nNombre: " + clientes[i].NombreCli;
                    rtbConsulta.Text += "\nSaldo: " + clientes[i].SaldoCli;
                    if (!clientes[i].BloqueoCli)
                    {
                        rtbConsulta.Text += "\nClave: " + clientes[i].ClaveCli;                                         
                    }
                    ckbBloqueo.Visible = true;
                }
               
            }
          
            if (!encontrado)
            {
                rtbConsulta.Text = "Cliente no encontrado";
            }
        }

        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            grbCajero.Visible = true;
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            countCajero++;
            bool clave = Regex.IsMatch(txtClaveCajero.Text, @"\d{4}");
            bool encontrado = false;
            Boolean bloqueo = false;
           
            if (countCajero < 3 && !cliente.BloqueoCli)
            {
                if (clave)
                {
                    int claveC = Int32.Parse(txtClaveCajero.Text);
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (string.Equals(clientes[i].DniCli, txtDniCajero.Text, StringComparison.OrdinalIgnoreCase) && clientes[i].ClaveCli == claveC)
                        {
                            encontrado = true;
                            bloqueo = clientes[i].BloqueoCli;
                            cliente = clientes[i];
                        }
                    }
                    if (!encontrado || (encontrado && bloqueo))
                    {
                        MessageBox.Show("El cliente no existe. Le queda " + (3 - countCajero));
                       
                    }
                    else
                    {
                        countCajero = 0;
                        Form2 formulario = new Form2(clientes);
                        formulario.Text = cliente.NombreCli;
                        this.Hide();
                        formulario.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                    txtClaveCajero.Text = "";
                    txtDniCajero.Text = "";
                }
            }else
            {
                cliente.BloqueoCli= true;

            }                 
           
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            grbTarjeta.Visible = true;
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            
            bool clave = Regex.IsMatch(txtClaveTarjeta.Text, @"\d{4}");
            bool clienteEncontrado = false;

            if (clave)
            {
                int claveC = Int32.Parse(txtClaveTarjeta.Text);
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (string.Equals(clientes[i].DniCli, txtDniTarjeta.Text, StringComparison.OrdinalIgnoreCase) 
                        && clientes[i].ClaveCli== claveC)
                    {
                        clienteEncontrado = true;
                        cliente = clientes[i];
                        lblErrorTarjeta.Visible = false;
                    }
                }
                if (clienteEncontrado)
                {
                    if (cliente.BloqueoCli)
                    {
                        btnTarjetaBloqDes.Text = "Desbloquear";
                    }else
                    {
                        btnTarjetaBloqDes.Text = "Bloquear";
                    }
                    btnTarjetaBloqDes.Visible = true;
                }
                {
                    
                }
            }
            else
            {
                lblErrorTarjeta.Visible = true;
            }
            
        }

        private void btnTarjetaBloqDes_Click(object sender, EventArgs e)
        {
            if(cliente.BloqueoCli)
            {
                cliente.BloqueoCli = false;
                btnTarjetaBloqDes.Text = "Bloquear";

            }else
            {
                cliente.BloqueoCli = true;
                btnTarjetaBloqDes.Text = "Desbloquear";
            }
        }

       
    }
    
}
