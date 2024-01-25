using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWord
{
    public partial class Hijo : Form
    {
        private bool nuncaGuardado = true;
        private String rutaArchivo = "";
        Padre padre = new Padre();
        public Hijo(Padre padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            rtbDocumento.Tag = "No guardado";
        }

        public void setGuardado()
        {
            nuncaGuardado = false;
        }
        public bool getGuardado()
        {
            return nuncaGuardado;
        }
        public void setRutaArchivo(String ruta)
        {
            rutaArchivo = ruta;
        }
        public String getRutaArchivo()
        {
            return rutaArchivo;
        }

        private void Hijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (rtbDocumento != null && !string.IsNullOrEmpty(rtbDocumento.Text) && rtbDocumento.Modified && rtbDocumento.Tag.Equals("No guardado"))
                {
                    DialogResult result = MessageBox.Show("Cambios sin guardar en " + this.Text + ". ¿Deseas guardar antes de cerrar?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (this.getGuardado())
                            {
                                padre.guardarComo();
                                this.setGuardado();
                            }
                            else
                            {
                                this.Activate();
                                padre.guardar();
                            }
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            return;
                    }
                }
            
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            padre.cortar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            padre.copiar();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            padre.pegar();
        }
    }
}
