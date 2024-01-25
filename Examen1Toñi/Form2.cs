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

namespace Examen1Toñi
{
    public partial class Form2 : Form
    {
        List<Cliente> clientes;
        private Cliente cliente;

        public Form2(List <Cliente> clientesF)
        {
            clientes = clientesF;
            InitializeComponent();
        }
       
        private void operacionesToolStripMenu(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            Application.Exit();
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            bool clave = Regex.IsMatch(txtClaveContraseña.Text, @"\d{9}");
            Boolean encontrado = false;
            int claveC = 0;
            if (clave)
            {
                claveC = Int32.Parse(txtClaveContraseña.Text);
            }
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].ClaveCli== claveC)
                {
                    encontrado = true;
                    cliente = clientes[i];
                }
            }
            if (encontrado)
            {

            }
        }
    }
}
