using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acciones.LlenarCombo(textBox1.Text,comboBox1,"Usuario","Nombre");
            Conexion.EjecutaSeleccionDataGrid(textBox1.Text,dataGridView1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Acciones.Mensaje(comboBox1.SelectedValue.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
