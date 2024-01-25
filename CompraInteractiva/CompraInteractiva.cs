using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraInteractiva
{
    public partial class CompraInteractiva : Form
    {
        Presupuesto presupuesto = new Presupuesto();
        private string radioButtonSeleccionado;
        private String metodoDePago;
        public CompraInteractiva()
        {
            InitializeComponent();
            inicializarListBox();
        }
        private void radioButtonChecked(object sender, EventArgs e)
        {
            radioButtonSeleccionado = ((RadioButton)sender).Text;

            switch (radioButtonSeleccionado)
            {
                case "Pc (700€)":
                    ptbEquipo.Image = Properties.Resources.pc;
                    presupuesto.Equipo = "pc";
                    break;
                case "Macintosh (1000€)":
                    ptbEquipo.Image = Properties.Resources.mac;
                    presupuesto.Equipo = "macintosh";
                    break;
                case "Portátil (500€)":
                    ptbEquipo.Image = Properties.Resources.por;
                    presupuesto.Equipo = "portatil";
                    break;
            }
            ptbEquipo.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodoDePago = cbbFormaDePago.SelectedItem.ToString();
            switch (metodoDePago)
            {
                case "Tarjeta":
                    ptbFormaDePago.Image = Properties.Resources.tar;
                    presupuesto.Pago = "Tarjeta";
                    break;
                case "Bizum":
                    ptbFormaDePago.Image = Properties.Resources.biz;
                    presupuesto.Pago = "Bizum";
                    break;
                case "PayPal":
                    ptbFormaDePago.Image = Properties.Resources.pay;
                    presupuesto.Pago = "PayPal";
                    break;
            }
            ptbFormaDePago.Visible = true;
        }
        private void CheckBoxEvent(object sender, EventArgs e)
        {
            if (ckb1.Checked)
            {
                ptbContestador.Image = Properties.Resources.cont;
                ptbContestador.Visible = true;
                presupuesto.Oficina[0] = "contestador";
            }else
            {
                ptbContestador.Visible=false;
                presupuesto.Oficina[0] = "";
            }
            if (ckb2.Checked)
            {
                ptbCalculadora.Image = Properties.Resources.cal;
                ptbCalculadora.Visible = true;
                presupuesto.Oficina[1] = "calculadora";
            }
            else
            {
                ptbCalculadora.Visible = false;
                presupuesto.Oficina[1] = "";
            }
            if (ckb3.Checked)
            {
                ptbFotocopiadora.Image = Properties.Resources.fot;
                ptbFotocopiadora.Visible = true;
                presupuesto.Oficina[2] = "fotocopiadora";
            }else
            {
                ptbFotocopiadora.Visible=false;
                presupuesto.Oficina[2] = "";
            }
        }
        private void inicializarListBox ()
        {
            ltbPeriferico.Items.Add("Disco duro adicional (75€)" + Environment.NewLine);
            ltbPeriferico.Items.Add("Impresora (90€)" + Environment.NewLine);
            ltbPeriferico.Items.Add("Antena (50€)" + Environment.NewLine);
        }

        private void ltbPeriferico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = ltbPeriferico.SelectedIndex.ToString();

            switch (elementoSeleccionado)
            {
                case "0":
                    ptbPerifericos.Image = Properties.Resources.dic;
                    presupuesto.Periferico = "disco duro";
                    break;
                case "1":
                    ptbPerifericos.Image = Properties.Resources.imp;
                    presupuesto.Periferico = "impresora";
                    break;
                case "2":
                    ptbPerifericos.Image = Properties.Resources.ant;
                    presupuesto.Periferico = "antena";
                    break;
            }
            ptbPerifericos.Visible = true;
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if( (radioButtonSeleccionado!=null) && (metodoDePago!= null))
            {
                Factura formularioFactura = new Factura(presupuesto);
                this.Hide();
                formularioFactura.ShowDialog();
                this.Show();
            }
            else
            {
                lblObligatorio.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
