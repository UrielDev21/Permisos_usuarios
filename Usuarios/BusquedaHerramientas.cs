using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios
{
    public partial class BusquedaHerramientas : Form
    {
        Manejador_taller mt;

        int fila = 0, columna = 0;

        public static string codigo_herramienta = "";
        public static string nombre = "";
        public static string medida = "";
        public static string marca = "";
        public static string descripcion = ""; 

        public BusquedaHerramientas()
        {
            InitializeComponent();
            mt = new Manejador_taller();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvTaller.Visible = true; 
            mt.MostrarHerramientas(dtgvTaller, txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvTaller_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;   

            switch(columna)
            {
                case 5:
                    {
                        codigo_herramienta = dtgvTaller.Rows[fila].Cells[0].Value.ToString();
                        nombre = dtgvTaller.Rows[fila].Cells[1].Value.ToString();
                        medida = dtgvTaller.Rows[fila].Cells[2].Value.ToString();
                        marca = dtgvTaller.Rows[fila].Cells[3].Value.ToString();
                        descripcion = dtgvTaller.Rows[fila].Cells[4].Value.ToString();

                        AgregarHerramientas ah = new AgregarHerramientas();
                        ah.ShowDialog(); 
                        dtgvTaller.Visible = false;

                    }break;
                case 6:
                    {
                        codigo_herramienta = dtgvTaller.Rows[fila].Cells[0].Value.ToString();
                        mt.ELiminar_herramientas(codigo_herramienta, dtgvTaller.Rows[fila].Cells[1].Value.ToString());
                        dtgvTaller.Visible = false; 

                    }break; 
            }
        }
    }
}
