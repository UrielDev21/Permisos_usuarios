namespace Usuarios
{
    partial class AgregarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkEscritura = new System.Windows.Forms.CheckBox();
            this.chkModificacion = new System.Windows.Forms.CheckBox();
            this.chkEliminacion = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAgregarUsuarios = new System.Windows.Forms.CheckBox();
            this.chkVerUsuarios = new System.Windows.Forms.CheckBox();
            this.chkAgregarRefacciones = new System.Windows.Forms.CheckBox();
            this.chkVerRefacciones = new System.Windows.Forms.CheckBox();
            this.chkAgregarHerramienta = new System.Windows.Forms.CheckBox();
            this.chkVerHerramienta = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Bisque;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(331, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 44);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Snow;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(144, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 44);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha de nacimineto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apellido materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 100);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 32);
            this.txtNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Agregar Usuarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "RFC:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(205, 281);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(136, 26);
            this.dtpFechaNacimiento.TabIndex = 38;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 10, 6, 0, 0, 0, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(904, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 36);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(179, 157);
            this.txtApellidoP.Multiline = true;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(283, 32);
            this.txtApellidoP.TabIndex = 40;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(182, 221);
            this.txtApellidoM.Multiline = true;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(283, 32);
            this.txtApellidoM.TabIndex = 41;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(106, 338);
            this.txtRfc.Multiline = true;
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(356, 32);
            this.txtRfc.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 56);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Usuarios.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEliminacion);
            this.groupBox1.Controls.Add(this.chkModificacion);
            this.groupBox1.Controls.Add(this.chkEscritura);
            this.groupBox1.Controls.Add(this.chkLectura);
            this.groupBox1.Location = new System.Drawing.Point(631, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 147);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos dentro de formulario";
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(44, 25);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(71, 24);
            this.chkLectura.TabIndex = 0;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkEscritura
            // 
            this.chkEscritura.AutoSize = true;
            this.chkEscritura.Location = new System.Drawing.Point(44, 55);
            this.chkEscritura.Name = "chkEscritura";
            this.chkEscritura.Size = new System.Drawing.Size(79, 24);
            this.chkEscritura.TabIndex = 1;
            this.chkEscritura.Text = "Escritura";
            this.chkEscritura.UseVisualStyleBackColor = true;
            // 
            // chkModificacion
            // 
            this.chkModificacion.AutoSize = true;
            this.chkModificacion.Location = new System.Drawing.Point(44, 85);
            this.chkModificacion.Name = "chkModificacion";
            this.chkModificacion.Size = new System.Drawing.Size(103, 24);
            this.chkModificacion.TabIndex = 2;
            this.chkModificacion.Text = "Modificacion";
            this.chkModificacion.UseVisualStyleBackColor = true;
            // 
            // chkEliminacion
            // 
            this.chkEliminacion.AutoSize = true;
            this.chkEliminacion.Location = new System.Drawing.Point(44, 115);
            this.chkEliminacion.Name = "chkEliminacion";
            this.chkEliminacion.Size = new System.Drawing.Size(96, 24);
            this.chkEliminacion.TabIndex = 3;
            this.chkEliminacion.Text = "Eliminacion";
            this.chkEliminacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkVerHerramienta);
            this.groupBox2.Controls.Add(this.chkAgregarHerramienta);
            this.groupBox2.Controls.Add(this.chkVerRefacciones);
            this.groupBox2.Controls.Add(this.chkAgregarRefacciones);
            this.groupBox2.Controls.Add(this.chkVerUsuarios);
            this.groupBox2.Controls.Add(this.chkAgregarUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(631, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 231);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos a formularios";
            // 
            // chkAgregarUsuarios
            // 
            this.chkAgregarUsuarios.AutoSize = true;
            this.chkAgregarUsuarios.Location = new System.Drawing.Point(44, 25);
            this.chkAgregarUsuarios.Name = "chkAgregarUsuarios";
            this.chkAgregarUsuarios.Size = new System.Drawing.Size(130, 24);
            this.chkAgregarUsuarios.TabIndex = 1;
            this.chkAgregarUsuarios.Text = "Agregar usuarios";
            this.chkAgregarUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkVerUsuarios
            // 
            this.chkVerUsuarios.AutoSize = true;
            this.chkVerUsuarios.Location = new System.Drawing.Point(44, 55);
            this.chkVerUsuarios.Name = "chkVerUsuarios";
            this.chkVerUsuarios.Size = new System.Drawing.Size(103, 24);
            this.chkVerUsuarios.TabIndex = 2;
            this.chkVerUsuarios.Text = "Ver usuarios";
            this.chkVerUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkAgregarRefacciones
            // 
            this.chkAgregarRefacciones.AutoSize = true;
            this.chkAgregarRefacciones.Location = new System.Drawing.Point(44, 85);
            this.chkAgregarRefacciones.Name = "chkAgregarRefacciones";
            this.chkAgregarRefacciones.Size = new System.Drawing.Size(149, 24);
            this.chkAgregarRefacciones.TabIndex = 3;
            this.chkAgregarRefacciones.Text = "Agregar refacciones";
            this.chkAgregarRefacciones.UseVisualStyleBackColor = true;
            // 
            // chkVerRefacciones
            // 
            this.chkVerRefacciones.AutoSize = true;
            this.chkVerRefacciones.Location = new System.Drawing.Point(44, 115);
            this.chkVerRefacciones.Name = "chkVerRefacciones";
            this.chkVerRefacciones.Size = new System.Drawing.Size(122, 24);
            this.chkVerRefacciones.TabIndex = 4;
            this.chkVerRefacciones.Text = "Ver refacciones";
            this.chkVerRefacciones.UseVisualStyleBackColor = true;
            // 
            // chkAgregarHerramienta
            // 
            this.chkAgregarHerramienta.AutoSize = true;
            this.chkAgregarHerramienta.Location = new System.Drawing.Point(44, 145);
            this.chkAgregarHerramienta.Name = "chkAgregarHerramienta";
            this.chkAgregarHerramienta.Size = new System.Drawing.Size(149, 24);
            this.chkAgregarHerramienta.TabIndex = 5;
            this.chkAgregarHerramienta.Text = "Agregar herramienta";
            this.chkAgregarHerramienta.UseVisualStyleBackColor = true;
            // 
            // chkVerHerramienta
            // 
            this.chkVerHerramienta.AutoSize = true;
            this.chkVerHerramienta.Location = new System.Drawing.Point(44, 175);
            this.chkVerHerramienta.Name = "chkVerHerramienta";
            this.chkVerHerramienta.Size = new System.Drawing.Size(122, 24);
            this.chkVerHerramienta.TabIndex = 6;
            this.chkVerHerramienta.Text = "Ver herramienta";
            this.chkVerHerramienta.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEliminacion;
        private System.Windows.Forms.CheckBox chkModificacion;
        private System.Windows.Forms.CheckBox chkEscritura;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkVerHerramienta;
        private System.Windows.Forms.CheckBox chkAgregarHerramienta;
        private System.Windows.Forms.CheckBox chkVerRefacciones;
        private System.Windows.Forms.CheckBox chkAgregarRefacciones;
        private System.Windows.Forms.CheckBox chkVerUsuarios;
        private System.Windows.Forms.CheckBox chkAgregarUsuarios;
    }
}