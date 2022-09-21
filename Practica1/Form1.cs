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
            //int  registrosAfectados = 0;
            //Conexion.EjecutaConsulta(textBox1.Text);
            //Acciones.Mensaje("Registros Afectados: " + registrosAfectados);
            Conexion.EjecutaSeleccionDataGrid(textBox1.Text,dataGridView1);

        }
    }
}
