using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private List<Button> listaBotones;
        private Boolean encendida = false;
        private double operador1 = 0;
        private double operador2 = 0;
        private bool comaPulsada= false;
        private int count = 0;
        private String primerOperadorPulsado = "";
        private String segundoOperadorPulsado = "";
        private Boolean ultimoBotonPulsadoFueOperador = false;
        private Boolean anteriorBotonPulsadoFueIgual = false;
        private int countIgual = 0;
        private double operadorSegundo = 0;
        private Boolean signoCambiado = false;



        public Form1()
        {
            InitializeComponent();
            InicializarListaBotones();
            bloquearBotones();
        }
        private void InicializarListaBotones()
        {
            /*Lista que utilizo para apagar y encender la calculadora*/
            listaBotones = new List<Button>
                {
                    btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
                    btnSigno, btnComa, btnLimpiar, btnIgual, btnSumar, btnRestar, btnDividir, btnMultiplicar
                };
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
           
            if(!encendida)
            {
                desbloquearBotones();              
            }else
            {
                bloquearBotones();              
            }         
        }       
        private void bloquearBotones()
        {
            foreach (Button boton in listaBotones)
            {
                boton.Enabled = false;                
            }
            encendida = false;
            btnEncender.Text = "On";
            txtResultado.Text = "";
            rtbHirtorial.Clear();
        }

        private void desbloquearBotones()
        {
            foreach (Button boton in listaBotones)
            {
                boton.Enabled = true;                        
            }
            //Reinicio de variables
            txtResultado.Text = "0";
            encendida = true;
            btnEncender.Text = "Off";
            operador1 = 0;
            operador2 = 0;
            countIgual = 0;
            count = 0;
            operadorSegundo = 0;
            comaPulsada = false;
            ultimoBotonPulsadoFueOperador = false;
            anteriorBotonPulsadoFueIgual = false;
            primerOperadorPulsado = "";
            segundoOperadorPulsado = "";
            signoCambiado = false;
            
        }
        //Control de numeros pulsados
        private void numeroPulsado(object sender, EventArgs e)
        {
            String botonPulsado = ((Button)sender).Text;
            numeroPulsado1(botonPulsado);
                 
           
        }
        private void numeroPulsado1 (String botonPulsado)
        {
            //Si pulsamos la tecla 0 o cualquier otro numero despues de haber pulsado igual
            //Reiniciamos pantalla, operadores y contadores
            if (String.Equals(txtResultado.Text, "0") || anteriorBotonPulsadoFueIgual)
            {
                //Esta variable diferencia si el boton igual ha sido pulsado solo una vez o varias veces seguidas
                anteriorBotonPulsadoFueIgual = false;
                txtResultado.Text = botonPulsado;
                rtbHirtorial.Text = "\n" + botonPulsado;
                operador1 = 0;
                operador2 = 0;
                //Esta variable sirve para saber si es la primera vez que se ha pulsado un operador desde eñ reinicio o el arranque
                count = 0;
                countIgual = 0;

            }
            else
            {   //Si se cumple se reinicia la pantalla con el nuevo numero pulsado
                if (ultimoBotonPulsadoFueOperador)
                {
                    rtbHirtorial.Text += botonPulsado; 
                    txtResultado.Text = botonPulsado;
                    ultimoBotonPulsadoFueOperador = false;
                }
                else
                {
                    txtResultado.Text += botonPulsado;
                    rtbHirtorial.Text += botonPulsado;
                }
            }
        }
        // btnComa_Click: Manejo de la coma decimal
        private void btnComa_Click(object sender, EventArgs e)
        {
            
            if (ultimoBotonPulsadoFueOperador)
            {
                // Si el último botón pulsado fue un operador, inicia la pantalla con "0,"
                txtResultado.Text = "0,";
                rtbHirtorial.Text = "\n0,";
                ultimoBotonPulsadoFueOperador = false;
                comaPulsada = true;
            }
            if (anteriorBotonPulsadoFueIgual)
            {
                // Si el botón anterior fue "=", inicia la pantalla con "0,"
                txtResultado.Text = "0,";
                rtbHirtorial.Text = "\n0,";
                anteriorBotonPulsadoFueIgual = false;
                operador1 = 0;
                operador2 = 0;
                comaPulsada = true;
            }
            
            if(String.Equals(txtResultado.Text, "") && !comaPulsada)
            {

            }else
            {
                // Si no se ha pulsado coma previamente, agrega la coma a pantalla
                if (!comaPulsada)
                {
                    txtResultado.Text += ",";
                    rtbHirtorial.Text += ",";
                    comaPulsada = true;
                }
            }                    
        }
        //Reinicio de variables y pantalla al pulsar el boton C
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rtbHirtorial.Clear();
            txtResultado.Text = "0";
            operador1 = 0;
            operador2 = 0;
            operadorSegundo = 0;
            countIgual = 0;
            count = 0;
            comaPulsada = false;
            anteriorBotonPulsadoFueIgual = false;
            signoCambiado = false;
        }
        //Invierte el signo del número actual
        private void btnSigno_Click(object sender, EventArgs e)
        {            
            string resultado = txtResultado.Text;
            
            char primerCaracter = resultado[0];
            if(primerCaracter == '-')
            {          
                // Si el primer carácter es "-", quita el signo negativo
                resultado = resultado.Substring(1);
                txtResultado.Text = resultado;
                rtbHirtorial.Text += resultado;
                signoCambiado = true;
                if (operador1 != 0 && ultimoBotonPulsadoFueOperador)
                {
                    // Actualiza operador1 si el último botón fue un operador
                    operador1 = double.Parse(txtResultado.Text);
                }
                else
                {
                    // Actualiza operador2 si no fue un operador el último pulsado
                    operador2 = double.Parse(txtResultado.Text);
                }

            }
            else
            {
                // Si no tiene signo, agrega el signo negativo
                txtResultado.Text = "-" + resultado;
                if (operador1 != 0 && ultimoBotonPulsadoFueOperador)
                {
                    // Actualiza operador1 si el último botón fue un operador
                    operador1 = double.Parse(txtResultado.Text);
                }else
                {
                    // Actualiza operador2 si no fue un operador el último pulsado
                    operador2 = double.Parse(txtResultado.Text);
                }            
            }
            
        }
        //Control del botón igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
          
            comaPulsada = false;
            double resultado = 0;

            if (countIgual == 0)
            {
                // Si es la primera vez que se pulsa "="
                operador2 = double.Parse(txtResultado.Text);
                operadorSegundo = operador2;
                resultado = HacerOperacion(operador2);
                rtbHirtorial.Text += " = "+resultado + "\n";
                countIgual++;
            }
            else
            {
              
                // Si se pulsa "=" nuevamente, realiza la operación usando operadorSegundo
                resultado = HacerOperacion(operadorSegundo);
                rtbHirtorial.Text += "\n"+operador1.ToString() + primerOperadorPulsado + operadorSegundo.ToString() + " = " + resultado;
            }

            txtResultado.Text = resultado.ToString();
            redondear(resultado);
            operador1 = double.Parse(txtResultado.Text);
            anteriorBotonPulsadoFueIgual = true;
        }
      
        // Control de operadores 
        private void btnOperacionPulsado(object sender, EventArgs e)
        {
            String operacion = ((Button)sender).Text;
            this.operacion(operacion);
        }
        private void operacion (String operacion)
        {
            comaPulsada = false;
            if (anteriorBotonPulsadoFueIgual)
            {
                // Si el botón anterior fue "=", se reiniciaron pantalla y operadores, y guarda el operador en primerOperadorPulsado 
                primerOperadorPulsado = operacion;
                anteriorBotonPulsadoFueIgual = false;
                operador1 = double.Parse(txtResultado.Text);
                if (signoCambiado)
                {
                    rtbHirtorial.Text += primerOperadorPulsado;
                }else
                {
                    rtbHirtorial.Text += operador1 + primerOperadorPulsado;
                }
                countIgual = 0;
            }
            else
            {
                if (!ultimoBotonPulsadoFueOperador)
                {
                    segundoOperadorPulsado = operacion;
                    //rtbHirtorial.Text += operacion;

                    if (count == 0)
                    {
                        // Si es la primera vez que se pulsa un operador, asigna el operador como primerOperador
                        primerOperadorPulsado = operacion;
                        rtbHirtorial.Text += operacion;
                        count++;
                    }

                    if (String.Equals(txtResultado.Text, ""))
                    {
                        txtResultado.Text = "0";
                    }
                    else
                    {
                        if (operador1 == 0)
                        {
                            // Si operador1 es cero, asigna el número actual como operador1
                            operador1 = double.Parse(txtResultado.Text);
                        }
                        else
                        {
                            // Si operador1 ya tiene un valor, realiza la operación con operador2
                            operador2 = double.Parse(txtResultado.Text);
                            double resultado = HacerOperacion(operador2);
                            rtbHirtorial.Text += " = " + resultado + "\n";
                            txtResultado.Text = resultado.ToString();
                            redondear(resultado);
                            rtbHirtorial.Text += txtResultado.Text+ segundoOperadorPulsado;
                            primerOperadorPulsado = segundoOperadorPulsado;

                        }
                    }

                }
                else
                {
                    // Si el último botón pulsado fue un operador, actualiza primerOperador
                    primerOperadorPulsado = operacion;

                }
            }
            ultimoBotonPulsadoFueOperador = true;
        }
        //Redondea el número a dos decimales y actualiza el texto en el cuadro de resultado
        private void redondear(double num)
        {
            // Redondea el número a dos decimales
            double resultadoRedondeado = Math.Round(num, 2);
            txtResultado.Text = resultadoRedondeado.ToString();
            // Actualiza operador1 con el número redondeado y reinicia operador2 a cero
            operador1 = resultadoRedondeado;
            operador2 = 0;
        }
        //Realiza la operación según el operador previamente seleccionado
        private double HacerOperacion(double num)
        {
            double operacion = 0;
            switch (primerOperadorPulsado)
            {
                case "+":
                    operacion = operador1 + num;
                    break;
                case "-":
                    operacion = operador1 - num;
                    break;
                case "X":         
                case "*":
                    operacion = operador1 * num;
                    break;
                case "/":
                    operacion = operador1 / num;
                    break;
            }
            return operacion;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evito que se pueda escribit en pantalla si esta esta apagada
            if(String.Equals(btnEncender.Text, "Off")){
                if (char.IsDigit(e.KeyChar))
                {
                    // La tecla presionada es un número
                    string numeroPresionado = e.KeyChar.ToString();
                    numeroPulsado1(numeroPresionado);
                }
                else if (EsOperador(e.KeyChar))
                {
                    // La tecla presionada es un operador
                    string teclaOperador = e.KeyChar.ToString();
                    operacion(teclaOperador);
                }
                else if (e.KeyChar == '=')
                {
                    btnIgual.PerformClick();
                   
                }
            }           
        }
        private bool EsOperador(char c)
        {
            // Verifica si el carácter es uno de los operadores comunes
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
