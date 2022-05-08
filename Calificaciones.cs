using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Calificaciones_frm : Form
    {
        public Calificaciones_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double periodo1, periodo2, promedio;
            
            periodo1 = Convert.ToDouble(textBox1.Text);
            periodo2 = Convert.ToDouble(textBox2.Text);
            promedio = (periodo1 + periodo2) / 2;

            if (promedio <= 5)
            {
                MessageBox.Show("Lo siento, tendrás que repetir la materia. Tu promedio es de " + promedio, "Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (promedio < 7 & promedio > 5)
                {
                    MessageBox.Show("Pasaste pero tendrás que entrar a 10 asesorías Tu promedio es de " + promedio, "Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (promedio >= 7 & promedio<9)
                    {
                        MessageBox.Show("Pasaste pero tendrás que entrar a 5 asesorías. Tu promedio es de " + promedio, "Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                     {
                        MessageBox.Show("Felicidades, pasaste con muy buena calificación. Tu promedio es de " + promedio, "Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                 }
           }
          

        }
    }
