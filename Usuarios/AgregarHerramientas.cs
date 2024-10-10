using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador; 

namespace Usuarios
{
    public partial class AgregarHerramientas : Form
    {
        Manejador_taller mt;

        public AgregarHerramientas()
        {
            InitializeComponent();
            mt = new Manejador_taller();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mt.GuardarHerramientas(txtCodigo_Herramientas, txtNombre, txtMedida, txtMarca, txtDescripcion);
        }
    }
}
