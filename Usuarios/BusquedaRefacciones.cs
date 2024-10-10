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
    public partial class BusquedaRefacciones : Form
    {
        ManejadorRefacciones mf;
        int fila = 0, columna = 0;
        public static string Codigo = "", Nombre = "", Descripcion = "", Marca = "";
        public BusquedaRefacciones()
        {
            InitializeComponent();
            mf = new ManejadorRefacciones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvTabla.Visible = true;
            mf.MostrarRefacciones(dtgvTabla, txtBuscar.Text);
        }

        private void dtgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;

            switch (columna)
            {
                case 5:
                    {
                        Codigo = dtgvTabla.Rows[fila].Cells[0].Value.ToString();
                        mf.Borrar(Codigo, dtgvTabla.Rows[fila].Cells[2].Value.ToString());
                        dtgvTabla.Visible = false;

                    }
                    break;
                case 6:
                    {
                        Codigo = dtgvTabla.Rows[fila].Cells[0].Value.ToString();
                        Nombre = dtgvTabla.Rows[fila].Cells[1].ToString();
                        Descripcion = dtgvTabla.Rows[fila].Cells[2].ToString();
                        Marca = dtgvTabla.Rows[fila].Cells[3].ToString();
                    }
                    break;
            }
        }
    }
}
