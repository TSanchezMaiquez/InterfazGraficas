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
    public partial class Calculadora : Form
    {
        int num1 = 0;
        int num2 = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BTNSumar_Click(object sender, EventArgs e)

        {


            if (comprobar())
            {
                LBLError.Visible = false;
                TXTResultado.Text = (num1+num2).ToString();
            } else { 
                LBLError.Visible = true;
             }
    
        }

        private void BTNResta_Click(object sender, EventArgs e)
        {
            

            if (comprobar())
            {
                LBLError.Visible = false;
                TXTResultado.Text = (num1 - num2).ToString();
            }
            else
            {
                LBLError.Visible = true;
            }
        }

        private void BTNMultiplicacion_Click(object sender, EventArgs e)
        {
            

            if (comprobar())
            {
                LBLError.Visible = false;
                TXTResultado.Text = (num1 * num2).ToString();
            }
            else
            {
                LBLError.Visible = true;
            }
        }

        private void BTNDividir_Click(object sender, EventArgs e)
        {
           

            if (comprobar())
            {
                if (num2 != 0)
                {
                    LBLError.Visible = false;
                    TXTResultado.Text = (num1/num2).ToString();
                }
                else TXTResultado.Text = "Infinito";
            }
            else { 
                LBLError.Visible = true;
            }
        }

        private Boolean comprobar ()
        {
            if ((Int32.TryParse(TXTNum1.Text, out num1) && Int32.TryParse(TXTNum2.Text, out num2))) return true;
            else return false;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
