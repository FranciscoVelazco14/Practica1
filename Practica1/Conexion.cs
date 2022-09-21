using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    internal class Conexion
    {
        static SqlConnection cnx;
        static string cadena = "Address= 192.168.101.10; initial catalog= QTUBEDsllo; integrated security=False;persist security info=True; MultipleActiveResultSets=True; User ID=dba_jr; Password=E2aZI,Qm}x; Application Name=ENLACE 2.4.0";
        static string cambios;
        private static void Conectar()
        {
            cnx = new SqlConnection(cadena);
            cnx.Open();
        }
        private static void Desconectar()
        {
            cnx.Close();
        }
        public static int ConsultaColumnasAfectadas(string consulta)
        {
            int filasAfectadas;
            Conectar();
            SqlCommand cmd = new SqlCommand(consulta, cnx);
            filasAfectadas = cmd.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }
        public static DataTable EjecutarConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta,cnx);
            da.Fill(dt);
            Desconectar();
            return dt;

        }

        public static void EjecutaSeleccionDataGrid(string consulta, DataGridView DataGrid)
        {
            DataTable dt = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);

            Desconectar();
            DataGrid.DataSource = dt;
        }

        public static void EjecutarSeleccionListView(string consulta, ListView ListV)
        {
            DataTable dt = new DataTable();
        }

       
    }
}
