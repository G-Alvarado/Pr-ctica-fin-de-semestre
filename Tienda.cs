using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_fin_de_semestre
{
    public partial class Tienda_frm : Form
    {
        public Tienda_frm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            double total, descuento;

            //Datos de entrada
            total = Convert.ToDouble(txtTotal.Text);

            //Proceso
            descuento = total - 10;

            //Salida
            if (total > 200)
                MessageBox.Show("El total de su compra con descuento es $" + descuento, "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El total de su compra es $" + total, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
            if(respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            Principal_frm cambiarForm = new Principal_frm();
            cambiarForm.ShowDialog();

            this.Close();
        }
    }
}
