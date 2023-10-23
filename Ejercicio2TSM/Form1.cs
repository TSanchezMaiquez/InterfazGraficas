using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2TSM
{
    public partial class Ejercicio2 : Form
    {
        int num = 0;
        int[] numeros = new int[10];
        int contador = 0;
        int numMayor= int.MinValue;
        int numMenor= int.MaxValue;
        double media = 0;
        public Ejercicio2()
        {
            InitializeComponent();
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comprobar())
            {
                
                numeros[contador] = num;
                LtbNumeros.Items.Add(num);
                contador++;
                media += num;

            }
            else
            {
                lblError.Visible = true;
            }
            if(num>numMayor) numMayor= num;
            if(num<numMenor) numMenor= num;

            if (esPrimo()) txtPrimo.Text = "Si";
            else txtPrimo.Text = "No";

            if (contador == 10)
            {
                btnIntroducir.Enabled = false;
                txtNum.Enabled = false;
                btnAscendente.Visible=true;
                btnDescendente.Visible = true;
                lblOrdenar.Visible=true;
                btnIntroducir.Visible=false;
            }
            repetido();
        }


        public Boolean comprobar()
         {
                if (Int32.TryParse(txtNum.Text, out num)) return true; 
                return false;
         }

        public Boolean esPrimo()
        {
            if (num == 2 || num == 3) return true;
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0) return false;
            else return true;
        }

        public void repetido ()
        {
            int contar = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == num) contar++;

            }
            
            txtNumRepe.Text=contar.ToString();
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            lblArray.Text = "";
            int aux = 0;
            for (int i = 0; i <  numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                lblArray.Text += numeros[i].ToString() + " ";
            }
            visible();
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            lblArray.Text = "";
            int aux = 0;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                lblArray.Text += numeros[i].ToString() + " ";
            }
            visible();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LtbNumeros.Items.Clear();
            txtNum.Text = "";
            txtNum.Enabled = true;
            btnIntroducir.Enabled = true;
            txtPrimo.Text = "";
            txtNumRepe.Text = "";
            lblOrdenar.Text = "";
            lblArray.Text = "";
            btnIntroducir.Visible = true;
            btnAscendente.Visible = false;
            btnDescendente.Visible = false;
            numeros = new int[10];
            contador = 0;
            txtMayor.Visible = false;
            txtMenor.Visible = false;
            lblMedia.Visible = false;
            txtMedia.Visible = false;
            lblMayor.Visible = false;
            lblMenor.Visible = false;
        }

        private void visible()
        {
            lblMayor.Visible = true;
            lblMenor.Visible = true;
            txtMayor.Text = numMayor.ToString();
            txtMenor.Text = numMenor.ToString();
            txtMedia.Text = (media / 10).ToString();
            txtMayor.Visible = true;
            txtMenor.Visible = true;
            lblMedia.Visible = true;
            txtMedia.Visible = true;
        }
    }
  
 
}
