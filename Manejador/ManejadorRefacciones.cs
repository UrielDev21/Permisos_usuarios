using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso;

namespace Manejador
{
    public class ManejadorRefacciones
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Codigo, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            MessageBox.Show(f.Guardar($"call p_insertar_refacciones('{Codigo.Text}', '{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}'))"),
                "!ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(string Codigo, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}", "!ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_eliminar_refacciones({Codigo})");
                MessageBox.Show("Registro eliminado", "!ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox Codigo, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            MessageBox.Show(f.Modificar($"call p_modificar_refacciones({Codigo.Text}, '{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}'))"),
                "!ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void MostrarRefacciones(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource = f.Mostrar($"select * from refacciones where nombre like '%{filtro}%'", "refacciones").Tables[0];
            Tabla.Columns.Insert(5, Boton("Borrar", Color.Red));
            Tabla.Columns.Insert(6, Boton("Editar", Color.Green));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }
    }
}
