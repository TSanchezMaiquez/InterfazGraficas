using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioHerencia
{
    public partial class Form1 : Form
    {
        private List <Cuenta> cuentas = new List<Cuenta>();
        private Cuenta cuenta = new Cuenta();
        private CuentaEmpresa cuentaE = new CuentaEmpresa();
        private double importe = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            int num = comprobarInt(txtMenu.Text);
            if (num> 0)
            {
                switch (num)
                {
                    case 1:
                        limpiarTextBox();
                        grbSelecCuenta.Visible = true;
                        break;
                    case 2:
                        limpiarTextBox();
                        grbConsultas.Visible = true;
                        break;
                    case 3:
                        limpiarTextBox();
                        lblIngreReint.Text = "Ingreso";
                        grbIngRei.Visible = true;
                        break;
                    case 4:
                        limpiarTextBox();
                        lblIngreReint.Text = "Reintegro";
                        grbIngRei.Visible = true;
                        break;
                    case 5:
                        limpiarTextBox();
                        grbTransferencia.Visible = true;
                        break;
                    case 6:
                        Application.Exit();
                        break;
                }
            }else
            {
                lblMenuError.Visible = true;
            }
        }

      
        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            
            cerrarGrupos();
           
                pnlMenu.Visible = true;
            
        }

        private void limpiarTextBox()
        {
           
            txtConsultas.Text = "";
            cbbConsultas.SelectedIndex = -1;
            txtTitular.Text = "";
            txtDni.Text = "";
            txtCuentaO.Text = "";
            txtCuentaD.Text = "";
            txtTransImporte.Text = "";
            txtIngReiNumC.Text = "";
            txtIngReiImporte.Text = "";
            txtMesesFin.Text = "";
            rtbConsultas.Clear();

        }
        private void cerrarGrupos ()
        {
            btnConsultas.Visible = false;
            grbSelecCuenta.Visible = false;
            grbConsultas.Visible = false;
            grbIngRei.Visible = false;
            grbTransferencia.Visible = false;
            grbCreditoSuperado.Visible = false;
            grbMesesCredito.Visible = false;
            lblCuentaCreada.Visible = false;
            lblErrorCrearC.Visible = false;
            lblMenuError.Visible = false;
            lblIngReiError.Visible = false;
            lblErrorCuenta.Visible = false;
            lblTransError.Visible = false;
            lblIngReiEfect.Visible = false;
            lblTRansExito.Visible = false;
            pnlMenu.Visible = false;
            txtConsultas.Visible = false;
    
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string input = txtTitular.Text;
            lblErrorCuenta.Visible=false;
            lblErrorCrearC.Visible = false;

            if (Regex.IsMatch(input, "^[a-zA-ZñÑ\\s]*$"))
            {
                if (rbtCuenta.Checked || rdbCuentaE.Checked)
                {
                    cuenta = rbtCuenta.Checked ? new Cuenta(txtTitular.Text, txtDni.Text) : new CuentaEmpresa(txtTitular.Text, txtDni.Text);
                    cuentas.Add(cuenta);
                    lblCuentaCreada.Visible = true;
                }
                else
                {
                    lblErrorCuenta.Visible = true;
                }
             
            } else
            {
                lblErrorCrearC.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultas.Visible = true;
            btnConsultas.Visible = true;
        }

        private void txtTitular_Click(object sender, EventArgs e)
        {
            lblCuentaCreada.Visible = false;
            lblErrorCrearC.Visible = false;
            txtTitular.Text = "";
            txtDni.Text = "";
            lblIngReiEfect.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            rtbConsultas.Clear();
            String busqueda = cbbConsultas.Text;
            bool encontrado = false;
            for (int i = 0; i < cuentas.Count; i++)
            {
           
                if ( (comprobarString(cuentas[i].Titular, txtConsultas.Text) && cbbConsultas.SelectedIndex == 0) ||
                     (comprobarString(cuentas[i].Dni, txtConsultas.Text) && cbbConsultas.SelectedIndex==1) ){
                        cuenta = cuentas[i];
                        rtbConsultas.AppendText( cuenta.ToString() + Environment.NewLine);
                        encontrado = true;
                 }
              
            }
            if ((encontrado == false))
            {
                rtbConsultas.AppendText("Cuenta no encontrada");
            }
           
        }

        private void btnIngReingreso_Click(object sender, EventArgs e)
        {
            lblIngReiEfect.Visible = false;
            lblIngReiError.Visible = false;

            int num = comprobarInt(txtIngReiNumC.Text);
            cuenta = buscarCuenta(num);
            importe = comprobarDouble(txtIngReiImporte.Text);

            if ( num!=-1 && cuenta!=null && importe!=-1)
            {
                if(comprobarString(txtMenu.Text, "3"))
                {
                    cuenta.Ingreso(importe);
                    lblIngReiEfect.Visible = true;
                         
                    
                }else
                {

                    if (cuenta is CuentaEmpresa)
                    {
                        cuentaE = (CuentaEmpresa)cuenta;
                        if (cuentaE.Reintegro(importe))
                        {
                            lblIngReiEfect.Visible = true;
                        }else
                        {
                            cerrarGrupos();
                            grbCreditoSuperado.Visible = true;
                            txtCredAct.Text = cuentaE.Credito.ToString();
                            txtFinanImp.Text = importe.ToString();
                        }
                    }
                    else
                    {
                        if (cuenta.Reintegro(importe))
                        {
                            lblIngReiEfect.Visible = true;
                        }else
                        {
                            lblIngReiError.Text = "El importe supera al saldo";
                            lblIngReiError.Visible = true;
                        }
                    }   
                    
                }
            }else
            {
                lblIngReiError.Text = "Cuenta no encontrada o importe no valido";
                lblIngReiError.Visible = true;
            }
           
        }
        private Cuenta buscarCuenta (int num)
        {
            Cuenta cuenta = new Cuenta();
           
                for (int i = 0; i < cuentas.Count; i++)
                {
                    if (cuentas[i].NumCuenta == num)
                    {
                        cuenta = cuentas[i];
                        return cuenta;
                    }
                }
            
           
            return cuenta;
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {

            Cuenta cuentaO = new Cuenta();
            Cuenta cuentaD = new Cuenta();
            lblTransError.Visible = false;
            lblTRansExito.Visible = false;


            int cntO = comprobarInt(txtCuentaO.Text);
            int cntD = comprobarInt(txtCuentaD.Text);
            importe = comprobarDouble(txtTransImporte.Text);
            cuentaO = buscarCuenta(cntO);
            cuentaD = buscarCuenta(cntD);

            if(importe != -1)
            {
                if(cuentaO!=null )
                {
                    if (cuentaD != null)
                    {
                        realizarTransferencia(cuentaO, cuentaD, importe);
                    }else
                    {
                        lblTransError.Text = "cuenta destino no encontrada";
                        lblTransError.Visible = true;
                    }
                }else
                {
                    lblTransError.Text = "cuenta origen no encontrada";
                    lblTransError.Visible = true;
                }
            }else
            {
                lblTransError.Text = "Importe no valido";
                lblTransError.Visible = true;
            }
   
        }
        private void realizarTransferencia(Cuenta cuentaO, Cuenta cuentaD, double importe)
        {
            /*creacion de objeto CuentaEmpresa directamente */
            if (cuentaO is CuentaEmpresa cuentaE)
              { 
                 
                  if(cuentaE.Transferencia(cuentaD, importe))
                  {
                      lblTRansExito.Visible = true;
                  }else
                  {
                      cerrarGrupos();
                      grbCreditoSuperado.Visible = true;
                      txtCredAct.Text = cuentaE.Credito.ToString();
                      txtFinanImp.Text = importe.ToString();
                }
              }else
              {
                  if (cuentaO.Transferencia(cuentaD, importe))
                  {
                      lblTRansExito.Visible = true;   
                  }else
                  {
                      lblTransError.Text = "El importe supera al saldo";
                      lblTransError.Visible = true;
                  }
              }
          }
        private int comprobarInt(String text)
        {
            if(int.TryParse(text, out int num))
            {
                return num;
            }
            return -1;
        }
        private double comprobarDouble(String text)
        {
            if (double.TryParse(text, out double num))
            {
                return num;
            }
            return -1;
        }
        private bool comprobarString (String cadena1, String cadena2)
        {
            if (String.Equals(cadena1, cadena2, StringComparison.OrdinalIgnoreCase)){
                return true;
            }
            return false;

        }
        private void btnBorrarC_Click(object sender, EventArgs e)
        {
            txtTitular.Text = "";
            txtDni.Text = "";
            lblErrorCrearC.Visible = false;
            lblErrorCuenta.Visible = false;
            lblCuentaCreada.Visible = false;
            rdbCuentaE.Checked = false;
            rbtCuenta.Checked = false;
           
        }

        private void btnFinanLiq_Click(object sender, EventArgs e)
        {
            cerrarGrupos();
            grbMesesCredito.Visible = true;
            rtbCalcularCuota.Clear();
        }

        private void btnCalcularCuota_Click(object sender, EventArgs e)
        {
            rtbCalcularCuota.Clear();
            double meses = comprobarInt(txtMesesFin.Text);
            if (meses > 0)
            {
                txtMesesFin.Text = "";
                rtbCalcularCuota.AppendText(cuentaE.mostrarCredito(meses));
            }else
            {
                rtbCalcularCuota.AppendText("valor introducido no valido");
            }
        
        }

        private void btnFinanciar_Click(object sender, EventArgs e)
        {
            cuentaE.Credito = (cuentaE.Credito + importe) - cuentaE.TopeCredito;
            string mensaje = "Pago aplazado realizado. Su crédito actualmente es de "+ cuentaE.Credito;
            DialogResult result = MessageBox.Show(mensaje);
            grbMesesCredito.Visible = false;
            pnlMenu.Visible = true;
        }

        private void btnCalcMesesCan_Click(object sender, EventArgs e)
        {
            string mensaje = "Cancelación de importe solicitado";
            DialogResult result = MessageBox.Show(mensaje);
            grbMesesCredito.Visible = false;
            pnlMenu.Visible = true;

        }
    }
}
