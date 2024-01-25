using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Examen1Rehecho
{
    public partial class Form2 : Form
    {
        private List <Cliente> clientes = new List<Cliente>();
        private Cliente cliente= null;
        private int indice = -1;
        public Form2(List <Cliente> clientes, Cliente cliente)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.cliente = cliente;
            this.Text = cliente.NombreCli;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1(clientes, cliente);
            this.Hide();
            formulario.Show();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbCambiarClave.Visible = true;
            lblNuevaClave.Visible = false;
            lblRepetirClave2.Visible = false;
            btnCambiar.Visible = false;
            txtContra1.Visible = false;
            txtContra2.Visible = false;
            txtCambiarClaveClave.Text = "";
            txtContra1.Text = "";
            txtContra2.Text = "";
        }

        private void btnCambiarContraseñaIntro_Click(object sender, EventArgs e)
        {         
            if (Int32.TryParse(txtCambiarClaveClave.Text, out int num) && num>999 && num< 10000)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].ClaveCli == num)
                    {
                        indice = i;
                    }
                }
                if(indice > -1)
                {
                    lblNuevaClave.Visible = true;
                    lblRepetirClave2.Visible = true;
                    btnCambiar.Visible = true;
                    txtContra1.Visible = true;
                    txtContra2.Visible = true;

                }else
                {
                    MessageBox.Show("Clave no valida");
                    txtCambiarClaveClave.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Clave no valida");
                txtCambiarClaveClave.Text = "";
            }
          
        
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(string.Equals(txtContra1.Text, txtContra2.Text, StringComparison.OrdinalIgnoreCase) &&
                Int32.TryParse(txtContra1.Text, out int num) && num >999 && num < 10000)
            {
                clientes[indice].ClaveCli = num;

            }else
            {
                MessageBox.Show("Las contraseñas deben ser iguales y de longitud 4");
                txtContra1.Text = "";
                txtContra2.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCambiarClaveClave.Text = "";
            txtContra1.Text = "";
            txtContra2.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            grbCambiarClave.Visible = false;
           
        }
    }
}
