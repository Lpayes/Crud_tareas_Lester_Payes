using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase10L.Clases
{
    public class CrudTbAlumnos
    {
        private readonly string connectionString = "Server=LAPTOP-TTSBVU8R\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True;";

        public void MostrarAlumno(string carnet, TextBox textBoxNombre, ComboBox comboBoxSeccion, TextBox textBoxEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM tb_alumnos WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxNombre.Text = reader["estudiante"].ToString();
                        comboBoxSeccion.SelectedItem = reader["seccion"].ToString();
                        textBoxEmail.Text = reader["email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Alumno no encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void MostrarAlumnoEnDataGridView(string carnet, DataGridView dataGridViewAlumnos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT carnet, estudiante, seccion, email FROM tb_alumnos WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    connection.Close();

                    dataGridViewAlumnos.DataSource = dataTable;
                    dataGridViewAlumnos.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void AgregarAlumno(string carnet, string nombre, string seccion, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO tb_alumnos (carnet, estudiante, seccion, email) VALUES (@carnet, @nombre, @seccion, @email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Alumno agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el alumno.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void ActualizarAlumno(string carnet, string nombre, string seccion, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE tb_alumnos SET estudiante = @nombre, seccion = @seccion, email = @email WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Alumno actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el alumno.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public bool ValidarCampos(string carnet, string nombre, string seccion, string email)
        {
            if (string.IsNullOrWhiteSpace(carnet) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(seccion) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }

        public void EliminarAlumno(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM tb_alumnos WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Alumno eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el alumno.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}