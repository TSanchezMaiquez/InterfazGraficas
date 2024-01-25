using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Cuenta
    {

        private int numCuenta = 0;
        private static int SiguienteNumCuenta = 0;
        private String titular;
        private String dni;
        private double saldo;


        public string Titular { get => titular; set => titular = value; }
        public string Dni { get => dni; set => dni = value; }
        public double NumCuenta { get => numCuenta; }
        public double Saldo { get => saldo; set => saldo = value; }

        public Cuenta()
        {

        }

        public Cuenta(string titular, string dni)
        {
            SiguienteNumCuenta++;
            this.numCuenta = SiguienteNumCuenta;
            this.titular = titular;
            this.dni = dni;
            this.saldo = 0;
        }

        public virtual Boolean Reintegro(double importe)
        {
            if (this.saldo >= importe)
            {
                this.saldo -= importe;
                return true;
            }

            return false;

        }


        public Boolean Ingreso(double importe)
        {
            if (importe > 0)
            {
                this.saldo += importe;
                return true;
            }

            return false;
        }

        public virtual Boolean Transferencia (Cuenta cuenta, double importe) {

            if (this.saldo >= importe)
            {
                this.saldo -= importe;
                cuenta.saldo += importe;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "\nNumero de cuenta: " + numCuenta + "\nTitular: " + titular + "\nDNI: " + dni + "\nSaldo: " + saldo;
        }




    }
}
