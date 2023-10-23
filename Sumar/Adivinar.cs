using System;
using System.Windows.Forms;

namespace Sumar
{
    public partial class Adivinar : Form
    {
        int numIntroducido = 0;
        int random = 0;

        public Adivinar()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            if (comprobar())
            {
                lblError.Visible = false;
                aJugar();
            }else
            {
                lblError.Visible = true;
            }
            
        }
        private void aJugar()
        {
            int intentos = Int32.Parse(txtIntentos.Text);
            

                if (numIntroducido > random)
                {
                    txtMayorMenor.Text = "mayor";
                    intentos--;
                    txtIntentos.Text=intentos.ToString();

                }
                else if (numIntroducido < random)
                {
                    txtMayorMenor.Text = "menor";
                    intentos--;
                    txtIntentos.Text = intentos.ToString();
            }
                
                 if(intentos <= 3)
                {
                    txtIntentos.ForeColor = System.Drawing.Color.Red;
                }   
               
            
                if (intentos == 0)
                {
                    lblDerrotaVictoria.Text = "Has perdido!!!";
                    lblDerrotaVictoria.Visible = true;
                }
                if(numIntroducido == random)
                {
                    txtMayorMenor.Text = "Felicidades!!";
                    lblDerrotaVictoria.Visible= true;
                }
        }
       

        private Boolean comprobar()
        {
            if (Int32.TryParse(txtNum.Text, out numIntroducido)) return true;
            else return false;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random randomB = new Random();
             random = randomB.Next(0, 101);
            txtIntentos.Text = "7";
            txtMayorMenor.Text = "";
            txtNum.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
//aplication.exit