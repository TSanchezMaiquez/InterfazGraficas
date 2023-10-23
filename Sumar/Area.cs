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
    public partial class Area : Form
    {

        int num1 = 0;
        int num2 = 0;

        public Area()
        {
            InitializeComponent();
        }

        

        private void rdbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lblAltura.Text = "Lado";
            lblBase.Visible = false;
            txtBase.Visible = false;
        }
        private void rbtRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblAltura.Text = "Altura";
            lblBase.Visible = true;
            txtBase.Visible = true;
        }
        private void rbtTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblAltura.Text = "Altura";
            lblBase.Visible = true;
            txtBase.Visible = true;
        }



        private Boolean comprobar()
        {
            if (Int32.TryParse(txtBase.Text, out num1) && Int32.TryParse(txtAltura.Text, out num2) && num1 > 0 && num2 > 0)
                return true;
            else
                return false;
        }

        private void CalcularArea()
        {
            if (comprobar())
            {
                lblError.Visible = false;
                lblErrorInformativo.Visible = false;

                if (rdbCuadrado.Checked)
                {
                    txtResultado.Text = (num2*num2).ToString();
                }
                else if (rbtRectangulo.Checked)
                {
                    txtResultado.Text = (num1 * num2).ToString();
                }
                else if (rbtTriangulo.Checked)
                {
                    txtResultado.Text = ((num1 * num2) / 2).ToString();
                }
            }
            else
            {
                lblError.Visible = true;
                lblErrorInformativo.Visible = true;
            }
        }

        private void btnVolverA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();   
            inicio.Show();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            CalcularArea();
        }
    }
}
