using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Toñi
{
    public class Cliente
    {

        private String dniCli;
        private String nombreCli;
        private Boolean bloqueoCli;
        private int claveCli;
        private double saldoCli;

        public Cliente(String dniC, String nombreC, int claveC, double saldoC)
        {
            this.dniCli = dniC;
            this.nombreCli = nombreC;
            this.claveCli = claveC;
            this.saldoCli = saldoC;
            this.bloqueoCli = false;
        }

        public string DniCli { get => dniCli; set => dniCli = value; }
        public string NombreCli { get => nombreCli; set => nombreCli = value; }
        public bool BloqueoCli { get => bloqueoCli; set => bloqueoCli = value; }
        public int ClaveCli { get => claveCli; set => claveCli = value; }
        public double SaldoCli { get => saldoCli; set => saldoCli = value; }
    }
}
