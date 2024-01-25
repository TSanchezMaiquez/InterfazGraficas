using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompraInteractiva
{
    
    public class Presupuesto
    {
        private String equipo;
        private String pago;
        private String [] oficina = {"", "", ""};
        private String periferico ="";
        

        public string Equipo { get => equipo; set => equipo = value; }
        public string Pago { get => pago; set => pago = value; }
        public string Periferico { get => periferico; set => periferico = value; }
        public string[] Oficina { get => oficina; set => oficina = value; }

        
    } 
}
