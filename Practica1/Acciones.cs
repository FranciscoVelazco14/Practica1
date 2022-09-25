using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Data.SqlClient;
using ListView = System.Windows.Forms.ListView;

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
            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 combo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
             }*/

            combo.ValueMember = id;
            combo.DisplayMember = columna;

            //AQUI SE AGREGA EL RENGLON TODAS
            DataRow nuevaFila = dt.NewRow();
            nuevaFila[id] = 0;
            nuevaFila[columna] = "TODAS";
            dt.Rows.InsertAt(nuevaFila, 0);
            //

            combo.DataSource = dt;

        }


        public static void LlenarDataGridView(string consulta,DataGridView dgv )
        {
            DataTable dt = new DataTable();
            dt = Conexion.EjecutarConsulta(consulta);
            if (dt == null)
            {
                return;
            }
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.DataSource = dt;
        }

        public static void LlenarListView(string consulta,  System.Windows.Forms.ListView lv )
        {
            DataTable dt;
            dt = Conexion.EjecutarConsulta(consulta);
            if (dt == null)
            {
                return;
            }

            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;

            for (int i=0; i <= dt.Rows.Count;i++)
            {
                lv.Columns.Add(dt.Columns[i].ToString(), 70);
            }

            foreach (DataRow renglon in dt.Rows)
            {
                string[] arr = new string[dt.Columns.Count];
                ListViewItem itm = new ListViewItem();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    arr[i] = renglon[i].ToString();
                    itm = new ListViewItem(arr);
                    //lv.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
                lv.Items.Add(itm);
            }
           
        }

    }
}
