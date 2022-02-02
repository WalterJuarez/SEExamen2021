using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEExamen2021
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER = DESKTOP-43JQK6V; DATABASE = SEExamen2021; Integrated security = true");
            cn.Open();
            return cn;
        }
    }
}
