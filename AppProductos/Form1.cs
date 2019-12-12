using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProductos
{
    public partial class Form1 : Form
    {
        private List <Clase.Productos> lista = new List<Clase.Productos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Clase.Productos producto = new Clase.Productos();
            producto.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            producto.NombreProducto = this.txtNomnbreP.Text;
            producto.PrecioVenta = Convert.ToInt32(this.txtPrecioVenta.Text);
            producto.FechaCompra = this.txtFecha.Text;
            producto.Unidad = Convert.ToInt32(this.txtPrecioVenta.Text);

            lista.Add(producto);

            ListViewItem item = new ListViewItem(producto.Codigo.ToString());
            listViewRegistro.Items.Add(item);
            item.SubItems.Add(producto.NombreProducto);
            item.SubItems.Add(producto.PrecioVenta.ToString());
            item.SubItems.Add(producto.FechaCompra);
            item.SubItems.Add(producto.Unidad.ToString());





        }
    }
}
