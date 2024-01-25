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

namespace mdi
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private string rutaArchivoGuardado;
        private bool nuncaGuardado = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoDocumento();
        }
        private void nuevoDocumento()
        {
            frmHijo nuevoHijo = new frmHijo();
            nuevoHijo.MdiParent = this;
            nuevoHijo.Dock = DockStyle.Fill;
            nuevoHijo.Text += count;
            count++;
            nuevoHijo.Show();
        }
        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            Form hijoActivo = this.ActiveMdiChild;
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hijoActivo = this.ActiveMdiChild;
            RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            miDocumento.BackColor = colorDialog.Color;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.ActiveMdiChild != null)
            {
                Form hijoActivo = this.ActiveMdiChild;
                RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (!string.IsNullOrWhiteSpace(miDocumento.Text))
                {
                    nuevoDocumento();
                    hijoActivo = this.ActiveMdiChild;
                    
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
        private void guardarComo()
        {
            if (this.ActiveMdiChild != null)
            {
                Form hijoActivo = this.ActiveMdiChild;
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
                            rutaArchivoGuardado = saveFileDialog.FileName;
                            hijoActivo.Text = Path.GetFileName(saveFileDialog.FileName);
                            miDocumento.Tag = "Guardado";
                            nuncaGuardado = false;
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
        private void guardar()
        {
            if (this.ActiveMdiChild != null)
            {
                if (nuncaGuardado)
                {
                    guardarComo();
                    nuncaGuardado = false;
                }
                else
                {
                    Form hijoActivo = this.ActiveMdiChild;
                    RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;

                    if (!string.IsNullOrWhiteSpace(rutaArchivoGuardado))
                    {
                        try
                        {
                            System.IO.File.WriteAllText(rutaArchivoGuardado, miDocumento.Text);
                            miDocumento.Tag = "Guardado";
                            MessageBox.Show("Guardado correctamente en: " + rutaArchivoGuardado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si rutaArchivoGuardado es una cadena vacía, es posible que el archivo aún no se haya guardado correctamente.
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form hijoActivo = this.ActiveMdiChild;
            RichTextBox miDocumento = (RichTextBox)hijoActivo.ActiveControl;
           
            if (miDocumento.Tag.Equals("No guardado"))
            {
                DialogResult result = MessageBox.Show("Cambios sin guardar, ¿deseas guardar antes de cerrar?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (nuncaGuardado)
                        {
                            guardarComo();
                            nuncaGuardado = false;
                        }else
                        {
                            guardar();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }


            }
        }
    }
}
