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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string consulta = "Eliminar_Cliente "+Convert.ToInt32(txtCodigo.Text);
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            
        }
    }
}
