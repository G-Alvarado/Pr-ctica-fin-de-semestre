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
    public partial class Círculo_frm : Form
    {
        public Círculo_frm()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Declarar vaariables
            double Radio, Area;
            int radio, diametro;

            //Datos de entrada
            Radio = Convert.ToInt32(txtRadio.Text);
            radio = Convert.ToInt32(txtRadio.Text);

            //Proceso
            Area = Math.PI * (Radio * Radio);
            diametro = radio * 2;
            //Salida
            lblArea.Text = Convert.ToString(Area);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush Naranja = new SolidBrush(Color.Orange);
            papel.FillEllipse(Naranja, 20, 20, diametro, diametro);
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
