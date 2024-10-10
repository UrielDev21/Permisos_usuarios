namespace Usuarios
{
    partial class BusquedaHerramientas
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTaller = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(91, 96);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(848, 25);
            this.txtBuscar.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Busqueda:";
            // 
            // dtgvTaller
            // 
            this.dtgvTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaller.Location = new System.Drawing.Point(16, 143);
            this.dtgvTaller.Name = "dtgvTaller";
            this.dtgvTaller.RowHeadersWidth = 51;
            this.dtgvTaller.RowTemplate.Height = 24;
            this.dtgvTaller.Size = new System.Drawing.Size(924, 436);
            this.dtgvTaller.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Busqueda de herramientas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(910, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 36);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-7, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 57);
            this.panel1.TabIndex = 34;
            // 
            // BusquedaHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvTaller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BusquedaHerramientas";
            this.Text = "BusquedaHerramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTaller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
    }
}