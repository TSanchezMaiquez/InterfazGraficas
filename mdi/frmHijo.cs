using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class frmHijo : Form
    {
        private bool nuncaGuardado = true;
        private String rutaArchivo = "";
        public frmHijo()
        {
            InitializeComponent();
        }       

        private void rtbDocumento_TextChanged(object sender, EventArgs e)
        {
            rtbDocumento.Tag = "No guardado";
        }
        private void setGuardado(bool guardado)
        {
            nuncaGuardado = guardado;
        }
        private void setRutaArchivo (String ruta)
        {
            rutaArchivo = ruta;
        }
        private String getRutaArchivo()
        {
            return rutaArchivo;
        }
    }
}
