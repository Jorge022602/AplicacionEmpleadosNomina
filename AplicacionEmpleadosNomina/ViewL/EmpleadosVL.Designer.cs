namespace AplicacionEmpleadosNomina
{
    partial class EmpleadosVL
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
            this.tbEmpleados = new System.Windows.Forms.TabControl();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtbFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGénero = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblHB = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.Salir = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.tbEmpleados.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmpleados
            // 
            this.tbEmpleados.Controls.Add(this.tabEmpleados);
            this.tbEmpleados.Controls.Add(this.tabDepartamentos);
            this.tbEmpleados.Location = new System.Drawing.Point(12, 21);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.SelectedIndex = 0;
            this.tbEmpleados.Size = new System.Drawing.Size(1024, 527);
            this.tbEmpleados.TabIndex = 0;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabEmpleados.Controls.Add(this.pictureBox1);
            this.tabEmpleados.Controls.Add(this.dtbFechaIngreso);
            this.tabEmpleados.Controls.Add(this.lblFechaIngreso);
            this.tabEmpleados.Controls.Add(this.cmbGenero);
            this.tabEmpleados.Controls.Add(this.lblGénero);
            this.tabEmpleados.Controls.Add(this.dtFechaNacimiento);
            this.tabEmpleados.Controls.Add(this.lblHB);
            this.tabEmpleados.Controls.Add(this.textApellido);
            this.tabEmpleados.Controls.Add(this.lblApellido);
            this.tabEmpleados.Controls.Add(this.textNombre);
            this.tabEmpleados.Controls.Add(this.lblNombre);
            this.tabEmpleados.Controls.Add(this.groupBox1);
            this.tabEmpleados.Location = new System.Drawing.Point(4, 25);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(1016, 498);
            this.tabEmpleados.TabIndex = 0;
            this.tabEmpleados.Text = "Registro de Empleado";
            this.tabEmpleados.UseVisualStyleBackColor = true;
            this.tabEmpleados.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(539, 19);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(471, 469);
            this.dgvEmpleados.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AplicacionEmpleadosNomina.Properties.Resources.registro_de_empleados;
            this.pictureBox1.Location = new System.Drawing.Point(160, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 184);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dtbFechaIngreso
            // 
            this.dtbFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbFechaIngreso.Location = new System.Drawing.Point(265, 200);
            this.dtbFechaIngreso.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtbFechaIngreso.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtbFechaIngreso.Name = "dtbFechaIngreso";
            this.dtbFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtbFechaIngreso.TabIndex = 9;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(31, 198);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(175, 24);
            this.lblFechaIngreso.TabIndex = 8;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino ",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(265, 153);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 24);
            this.cmbGenero.TabIndex = 7;
            this.cmbGenero.Text = "--Seleccione un valor--";
            // 
            // lblGénero
            // 
            this.lblGénero.AutoSize = true;
            this.lblGénero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGénero.Location = new System.Drawing.Point(31, 153);
            this.lblGénero.Name = "lblGénero";
            this.lblGénero.Size = new System.Drawing.Size(80, 24);
            this.lblGénero.TabIndex = 6;
            this.lblGénero.Text = "Género";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(265, 108);
            this.dtFechaNacimiento.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtFechaNacimiento.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtFechaNacimiento.TabIndex = 5;
            // 
            // lblHB
            // 
            this.lblHB.AutoSize = true;
            this.lblHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHB.Location = new System.Drawing.Point(31, 106);
            this.lblHB.Name = "lblHB";
            this.lblHB.Size = new System.Drawing.Size(210, 24);
            this.lblHB.TabIndex = 4;
            this.lblHB.Text = "Fecha de Nacimiento";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(265, 59);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(200, 22);
            this.textApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(31, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 24);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(265, 19);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 22);
            this.textNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 295);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleados";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(29, 242);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(171, 31);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "REGISTRAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(259, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(25, 87);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(85, 24);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmpleadosVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 562);
            this.Controls.Add(this.tbEmpleados);
            this.Name = "EmpleadosVL";
            this.Text = "--Seleccione un valor--";
            this.Load += new System.EventHandler(this.EmpleadosVL_Load);
            this.tbEmpleados.ResumeLayout(false);
            this.tabEmpleados.ResumeLayout(false);
            this.tabEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabDepartamentos.ResumeLayout(false);
            this.tabDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbEmpleados;
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblHB;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGénero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.DateTimePicker dtbFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}

