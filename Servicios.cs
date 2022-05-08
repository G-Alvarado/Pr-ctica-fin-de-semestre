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
    public partial class Servicio_frm : Form
    {
        public Servicio_frm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Definir las variables
            int INE;
            double total;

            INE = Convert.ToInt32(txtINE.Text);
            total = comboBox1.SelectedIndex;

            switch (total) 
            {
                case 0:
                    total = 750 - (750 * 0.10);
                    MessageBox.Show("El total de la factura del cliente: " + INE + " es de " + total, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    total = 930 - (930 * 0.05);
                    MessageBox.Show("El total de la factura del cliente: " + INE + " es de " + total, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    total = 1200;
                    MessageBox.Show("El total de la factura del cliente: " + INE + " es de " + total, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            Principal_frm cambiarForm = new Principal_frm();
            cambiarForm.ShowDialog();

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
