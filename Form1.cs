using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEExamen2021
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            IngresoClientes ingresoClientes = new IngresoClientes();
            ingresoClientes.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desplegarBase db = new desplegarBase();
            db.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void btBuscarCod_Click(object sender, EventArgs e)
        {
            BuscarCodigo buscarCodigo = new BuscarCodigo();
            buscarCodigo.Show();
        }

        private void btbuscarnombre_Click(object sender, EventArgs e)
        {
            BuscarNombre buscarNombre = new BuscarNombre();
            buscarNombre.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.Show();
        }
    }
}
