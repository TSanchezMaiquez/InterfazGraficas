using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EjercicioWord
{
    public partial class Padre : Form
    {
        private int count = 1;
        public Padre()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoDocumento();
        }
        private void nuevoDocumento()
        {

            Hijo nuevoHijo = new Hijo(this);
            nuevoHijo.MdiParent = this;
            //nuevoHijo.Dock = DockStyle.Fill;
            nuevoHijo.Text += count;
            count++;
            nuevoHijo.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (!string.IsNullOrWhiteSpace(miDocumento.Text))
                {
                    nuevoDocumento();
                    hijoActivo = (Hijo)ActiveMdiChild;

                    miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        miDocumento.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                        string nombreArchivo = Path.GetFileName(openFileDialog.FileName);
                        hijoActivo.Text = nombreArchivo;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debes abrir un documento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guardarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        public void guardarComo()
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                if (!string.IsNullOrWhiteSpace(miDocumento.Text))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            System.IO.File.WriteAllText(saveFileDialog.FileName, miDocumento.Text);
                            MessageBox.Show("Guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hijoActivo.setRutaArchivo(saveFileDialog.FileName);                 
                            hijoActivo.Text = Path.GetFileName(saveFileDialog.FileName);
                            miDocumento.Tag = "Guardado";
                            hijoActivo.setGuardado();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay contenido para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Primero debes abrir un documento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }
        public void guardar()
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                if (hijoActivo.getGuardado())
                {
                    guardarComo();
                    hijoActivo.setGuardado();
                }
                else
                {                  

                    if (!string.IsNullOrWhiteSpace(hijoActivo.getRutaArchivo()))
                    {
                        try
                        {
                            System.IO.File.WriteAllText(hijoActivo.getRutaArchivo(), miDocumento.Text);
                            miDocumento.Tag = "Guardado";
                            MessageBox.Show("Guardado correctamente en: " + hijoActivo.getRutaArchivo(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                         MessageBox.Show("No se ha guardado el archivo previamente. Utiliza 'Guardar como...'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debes abrir un documento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cortar();
        }
        public void cortar()
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                miDocumento.Cut();
            }
        }
        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            copiar();
        }
        public void copiar()
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                miDocumento.Copy();
            }
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pegar();
        }
        public void pegar()
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                miDocumento.Paste();
            }
        }
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                if (miDocumento.CanUndo)
                {
                    miDocumento.Undo();
                }
               
            }          
            
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                if (miDocumento.CanRedo)
                {
                    miDocumento.Redo();
                }

            }
        }
        private void ColorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    if (miDocumento.SelectionLength > 0)
                    {
                        miDocumento.SelectionColor = colorDialog.Color;
                    }
                    else
                    {
                        miDocumento.ForeColor = colorDialog.Color;
                    }
                }
            }

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    if (miDocumento.SelectionLength > 0)
                    {
                        miDocumento.SelectionBackColor = colorDialog.Color;
                    }
                    else
                    {
                        miDocumento.SelectionBackColor = colorDialog.Color;
                    }
                }
            }
        }

        private void colorDeFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    miDocumento.BackColor = colorDialog.Color;
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Hijo hijoActivo = (Hijo)ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                FontDialog fontDialog = new FontDialog();

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    miDocumento.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
