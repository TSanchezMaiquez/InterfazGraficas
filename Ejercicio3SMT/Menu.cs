using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3SMT
{
    public partial class Menu : Form
    {
        private Alumno[] alumnos = new Alumno[3];
        private int contador = 0;
        private long tel;
        struct Alumno
        {
            public int codAlum;
            public String nomAlum;
            public String apellAlum;
            public long telfAlum;
            public String emailAlum;
            public String cursoAlum;
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtOpcion.Text, out int num))
            {
                switch (num)
                {
                    case 1:
                        pnlAltas.Visible = true;
                        break;
                    case 2:
                        pnlConsultas.Visible = true;
                        break;
                    case 3:
                        ltbAlumnos.Items.Clear();
                        ListarAlumno();
                        pnlListar.Visible = true;
                        break;
                    case 4:
                        ltbOrdenarAlumnos.Items.Clear();
                        mostrarAlumno(ltbOrdenarAlumnos, -1);
                        pnlOrdenar.Visible = true;
                        break;
                    case 5:
                        Application.Exit();
                        break;
                    default:
                        Application.Exit();
                        break;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlAltas.Visible = false;
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.Black;
            lblUsuCreado.Visible = false;
        }
        private void txtApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            txtApellidos.Text = "";
            txtApellidos.ForeColor = Color.Black;
        }

        private void txtTelefono_MouseClick(object sender, MouseEventArgs e)
        {
            txtTelefono.Text = "";
            txtTelefono.ForeColor = Color.Black;
        }


        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.Black;

        }


        private void txtCurso_MouseClick(object sender, MouseEventArgs e)
        {
            txtCurso.Text = "";
            txtCurso.ForeColor = Color.Black;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comprobarDatosUsuario())
            {
                insertarAlumno();
                reiniciarCamposAltas();
                btbOrdenar.Enabled = true;
            }
            else
            {
                lblError.Visible = true;
            }

            if (contador == 3)
            {
                btnGuardar.Enabled = false;
                lblMaximo.Visible = true;
            }
        }
        private void insertarAlumno()
        {
            alumnos[contador].codAlum = contador + 1;
            alumnos[contador].nomAlum = txtNombre.Text;
            alumnos[contador].apellAlum = txtApellidos.Text;
            alumnos[contador].telfAlum = tel;
            alumnos[contador].emailAlum = txtEmail.Text;
            alumnos[contador].cursoAlum = txtCurso.Text;
            contador++;
            lblUsuCreado.Visible = true;
        }
        private Boolean comprobarDatosUsuario()
        {

            String nombre = txtNombre.Text;
            bool nValido = Regex.IsMatch(nombre, "^[a-zA-ZñÑ]+$");

            string telefono = txtTelefono.Text;
            bool tValido = Regex.IsMatch(telefono, @"^\d{9}$");

            string email = txtEmail.Text;
            bool eValido = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-ZñÑ]{2,}$");

            if (!nValido || !Int64.TryParse(txtTelefono.Text, out tel) || string.IsNullOrWhiteSpace(txtApellidos.Text) || !tValido || !eValido || string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                return false;
            }

            return true;

        }

        private void reiniciarCamposAltas()
        {
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Text = "No se admiten números";
            txtApellidos.ForeColor =Color.Gray;
            txtApellidos.Text = "No puede quedar vacio";
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Text = "Introduce 9 números";
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Text = "ejemplo@dominio.com";
            txtCurso.ForeColor = Color.Gray;
            txtCurso.Text = "No puede quedar vacio";

        }

        private void btnConsultasAtras_Click(object sender, EventArgs e)
        {
            pnlConsultas.Visible = false;
            ltbResultado.Items.Clear();
        }

        private void btnConsultasBuscar_Click(object sender, EventArgs e)
        {
            if (contador == 0 || string.IsNullOrWhiteSpace(txtConsultasN.Text))
            {
                ltbResultado.Items.Clear();
                ltbResultado.Items.Add("No hay usuarios registrados y/o no ha introducido un nombre");
            }
            else
            {
                ltbResultado.Items.Clear();
                string nombre = txtConsultasN.Text;
                bool alumnoEncontrado = false;
                int posicion = -1;

                for (int i = 0; i < alumnos.Length; i++)
                {

                    if (alumnos[i].nomAlum != null && alumnos[i].nomAlum.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {

                        alumnoEncontrado = true;
                        posicion = i;
                        break;
                    }
                }

                if (alumnoEncontrado)
                {
                    mostrarAlumno(ltbResultado, posicion);

                }
                else
                {
                    ltbResultado.Items.Add("Alumno no encontrado");
                }

            }

        }

        private void ListarAlumno()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i].nomAlum != null)
                {
                    ltbAlumnos.Items.Add("Codigo alumno: " + alumnos[i].codAlum
                   + ". Nombre: " + alumnos[i].nomAlum + ". Apellidos: " + alumnos[i].apellAlum
                   + ". Teléfono: " + alumnos[i].telfAlum + ". Email: " + alumnos[i].emailAlum
                   + ". Curso: " + alumnos[i].cursoAlum);
                }

            }
        }

        private void btnAtrasL_Click(object sender, EventArgs e)
        {
            pnlListar.Visible = false;
        }
        private void mostrarAlumno(ListBox ltb, int posicion)
        {
            if (posicion == -1)
            {
                for (int i = 0; i < alumnos.Length; i++)
                {
                    if (alumnos[i].nomAlum != null)
                    {           
                        ltb.Items.Add("----- Datos del alumno -----");
                        ltb.Items.Add("Codigo alumno: " + alumnos[i].codAlum);
                        ltb.Items.Add("Nombre: " + alumnos[i].nomAlum);
                        ltb.Items.Add("Apellidos: " + alumnos[i].apellAlum);
                        ltb.Items.Add("Teléfono: " + alumnos[i].telfAlum);
                        ltb.Items.Add("Email: " + alumnos[i].emailAlum);
                        ltb.Items.Add("Curso: " + alumnos[i].cursoAlum);
                    }
                        
                }
            }
            else
            {
                ltb.Items.Add("----- Datos del alumno -----");
                ltb.Items.Add("Codigo alumno: " + alumnos[posicion].codAlum);
                ltb.Items.Add("Nombre: " + alumnos[posicion].nomAlum);
                ltb.Items.Add("Apellidos: " + alumnos[posicion].apellAlum);
                ltb.Items.Add("Teléfono: " + alumnos[posicion].telfAlum);
                ltb.Items.Add("Email: " + alumnos[posicion].emailAlum);
                ltb.Items.Add("Curso: " + alumnos[posicion].cursoAlum);
            }

        }

        private void btbOrdenar_Click(object sender, EventArgs e)
        {
            ltbOrdenarAlumnos.Items.Clear();

            // Crear una copia de alumnos y ordenar la copia
            Alumno[] copiaAlumnos = new Alumno[contador];
            Array.Copy(alumnos, copiaAlumnos, contador);
            Array.Sort(copiaAlumnos, (a, b) => a.apellAlum.CompareTo(b.apellAlum));
            Array.Copy(copiaAlumnos, alumnos, contador);

            // Mostrar la copia ordenada
            for (int i = 0; i < copiaAlumnos.Length; i++)
            {
                
                    mostrarAlumno(ltbOrdenarAlumnos, i);
                
            }
            btbOrdenar.Enabled = false;

        }
        private class ComparadorAlumnoPorApellido : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return x.apellAlum.CompareTo(y.apellAlum);
            }
        }

        private void btnAtrasOrdenar_Click(object sender, EventArgs e)
        {
            pnlOrdenar.Visible = false;
        }
    }

       
}
