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
    public partial class Triángulo_frm : Form
    {
        public Triángulo_frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int Base, Altura, resultado;

            //Datos de entrada
            Base = Convert.ToInt32(txtBase.Text);
            Altura = Convert.ToInt32(txtAltura.Text);

            //Proceso
            resultado = (Base * Altura) / 2;

            //Salida
            lblResultado.Text = Convert.ToString(resultado);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush morado = new SolidBrush(Color.Magenta);
            Point[] puntos =
            {
                new Point(10, 180),
                new Point(100, 10),
                new Point (190, 180)
            };
            papel.FillPolygon(morado, puntos);
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
