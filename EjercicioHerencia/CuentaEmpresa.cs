using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class CuentaEmpresa : Cuenta
    {
        private long interes;
        private double credito;
        private int mesesCredito;
        private double topeCredito;

        public long Interes { get => interes; set => interes = value; }
        public double Credito { get => credito; set => credito = value; }
        public int MesesCredito { get => mesesCredito; set => mesesCredito = value; }
        public double TopeCredito { get => topeCredito; set => topeCredito = value; }

        public CuentaEmpresa()
        {

        }

        public CuentaEmpresa(string titular, string dni)
            : base(titular, dni)
        {
            this.interes = 5;
            this.credito = 0;
            this.topeCredito = 6000;
        }

        public override Boolean Reintegro(double importe)
        {
            double diferencia = importe - this.Saldo;
            if (this.Saldo < importe && calcularCredito(diferencia))
            {
                this.Saldo = 0;
                this.Credito += diferencia;
                return true;
            }
            else if(Saldo > importe)
            {
                base.Reintegro(importe);
                return true;
            }
            return false;
        }
        public override Boolean Transferencia(Cuenta cuenta, double importe)
        {
            if (Reintegro(importe))
            {
                cuenta.Saldo += importe;
                return true;
            }
            return false;
        }
        public Boolean calcularCredito(double diferencia)
        {
            double debe = diferencia + credito;
            if(debe <=topeCredito)
            {
                return true;
            }

            return false;
        }

        public String mostrarCredito(double mesesCredito)
        {
            
            double cuota = (this.topeCredito + (this.topeCredito * this.interes / 100)) / mesesCredito;

            return "Interes: "+ Interes + "\nCrédito: "+ Credito + "\nCuota: "+ cuota;

        }

        public override string ToString()
        {
            
            return base.ToString() + "\nInteres: " + Interes + "\nCredito: " + Credito + "\nMeses credito: " + MesesCredito + "\nTope credito: " + TopeCredito;
        }

    }
}
