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
    public partial class Votar_frm : Form
    {
        public Votar_frm()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int nacimiento, edad;
            //Datos de entrada
            nacimiento = Convert.ToInt32(txtNacimiento.Text);
            //Proceso
            edad = 2022 - nacimiento;
            //Salida
            if (edad>=18)
            {
                MessageBox.Show("Usted puede votar", "Votación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usted NO puede votar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
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
