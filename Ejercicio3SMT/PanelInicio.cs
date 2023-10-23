using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3SMT
{
    public partial class Ejercicio3 : Form
    {
        private String [,] usuarios = new String[4, 2];
        private int contador = 0;

        public Ejercicio3()
        {
            InitializeComponent();
           

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            lblComprobacion.Visible = false;
            contador++;
            if (comprobarUsuario())
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                lblComprobacion.Visible = true;
            }
            if (contador == 3)
            {
                this.Close();
            }
        }
        private void IniciarUsuarios()
        {
       

            for (int i = 0; i < usuarios.GetLength(0)-1; i++)
            {
                usuarios[i, 0] = "usu" + i;
                usuarios[i, 1] = "pw" + i;
            }
            
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            IniciarUsuarios();
        }

        private Boolean comprobarUsuario()
        {
            

            for (int i = 0; i < usuarios.GetLength(0) - 1; i++)
            {
                if ((txtUsuario.Text).Equals(usuarios[i,0]))
                {
                    if ((txtContraseña.Text).Equals(usuarios[i, 1]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
