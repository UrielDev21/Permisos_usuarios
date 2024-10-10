using System;
using System.Collections.Generic;
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
    }
}
