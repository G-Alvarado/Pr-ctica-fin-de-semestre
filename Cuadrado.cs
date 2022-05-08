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
    public partial class Cuadrado_frm : Form
    {
        public Cuadrado_frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int lado, resultado;

            //Datos de entrada
            lado = Convert.ToInt32(txtlado.Text);

            //Proceso
            resultado = lado * lado;

            //Salida
            lblresult.Text = Convert.ToString(resultado);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            SolidBrush morado = new SolidBrush(Color.PeachPuff);
            papel.FillRectangle(morado, 10, 10, lado, lado);

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
