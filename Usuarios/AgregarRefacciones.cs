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
    public partial class AgregarRefacciones : Form
    {
        ManejadorRefacciones mf;
        public static string Codigo = "", Nombre = "", Descripcion = "", Marca = "";
        public AgregarRefacciones()
        {
            InitializeComponent();
            mf = new ManejadorRefacciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Codigo.Length > 0)
            {
                mf.Modificar(txtCodigo, txtNombre, txtDescripcion, txtMarca);
            }
            else
            {
                mf.Guardar(txtCodigo, txtNombre, txtDescripcion, txtMarca);
            }
            Close();
        }
    }
}
