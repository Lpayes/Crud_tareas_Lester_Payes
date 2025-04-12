using Clase10L.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoNotas
{
    public partial class FormTareas : Form
    {
        private int accion = 0;
        private bool confirmacionEliminar = false;
        private CrudTareas crud = new CrudTareas();

        public FormTareas()
        {
            InitializeComponent();
        }

        private void buttonAgregarNotaAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarLabelsModoCompleto("Agregar Nota de Alumno");
            HabilitarCampos(true);
            ConfigurarBotonGuardar("Agregar");
            accion = 1;
        }

        private void buttonActualizarNotaAlumno_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarLabelsModoCompleto("Actualizar Nota de Alumno");
            HabilitarCampos(true);
            ConfigurarBotonGuardar("Actualizar");
            accion = 2;
        }

        private void buttonEliminarNotaAlumno_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarLabelsSoloCarnet("Eliminar Nota de Alumno");
            HabilitarSoloCarnet();
            accion = 3;
            confirmacionEliminar = false;
            ConfigurarBotonGuardar("Eliminar");

        }

        private void buttonBuscarNotasAlumno_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarLabelsSoloCarnet("Buscar Notas de Alumno");
            HabilitarSoloCarnet();
            accion = 4;
            ConfigurarBotonGuardar("Buscar");

        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            decimal nota1 = numericUpDownNota1.Value;
            decimal nota2 = numericUpDownNota2.Value;
            decimal nota3 = numericUpDownNota3.Value;
            decimal nota4 = numericUpDownNota4.Value;

            if (!crud.ValidarCarnet(carnet))
                return;

            switch (accion)
            {
                case 1:
                    crud.AgregarNotasAlumno(carnet, nota1, nota2, nota3, nota4);
                    crud.MostrarTareasEnDataGridView(carnet, dataGridViewTareas);
                    LimpiarCampos();
                    break;
                case 2:
                    crud.ActualizarNotasAlumno(carnet, nota1, nota2, nota3, nota4);
                    crud.MostrarTareasEnDataGridView(carnet, dataGridViewTareas);
                    LimpiarCampos();
                    break;
                case 3:
                    if (!confirmacionEliminar)
                    {
                        confirmacionEliminar = true;
                        MessageBox.Show("Presione 'Guardar' nuevamente para confirmar la eliminación.");
                        return;
                    }

                    crud.EliminarNotasAlumno(carnet);
                    crud.MostrarTareasEnDataGridView(carnet, dataGridViewTareas);
                    LimpiarCampos();
                    confirmacionEliminar = false;
                    break;
                case 4:
                    crud.MostrarNotasAlumno(carnet, numericUpDownNota1, numericUpDownNota2, numericUpDownNota3, numericUpDownNota4);
                    crud.MostrarTareasEnDataGridView(carnet, dataGridViewTareas);
                    break;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            accion = 0;
            LimpiarCampos();
        }

        private void HabilitarCampos(bool habilitar)
        {
            textBoxCarnet.Enabled = habilitar;
            numericUpDownNota1.Enabled = habilitar;
            numericUpDownNota2.Enabled = habilitar;
            numericUpDownNota3.Enabled = habilitar;
            numericUpDownNota4.Enabled = habilitar;
        }

        private void HabilitarSoloCarnet()
        {
            textBoxCarnet.Enabled = true;
            numericUpDownNota1.Enabled = false;
            numericUpDownNota2.Enabled = false;
            numericUpDownNota3.Enabled = false;
            numericUpDownNota4.Enabled = false;
        }

        private void LimpiarCampos()
        {
            textBoxCarnet.Clear();
            numericUpDownNota1.Value = 0;
            numericUpDownNota2.Value = 0;
            numericUpDownNota3.Value = 0;
            numericUpDownNota4.Value = 0;
        }

        private void CambiarLabelsModoCompleto(string titulo)
        {
            labelCarnet.Text = "Ingresar Carnet";
            labelNota1.Text = "Ingresar Nota 1";
            labelNota2.Text = "Ingresar Nota 2";
            labelNota3.Text = "Ingresar Nota 3";
            labelNota4.Text = "Ingresar Nota 4";
            labelTituloAccion.Text = titulo;

        }

        private void CambiarLabelsSoloCarnet(string titulo)
        {
            labelCarnet.Text = "Ingresar Carnet";
            labelNota1.Text = "Nota 1";
            labelNota2.Text = "Nota 2";
            labelNota3.Text = "Nota 3";
            labelNota4.Text = "Nota 4";
            labelTituloAccion.Text = titulo;
        }

        private void ConfigurarBotonGuardar(string texto)
        {
            buttonGuardar.Text = texto;
        }
    }
}