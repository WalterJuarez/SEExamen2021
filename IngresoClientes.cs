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
    public partial class IngresoClientes : Form
    {
        public IngresoClientes()
        {
            InitializeComponent();
        }
        

        private void btIngresar_Click(object sender, EventArgs e)
        {

            string consulta = "Inserte_Cliente '" + txtnombre1.Text + "','" + txtnombre2.Text + "','" + txtapellido1.Text + "','" + txtapellido2.Text + "','" + txtapellidoc.Text + "','" + txtdireccion.Text + "'," + Convert.ToInt32(txttelefono1.Text) + "," + Convert.ToInt32(txttelefono2.Text) +",'" +txtid.Text+"','"+dtpfechanac.Value+"'";
            
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            

        }

        
    }
}
