using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            if(BusquedaHerramientas.codigo_herramienta.Length > 0)
            {
                txtCodigo_Herramientas.Text = BusquedaHerramientas.codigo_herramienta;
                txtDescripcion.Text = BusquedaHerramientas.descripcion;
                txtMarca.Text = BusquedaHerramientas.marca; 
                txtMedida.Text = BusquedaHerramientas.medida;
                txtNombre.Text = BusquedaHerramientas.nombre; 
            }
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
            if(BusquedaHerramientas.codigo_herramienta.Length > 0)
            {
                mt.ModificarHerramientas(txtCodigo_Herramientas, txtNombre, txtMedida, txtMarca, txtDescripcion); 
            }
            else
            {
                mt.GuardarHerramientas(txtCodigo_Herramientas, txtNombre, txtMedida, txtMarca, txtDescripcion);
            }
            Close();
        }
            
    }
}
