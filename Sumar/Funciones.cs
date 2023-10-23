using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumar
{
    public partial class Funciones : Form
    {
        int num1 = 0;
        public Funciones()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            

            if (Int32.TryParse(txtNum.Text, out num1) && num1 >=0 && num1 <=16)
            {

                txtResultadoFa.Text = (Factorial(Int32.Parse(txtNum.Text))).ToString();
                txtResultadoFi.Text=(Fibonacci(num1).ToString());
            }
            else
            {
                lblError.Visible = true;
            }
        }

       

        private int Factorial(int numIntro)
        {

            if (numIntro == 1) return 1;
            else if (numIntro == 0) return 0;
            else
            {
                return numIntro*Factorial(numIntro-1);
            }
           
        }

       
private int Fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }

        private void btbVolverF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();   
            inicio.Show();
        }
    }
}
