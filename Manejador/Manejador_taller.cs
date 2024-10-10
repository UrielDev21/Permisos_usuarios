using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_datos;

namespace Manejador
{
    public class Manejador_taller
    {
        // Creamos el objeto para poder hacer los Query en la base de datos
        Funciones f = new Funciones();

        // Metodo para poder insertar herramientas en la tabla
        public void GuardarHerramientas(TextBox Codigo_herramienta, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            MessageBox.Show(f.Guardar($"call p_insertar_herramienta('{Codigo_herramienta.Text}', '{Nombre.Text}', '{Medida.Text}', '{Marca.Text}', '{Descripcion.Text}')"), 
                "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        // Metodo para modificar los registros de la tabla taller
        public void ModificarHerramientas(TextBox Codigo_herramienta, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            MessageBox.Show(f.Modificar($"call p_modificar_herramienta('{Codigo_herramienta.Text}', '{Nombre.Text}', '{Medida.Text}', '{Marca.Text}', '{Descripcion.Text}')"), 
                "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        // Metodo para crear un boton dentro del datagridview
        DataGridViewButtonColumn Boton(string texto, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = texto;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup; 
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White; 
            return b;
        }
        public void MostrarHerramientas(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from v_vista_taller where nombre like '%{filtro}%'", "taller").Tables[0];
            tabla.Columns.Add(Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns(); 
            tabla.AutoResizeRows(); 
        }
    }
}
