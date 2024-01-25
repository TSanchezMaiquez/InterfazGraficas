using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploBBDD
{
    public partial class Form1 : Form
    {
        SqlConnection miConexionSql;
        String conexionString;
        public Form1()
        {
            InitializeComponent();
            conexionString = Properties.Settings.Default.conexion;
            miConexionSql = new SqlConnection(conexionString);
           
        }

        private void cargarDatos()
        {
            try
            {
                miConexionSql.Open();
                String query = "Select * from Animal";
                SqlCommand cmd = new SqlCommand(query, miConexionSql);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    dataTable.Load(reader);

                    dataGridView1.DataSource = dataTable;
                    miConexionSql.Close();
                }else
                {
                    MessageBox.Show("No se encontraron datos");
                }

                reader.Close();
            }
            catch(Exception ex) { 
                MessageBox.Show("Error "+ex.Message);
            }
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            cargarDatos2();
        }

        private void cargarDatos2()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexionString))
                {
                    connection.Open();

                    string query = "Select * from Animal";
                    //Permite hace modificaciones
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if(dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No se encuentran datos");
                        }
                        connection.Close();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error "+ ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
