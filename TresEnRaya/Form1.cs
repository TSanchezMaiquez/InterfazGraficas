using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class TresEnRayaToñiSanchezMaiquez : Form
    {
        private char[,] myArray = new char[3, 3];
        int turnos = 0;
        public TresEnRayaToñiSanchezMaiquez()
        {
            InitializeComponent();
        }
       
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos%2 == 0){
                txt1.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[0, 0] = valor;
            if(posicionDiagonal(0, 0, valor) || horizontal(0,0,valor) || vertical(0,0, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                    lblVictoria.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private Boolean posicionDiagonal(int fila, int columna, char valor)
        {
           
            if (fila >= 3)
            {
                return true;
            }

            if (myArray[fila, columna] == valor)
            {
                
                return posicionDiagonal(fila + 1, columna + 1, valor);
            }
         
            return false;

        }
        private Boolean posicionDiagonal2(int fila, int columna, char valor)
        {
            
            if (fila < 0)
            {
                return true;
            }
            if (myArray[fila, columna] == valor)
            {
               
                return posicionDiagonal2(fila - 1, columna + 1, valor);
            }
          
            return false;
        }
        private Boolean horizontal(int fila, int columna, char valor)
        {
           
            if (columna > 2)
            {
                return true;
            }
            if (myArray[fila, columna] == valor)
            {
                
               return horizontal(fila, columna + 1, valor);
            }
          
            return false;
        }
        private Boolean vertical (int fila, int columna, char valor)
        {
          
            if (fila > 2)
            {
                return true;
            }
            if (myArray[fila, columna] == valor)
            {
               
                return vertical(fila+1, columna, valor);
            }
           
            return false;

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            lblTurno1.Text = txtP1.Text;
            lblTurno2.Text = txtP2.Text;
            pnlJuego.Visible = true;
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt2.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[0, 1] = valor;
            if (horizontal(0,0, valor) || vertical(0, 1, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt3.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[0, 2] = valor;
            if (horizontal(0, 0, valor) || vertical(0, 2, valor) || posicionDiagonal2(2, 0, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt4.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[1, 0] = valor;
            if (horizontal(1, 0, valor) || vertical(0, 0, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt5.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[1, 1] = valor;
            if (horizontal(1, 0, valor) || vertical(1, 0, valor) || posicionDiagonal(0,0, valor) || posicionDiagonal2(2,0, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt6.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[1, 2] = valor;
            if (horizontal(1, 0, valor) || vertical(0, 2, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt7.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[2, 0] = valor;
            if (horizontal(2, 0, valor) || vertical(0, 0, valor) || posicionDiagonal2(2,0,valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt8_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt8.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[2, 1] = valor;
            if (horizontal(2, 0, valor) || vertical(0, 1, valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }

        private void txt9_TextChanged(object sender, EventArgs e)
        {
            ++turnos;
            if (turnos % 2 == 0)
            {
                txt9.ForeColor = Color.Red;
            }
            char valor = ((TextBox)sender).Text[0];
            myArray[2, 2] = valor;
            if (horizontal(2, 0, valor) || vertical(0, 2, valor) || posicionDiagonal(0,0,valor))
            {
                if (Char.ToUpper(valor) == 'X')
                {
                    txtGanador.Text = txtP1.Text;
                    txtGanador.Visible = true;
                }
                else
                {
                    txtGanador.Text = txtP2.Text;
                    txtGanador.Visible = true;
                }
            }
        }
      

    }
      
    }
