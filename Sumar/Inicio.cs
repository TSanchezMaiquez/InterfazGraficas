using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumar
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (txtOpcion.Text)
            {
                case "1":
                    Calculadora calculadoraForm = new Calculadora(); 
                    calculadoraForm.Show();
                    this.Hide();
                    break;

                case "2":
                    Area areaForm = new Area();
                    areaForm.Show();
                    this.Hide();
                    break;
                case "3":
                    Funciones funcionesForm = new Funciones();
                    funcionesForm.Show();
                    this.Hide();
                    break;
                case "4":
                    Adivinar adivinar = new Adivinar();
                    adivinar.Show();
                    this.Hide();
                    break;
                case "5":
                    Application.Exit();
                    break;
                default:
                    lblError.Visible = true;
                    break;

            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {

        }
    }
}
