using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos2.Vistas
{
    public partial class CentralesEmpleado : Form
    {
        public CentralesEmpleado()
        {
            InitializeComponent();
        }

        private void CentralesEmpleado_Load(object sender, EventArgs e)
        {
            DBConexion x = new DBConexion();
           
            String consulta = "dbo.InsertaEditaConsulta";
            
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@Empleado", SqlDbType.VarChar);
            parametros[0].Size = 100;
            parametros[0].Value = "Octavio Lopez";

            dataGridView1.DataSource = x.EjecutaStoreProcedureDT(consulta, parametros); 
        }
    }
}
