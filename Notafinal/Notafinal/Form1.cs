using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notafinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double acumulativo, examen, notaFinal;
            string jornada = "";
            string resultado = "";


            if (!double.TryParse(txtAcumulativo.Text, out acumulativo) ||
                !double.TryParse(txtExamen.Text, out examen))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

            if (rbPresencial.Checked)
                jornada = "Presencial";
            else if (rbDistancia.Checked)
                jornada = "Distancia";
            else
            {
                MessageBox.Show("Seleccione una jornada");
                return;
            }

            notaFinal = acumulativo + examen;


            if (notaFinal >= 60)
                resultado = "Aprobado";
            else
                resultado = "Reprobado";


            MessageBox.Show(
                "Nombre: " + nombre +
                "\nJornada: " + jornada +
                "\nNota final: " + notaFinal +
                "\nResultado: " + resultado
            );

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtAcumulativo.Clear();
            txtExamen.Clear();
            rbPresencial.Checked = false;
            rbDistancia.Checked = false;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
