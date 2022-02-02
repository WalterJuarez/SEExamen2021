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
    public partial class desplegarBase : Form
    {
        public desplegarBase()
        {
            InitializeComponent();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void desplegarBase_Load(object sender, EventArgs e)
        {
            string consulta = "LeerTablaClientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgCliente.DataSource = dt;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
