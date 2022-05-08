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
    public partial class Rectángulo_frm : Form
    {
        public Rectángulo_frm()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int Base, Altura, Resultado;

            //Datos de entrada
            Base = Convert.ToInt32(txtBase.Text);
            Altura = Convert.ToInt32(txtAltura.Text);

            //Proceso
            Resultado = Base * Altura;

            //Salida
            lblResultado.Text = Convert.ToString(Resultado);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush rosa = new SolidBrush(Color.HotPink);
            papel.FillRectangle(rosa, 10, 10, Altura, Base);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Principal_frm cambiarForm = new Principal_frm();
            cambiarForm.ShowDialog();

            this.Close();
        }

        private void Rectángulo_frm_Load(object sender, EventArgs e)
        {

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
