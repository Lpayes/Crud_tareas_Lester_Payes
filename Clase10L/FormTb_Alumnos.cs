using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Clase10L.Clases;

namespace Clase10L
{
    public partial class FormTbAlumnos : Form
    {
        private CrudTbAlumnos crud = new CrudTbAlumnos();
        private int opcionGuardar = 0;

        public FormTbAlumnos()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSección.Items.Add("A");
            comboBoxSección.Items.Add("B");
            comboBoxSección.Items.Add("C");

            buttonGuardar.Click += ButtonGuardar_Click;
        }

        private void buttonAgregarAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            opcionGuardar = 1;

            HabilitarCampos(true);
            CambiarLabelsModoCompleto("Agregar Alumno");
            ConfigurarBotonGuardar("Agregar");
        }

        private void buttonActualizarAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            opcionGuardar = 2;

            HabilitarCampos(true);
            CambiarLabelsModoCompleto("Actualizar Alumno");
            ConfigurarBotonGuardar("Actualizar");
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            opcionGuardar = 3;

            HabilitarSoloCarnet();
            CambiarLabelsSoloCarnet("Eliminar Alumno");
            ConfigurarBotonGuardar("Eliminar");
        }

        private void buttonMostrarInformacion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            opcionGuardar = 4;

            HabilitarSoloCarnet();
            CambiarLabelsSoloCarnet("Mostrar Información del Alumno");
            ConfigurarBotonGuardar("Buscar");
        }

        private int contadorEliminar = 0;

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            string nombre = textBoxNombre.Text;
            string seccion = comboBoxSección.SelectedItem != null ? comboBoxSección.SelectedItem.ToString() : "";
            string email = textBoxEmail.Text;

            if (opcionGuardar == 1 || opcionGuardar == 2)
            {
                if (!crud.ValidarCampos(carnet, nombre, seccion, email))
                {
                    return;
                }
            }

            switch (opcionGuardar)
            {
                case 1:
                    crud.AgregarAlumno(carnet, nombre, seccion, email);
                    crud.MostrarAlumnoEnDataGridView(carnet, dataGridViewAlumnos);
                    LimpiarCampos();
                    break;
                case 2:
                    crud.ActualizarAlumno(carnet, nombre, seccion, email);
                    crud.MostrarAlumnoEnDataGridView(carnet, dataGridViewAlumnos);
                    LimpiarCampos();
                    break;
                case 3:
                    if (contadorEliminar == 0)
                    {
                        crud.MostrarAlumno(carnet, textBoxNombre, comboBoxSección, textBoxEmail);

                        if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
                        {
                            MessageBox.Show("El alumno no fue encontrado.");
                            LimpiarCampos();
                            return;
                        }

                        contadorEliminar++;
                        MessageBox.Show($"Se ha encontrado al alumno: {textBoxNombre.Text}, ¿deseas eliminarlo? Haz clic nuevamente para confirmar.");
                        buttonGuardar.Text = "Confirmar eliminación";
                    }
                    else if (contadorEliminar == 1)
                    {
                        crud.EliminarAlumno(carnet);
                        MessageBox.Show("Alumno eliminado con éxito.");
                        LimpiarCampos();
                        contadorEliminar = 0;
                        buttonGuardar.Text = "Eliminar";
                    }
                    crud.MostrarAlumnoEnDataGridView(carnet, dataGridViewAlumnos);
                    break;
                case 4:
                    crud.MostrarAlumno(carnet, textBoxNombre, comboBoxSección, textBoxEmail);
                    crud.MostrarAlumnoEnDataGridView(carnet, dataGridViewAlumnos);
                    LimpiarCampos();
                    break;
                default:
                    MessageBox.Show("Por favor, selecciona una opción válida.");
                    break;
            }
        }

        private void LimpiarCampos()
        {
            textBoxCarnet.Clear();
            textBoxNombre.Clear();
            comboBoxSección.SelectedItem = null;
            textBoxEmail.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void HabilitarCampos(bool habilitar)
        {
            textBoxCarnet.Enabled = habilitar;
            textBoxNombre.Enabled = habilitar;
            textBoxEmail.Enabled = habilitar;
            comboBoxSección.Enabled = habilitar;
        }

        private void HabilitarSoloCarnet()
        {
            textBoxCarnet.Enabled = true;
            textBoxNombre.Enabled = false;
            textBoxEmail.Enabled = false;
            comboBoxSección.Enabled = false;
        }

        private void CambiarLabelsModoCompleto(string titulo)
        {
            labelCarnet.Text = "Ingresar carnet";
            labelNombre.Text = "Ingresar nombre";
            labelSección.Text = "Ingresar sección";
            labelEmail.Text = "Ingresar email";
            labelTitutoFunciones.Text = titulo;
        }

        private void CambiarLabelsSoloCarnet(string titulo)
        {
            labelCarnet.Text = "Ingresar carnet";
            labelNombre.Text = "Nombre";
            labelSección.Text = "Sección";
            labelEmail.Text = "Email";
            labelTitutoFunciones.Text = titulo;
        }

        private void ConfigurarBotonGuardar(string texto)
        {
            buttonGuardar.Text = texto;
        }
    }
}