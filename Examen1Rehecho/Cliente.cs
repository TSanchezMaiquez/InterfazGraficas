using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Rehecho
{
    public class Cliente
    {

        private String dniCli;
        private String nombreCli;
        private bool bloqueoCli;
        private int claveCli;
        private double saldoCli;

        public Cliente(string dniCli, string nombreCli, int claveCli, double saldoCli)
        {
            this.dniCli = dniCli;
            this.nombreCli = nombreCli;
            this.bloqueoCli = false;
            this.claveCli = claveCli;
            this.saldoCli = saldoCli;
        }

        public string DniCli { get => dniCli; set => dniCli = value; }
        public string NombreCli { get => nombreCli; set => nombreCli = value; }
        public bool BloqueoCli { get => bloqueoCli; set => bloqueoCli = value; }
        public int ClaveCli { get => claveCli; set => claveCli = value; }
        public double SaldoCli { get => saldoCli; set => saldoCli = value; }

        public override string ToString()
        {
            return "--Datos cliente--\nDni: " + dniCli + "\nNombre: " +nombreCli+ "\nSaldo: " + saldoCli;
        }
    }
}
