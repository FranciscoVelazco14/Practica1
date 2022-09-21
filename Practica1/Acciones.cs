using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace Practica1
{
    internal class Acciones
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void LlenarCombo(string consulta, System.Windows.Forms.ComboBox combo,string id, string columna)
        {
            DataTable dt;
            dt = Conexion.EjecutarConsulta(consulta);
            if (dt == null)
            {
                return;
            }
            combo.Items.Clear();
            // combo.Items.Add("asd");
            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 combo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
             }*/

            //combo.Items.Insert(0,"PRUEBA");
            combo.ValueMember = id;
            combo.DisplayMember = columna;

            combo.Items.Insert(0, "TODAS");
            combo.DataSource = dt;
        }
    }
}
