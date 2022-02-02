using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SEExamen2021
{
    public partial class BuscarNombre : Form
    {
        public BuscarNombre()
        {
            InitializeComponent();
        }

        private void btbuscarnombre_Click(object sender, EventArgs e)
        {
            string consulta = "Consulta_Nom_Apell '"+txtNombre.Text+"'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgbusqueda.DataSource = dt;
        }
    }
}
