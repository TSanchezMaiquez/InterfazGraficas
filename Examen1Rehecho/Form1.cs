using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Rehecho
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private String dni;
        private int count=0;
        private Cliente cliente = null;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Cliente> clientes, Cliente cliente)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.cliente = cliente;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarYLimpiar();
            grbAlta.Visible = true;
        }

        private void cerrarYLimpiar()
        {
            grbAlta.Visible = false;
            grbConsulta.Visible = false;
            grbCajero.Visible = false;
            grbBloqueoDesbl.Visible = false;

            ckbConsulta.Visible = false;

            txtAltaDni.Text = "";
            txtAltaNombre.Text = "";
            txtAltaSaldo.Text = "";
            txtAltaClave.Text = "";
            txtConsultaNombre.Text = "";
            txtCajeroClave.Text = "";
            txtCajeroDni.Text = "";

            txtCajeroDni.Enabled = true;
            btnCajeroDni.Enabled = true;
            btnBloqueoDesbloqueo.Visible = false;

            txtCajeroClave.Visible = false;
            lblCajeroClave.Visible = false;
            btnCajeroClave.Visible = false;

            rtbConsulta.Clear();
        }

        private void btnAltaCrear_Click(object sender, EventArgs e)
        {
            if (!comprobarCamposAlta())
            {
                MessageBox.Show("Los campos que no han pasado la validacion han sido borrados");
            }else
            {
                int clave = Int32.Parse(txtAltaClave.Text);
                double saldo = Double.Parse(txtAltaSaldo.Text);
                clientes.Add (new Cliente(txtAltaDni.Text, txtAltaNombre.Text, clave, saldo));
                dni = txtAltaDni.Text;
                MessageBox.Show("Cliente creado correctamente");
            }
        }
        private bool comprobarCamposAlta()
        {
            bool correcto = true;

            if (string.IsNullOrWhiteSpace(txtAltaDni.Text) || !validarDni())
            {
                txtAltaDni.Text = "";
                correcto = false;
            }
            if (string.IsNullOrWhiteSpace(txtAltaNombre.Text) || !validarNombre())
            {
                txtAltaNombre.Text = "";
                correcto = false;
            }
            if (string.IsNullOrWhiteSpace(txtAltaSaldo.Text) || !validarSaldo())
            {
                txtAltaSaldo.Text = "";
                correcto = false;
            }
            if (string.IsNullOrWhiteSpace(txtAltaClave.Text) || !validarClave())
            {
                txtAltaClave.Text = "";
                correcto = false;
            }
           
            return correcto;
        }
        private bool validarDni()
        {
            return Regex.IsMatch(txtAltaDni.Text, @"\d{8}[A-Z]{1}");
        }
        private bool validarNombre()
        {
            return Regex.IsMatch(txtAltaNombre.Text, "[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]");
        }
        private bool validarClave()
        {
            return Regex.IsMatch(txtAltaClave.Text, @"^\d{4}");
        }
        private bool validarSaldo()
        {
            return Regex.IsMatch(txtAltaSaldo.Text, @"^-?\d+(\.\d+)?$");
        }
        private void btnAltaLimpiar_Click(object sender, EventArgs e)
        {
            cerrarYLimpiar();
            grbAlta.Visible = true;
        }
        private void btnaltaCerrar_Click(object sender, EventArgs e)
        {
            grbAlta.Visible = false;
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarYLimpiar();
            grbConsulta.Visible = true;
        }

        private void btnConsultaBuscar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            Cliente cliente= null;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (string.Equals(txtConsultaNombre.Text, clientes[i].NombreCli, StringComparison.OrdinalIgnoreCase))
                {               
                    cliente = clientes[i];
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                rtbConsulta.Text = "Cliente no encontrado";
            }
            else
            {
                if (cliente.BloqueoCli)
                {
                    ckbConsulta.Checked = true;
                    ckbConsulta.Visible = true;
                    rtbConsulta.Text = cliente.ToString();
                }else
                {
                    ckbConsulta.Checked = false;
                    ckbConsulta.Visible = true;
                    rtbConsulta.Text = cliente.ToString();
                    rtbConsulta.Text += "\nClave: " + cliente.ClaveCli;
                }
            }
        }

        private void btnConsultaCerrar_Click(object sender, EventArgs e)
        {
            grbConsulta.Visible=false;
        }

        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarYLimpiar();
            grbCajero.Visible = true;
        }

        private void btnCajeroIntro_Click(object sender, EventArgs e)
        {       

            if (!string.IsNullOrWhiteSpace(txtCajeroDni.Text))
            {               
               for (int i = 0; i< clientes.Count; i++)
                {
                    if (string.Equals(txtCajeroDni.Text, clientes[i].DniCli) ) 
                    {
                        cliente = clientes[i];
                        if (!cliente.BloqueoCli)
                        {
                            txtCajeroClave.Visible = true;
                            lblCajeroClave.Visible = true;
                            btnCajeroClave.Visible = true;
                            btnCajeroClave.Enabled = true;
                        }else
                        {
                            MessageBox.Show("Tarjeta bloqueada. Debe desbloquearla primero");
                        }
                  
                    }
                }
               
            }else
            {
                MessageBox.Show("Dato introducido no valido");
            }
        }

        private void btnCajeroClave_Click(object sender, EventArgs e)
        {
            int clave = 0;
            if ( (Int32.TryParse(txtCajeroClave.Text, out clave)) && (cliente.ClaveCli == clave) )
            {               
                Form2 formulario = new Form2(clientes, cliente);
                this.Hide();
                formulario.Show();
                count = 0;
                
            }else
            {
                MessageBox.Show("Clave incorrecta");

                if (String.Equals(dni, cliente.DniCli))
                {
                    count++;
                }
                else
                {
                    count = 1;
                    dni = cliente.DniCli;
                }

                if (count == 3)
                {
                    cliente.BloqueoCli = true;
                    MessageBox.Show("Tarjeta bloqueada");
                    btnCajeroClave.Enabled = false;

                }
                else
                {
                    MessageBox.Show(count + "º intento. Le quedan " + (3 - count));
                }
            }

            
        }

        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarYLimpiar();
            grbBloqueoDesbl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbCajero.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grbBloqueoDesbl.Visible=false;
        }

        private void btnBloqueoIntro_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            if(Int32.TryParse(txtBloqueoClave.Text, out int clave))
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if ( (string.Equals(txtBloqueoDbi.Text, clientes[i].DniCli, StringComparison.OrdinalIgnoreCase)) 
                        && clientes[i].ClaveCli==clave)
                    {
                        cliente = clientes[i];
                    }
                }
                if (cliente!=null)
                {
                    if (cliente.BloqueoCli)
                    {
                        btnBloqueoDesbloqueo.Text = "Desbloquear";
                        cliente.BloqueoCli = false;
                        MessageBox.Show("La tarjeta ha sido desbloqueada");
                    }else
                    {
                        btnBloqueoDesbloqueo.Text = "Bloquear";
                        cliente.BloqueoCli = true;
                        MessageBox.Show("La tarjeta ha sido bloqueada");
                    }
                    btnBloqueoDesbloqueo.Visible = true;
                }else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }else
            {
                MessageBox.Show("Datos incorrectos");
            }
            
        }
    }
}
