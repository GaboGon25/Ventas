using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            double Cantidad, Valor, Compra, Descuento, Total;

            Cantidad = double.Parse(txtCantidad.Text);
            Valor = double.Parse(txtValor.Text);

            Compra = (Cantidad * Valor);

            txtCompra.Text = Compra.ToString();

            Descuento = (Compra * 0.11);

            txtDescuento.Text = Descuento.ToString();

            Total = (Compra - Descuento);

            txtTotal.Text = Total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtValor.Clear();
            txtCompra.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
        }
    }
}
