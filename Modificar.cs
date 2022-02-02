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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            string consulta = "LeerTablaClientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgModificar.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            string consulta = "Actualiza_Cliente '" + txtDireccion.Text + "'," + Convert.ToInt32(txttelefono.Text) + "," + Convert.ToInt32(dgModificar.CurrentRow.Cells[0].Value.ToString());
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conexion.Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgModificar.DataSource= dt;
            string consulta2 = "LeerTablaClientes";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, Conexion.Conectar());
            DataTable dt2 = new DataTable();
            adaptador2.Fill(dt2);
            dgModificar.DataSource = dt2;
        }

        private void dgModificar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgModificar.CurrentRow.Cells[1].Value != null)
            {
                txtDireccion.Text = dgModificar.CurrentRow.Cells[6].Value.ToString();
                txttelefono.Text = dgModificar.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
