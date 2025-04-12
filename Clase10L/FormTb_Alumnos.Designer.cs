namespace Clase10L
{
    partial class FormTbAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTbAlumnos));
            this.buttonAgregarAlumno = new System.Windows.Forms.Button();
            this.buttonActualizarAlumno = new System.Windows.Forms.Button();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.buttonMostrarInformacion = new System.Windows.Forms.Button();
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSección = new System.Windows.Forms.Label();
            this.comboBoxSección = new System.Windows.Forms.ComboBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitutoFunciones = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.panelEncabezado.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarAlumno
            // 
            this.buttonAgregarAlumno.BackColor = System.Drawing.Color.Beige;
            this.buttonAgregarAlumno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarAlumno.Location = new System.Drawing.Point(30, 148);
            this.buttonAgregarAlumno.Name = "buttonAgregarAlumno";
            this.buttonAgregarAlumno.Size = new System.Drawing.Size(177, 76);
            this.buttonAgregarAlumno.TabIndex = 0;
            this.buttonAgregarAlumno.Text = "Agregar Alumno";
            this.buttonAgregarAlumno.UseVisualStyleBackColor = false;
            this.buttonAgregarAlumno.Click += new System.EventHandler(this.buttonAgregarAlumno_Click);
            // 
            // buttonActualizarAlumno
            // 
            this.buttonActualizarAlumno.BackColor = System.Drawing.Color.Beige;
            this.buttonActualizarAlumno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarAlumno.Location = new System.Drawing.Point(30, 258);
            this.buttonActualizarAlumno.Name = "buttonActualizarAlumno";
            this.buttonActualizarAlumno.Size = new System.Drawing.Size(177, 76);
            this.buttonActualizarAlumno.TabIndex = 1;
            this.buttonActualizarAlumno.Text = "Actualizar Alumno";
            this.buttonActualizarAlumno.UseVisualStyleBackColor = false;
            this.buttonActualizarAlumno.Click += new System.EventHandler(this.buttonActualizarAlumno_Click);
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.BackColor = System.Drawing.Color.Beige;
            this.buttonEliminarAlumno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(30, 368);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(177, 76);
            this.buttonEliminarAlumno.TabIndex = 2;
            this.buttonEliminarAlumno.Text = "Eliminar Alumno";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = false;
            this.buttonEliminarAlumno.Click += new System.EventHandler(this.buttonEliminarAlumno_Click);
            // 
            // buttonMostrarInformacion
            // 
            this.buttonMostrarInformacion.BackColor = System.Drawing.Color.Beige;
            this.buttonMostrarInformacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarInformacion.Location = new System.Drawing.Point(30, 479);
            this.buttonMostrarInformacion.Name = "buttonMostrarInformacion";
            this.buttonMostrarInformacion.Size = new System.Drawing.Size(177, 76);
            this.buttonMostrarInformacion.TabIndex = 3;
            this.buttonMostrarInformacion.Text = "Mostrar Información de Alumno";
            this.buttonMostrarInformacion.UseVisualStyleBackColor = false;
            this.buttonMostrarInformacion.Click += new System.EventHandler(this.buttonMostrarInformacion_Click);
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet.Location = new System.Drawing.Point(303, 197);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(62, 19);
            this.labelCarnet.TabIndex = 4;
            this.labelCarnet.Text = "Carnet";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(303, 260);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(71, 19);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(307, 324);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 19);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelSección
            // 
            this.labelSección.AutoSize = true;
            this.labelSección.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSección.Location = new System.Drawing.Point(307, 396);
            this.labelSección.Name = "labelSección";
            this.labelSección.Size = new System.Drawing.Size(71, 19);
            this.labelSección.TabIndex = 7;
            this.labelSección.Text = "Sección";
            // 
            // comboBoxSección
            // 
            this.comboBoxSección.FormattingEnabled = true;
            this.comboBoxSección.Location = new System.Drawing.Point(485, 391);
            this.comboBoxSección.Name = "comboBoxSección";
            this.comboBoxSección.Size = new System.Drawing.Size(55, 24);
            this.comboBoxSección.TabIndex = 8;
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(485, 197);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(220, 22);
            this.textBoxCarnet.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(485, 259);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(309, 22);
            this.textBoxNombre.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(485, 323);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(309, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Beige;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(340, 458);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(200, 80);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Beige;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(546, 458);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(200, 80);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 95);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bienvenido al Sistema  de Estudiantes (UMG)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Location = new System.Drawing.Point(2, 2);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(828, 92);
            this.panelEncabezado.TabIndex = 16;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Controls.Add(this.buttonAgregarAlumno);
            this.panelLateral.Controls.Add(this.buttonActualizarAlumno);
            this.panelLateral.Controls.Add(this.buttonEliminarAlumno);
            this.panelLateral.Controls.Add(this.buttonMostrarInformacion);
            this.panelLateral.Location = new System.Drawing.Point(2, 94);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(254, 604);
            this.panelLateral.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 125);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccione la acción que deseas realizar haciendo clic en un botón";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bienvenido al Sistema  de Estudaintes (UMG)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 95);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(828, 95);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gracias Por Utilizar el Sistema de Estudiantes (UMG)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitutoFunciones
            // 
            this.labelTitutoFunciones.BackColor = System.Drawing.Color.Gold;
            this.labelTitutoFunciones.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitutoFunciones.Location = new System.Drawing.Point(262, 97);
            this.labelTitutoFunciones.Name = "labelTitutoFunciones";
            this.labelTitutoFunciones.Size = new System.Drawing.Size(568, 75);
            this.labelTitutoFunciones.TabIndex = 18;
            this.labelTitutoFunciones.Text = "Agregar, Actualizar, Eliminar y Mostrar Información de Alumno";
            this.labelTitutoFunciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(283, 558);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 24;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(527, 91);
            this.dataGridViewAlumnos.TabIndex = 19;
            // 
            // FormTbAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(831, 789);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.labelTitutoFunciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.comboBoxSección);
            this.Controls.Add(this.labelSección);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCarnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTbAlumnos";
            this.Text = "FormTb_Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEncabezado.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarAlumno;
        private System.Windows.Forms.Button buttonActualizarAlumno;
        private System.Windows.Forms.Button buttonEliminarAlumno;
        private System.Windows.Forms.Button buttonMostrarInformacion;
        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSección;
        private System.Windows.Forms.ComboBox comboBoxSección;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitutoFunciones;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
    }
}

