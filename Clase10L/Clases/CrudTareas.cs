using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase10L.Clases
{
    public class CrudTareas
    {
        private readonly string connectionString = "Server=LAPTOP-TTSBVU8R\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True;";

        public void MostrarNotasAlumno(string carnet, NumericUpDown nota1, NumericUpDown nota2, NumericUpDown nota3, NumericUpDown nota4)
        {
            if (!ValidarCampos(carnet)) return;

            MessageBox.Show("Ejecutando búsqueda de notas...");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Tareas WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nota1.Value = Convert.ToDecimal(reader["nota1"]);
                        nota2.Value = Convert.ToDecimal(reader["nota2"]);
                        nota3.Value = Convert.ToDecimal(reader["nota3"]);
                        nota4.Value = Convert.ToDecimal(reader["nota4"]);
                        MessageBox.Show("Notas cargadas correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron notas para el carnet ingresado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar las notas: " + ex.Message);
                }
            }
        }

        public void MostrarTareasEnDataGridView(string carnet, DataGridView dataGridViewTareas)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT carnet, nota1, nota2, nota3, nota4 FROM tareas WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    connection.Close();

                    dataGridViewTareas.DataSource = dataTable;
                    dataGridViewTareas.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar las tareas del alumno: " + ex.Message);
                }
            }
        }

        public void AgregarNotasAlumno(string carnet, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            if (!ValidarCampos(carnet)) return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Tareas (carnet, nota1, nota2, nota3, nota4) VALUES (@carnet, @nota1, @nota2, @nota3, @nota4)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Notas agregadas correctamente." : "No se pudieron agregar las notas.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar notas: " + ex.Message);
                }
            }
        }


        public void ActualizarNotasAlumno(string carnet, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            if (!ValidarCampos(carnet)) return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Tareas SET nota1 = @nota1, nota2 = @nota2, nota3 = @nota3, nota4 = @nota4 WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Notas actualizadas correctamente." : "No se encontraron registros para actualizar.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar notas: " + ex.Message);
                }
            }
        }

        public bool ValidarCarnet(string carnet)
        {
            if (string.IsNullOrWhiteSpace(carnet))
            {
                MessageBox.Show("Por favor, ingrese el número de carnet.");
                return false;
            }
            return true;
        }

        public void EliminarNotasAlumno(string carnet)
        {
            if (!ValidarCampos(carnet)) return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Tareas WHERE carnet = @carnet";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Notas eliminadas correctamente." : "No se encontraron registros para eliminar.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar notas: " + ex.Message);
                }
            }
        }

        private bool ValidarCampos(string carnet)
        {
            if (string.IsNullOrWhiteSpace(carnet))
            {
                MessageBox.Show("Debe ingresar el carnet del alumno.");
                return false;
            }
            return true;
        }
    }
}