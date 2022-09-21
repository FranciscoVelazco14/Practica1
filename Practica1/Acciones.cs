using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Practica1
{
    internal class Acciones
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void LlenarCombo(string consulta, ComboBox combo,string id, string columna)
        {
            DataTable dt;
            dt = Conexion.EjecutarConsulta(consulta);
            if (dt == null)
            {
                return;
            }
            combo.Items.Clear();
            combo.Items.Add("asd");
            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 combo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
             }*/


            //combo.DataSource = dt;
            combo.ValueMember = id;
            combo.DisplayMember = columna;
        }
    }
}
