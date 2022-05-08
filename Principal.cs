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
    public partial class Principal_frm : Form
    {
        public Principal_frm()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma_frm cambiarForm = new Suma_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado_frm cambiarForm = new Cuadrado_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnRectángulo_Click(object sender, EventArgs e)
        {
            Rectángulo_frm cambiarForm = new Rectángulo_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnTriángulo_Click(object sender, EventArgs e)
        {
            Triángulo_frm cambiarForm = new Triángulo_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            Votar_frm cambiarForm = new Votar_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnCírculo_Click(object sender, EventArgs e)
        {
            Círculo_frm cambiarForm = new Círculo_frm();
            cambiarForm.ShowDialog();
            this.Close();

        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            Tienda_frm cambiarForm = new Tienda_frm();
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

        private void btnServicio_Click(object sender, EventArgs e)
        {
            Servicio_frm cambiarForm = new Servicio_frm();
            cambiarForm.ShowDialog();
            this.Close();
        }
    }
}
