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
using System.Xml.Linq;

namespace BaseDatos2.Vistas
{
    public partial class VentaArticulo : Form
    {
        private int contadorVenta;
        private int contadorArticulo;
        Modelos.VentaXML miVenta;

        public VentaArticulo()
        {
            InitializeComponent();
            contadorVenta = 1;
            contadorArticulo = 1;
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botAgregarVenta_Click(object sender, EventArgs e)
        {
            miVenta = new Modelos.VentaXML();
            miVenta.IDVenta = contadorVenta++;
            miVenta.Fecha = DateTime.Now;
            miVenta.ListadoArticulos = new List<Modelos.ArticuloXML>();
            Object[] renglonVenta = {miVenta.IDVenta, miVenta.Fecha};
            dgvVenta.Rows.Add(renglonVenta);

        }

        private void botAgregarArticulo_Click(object sender, EventArgs e)
        {
            Modelos.ArticuloXML a = new Modelos.ArticuloXML();
            a.IDArticulo = Int32.Parse(txtIDArticulo.Text);
            a.NombreArticulo = txtNombreArticulo.Text;
            a.Cantidad = Int32.Parse(txtCantidad.Text);
            a.Precio = Double.Parse(txtPrecio.Text);

            miVenta.ListadoArticulos.Add(a);
            Object[] renglonArticulo = {a.IDArticulo, a.NombreArticulo
                                        , a.Cantidad, a.Precio};

            dgvArticulo.Rows.Add(renglonArticulo);
        }

        private void botGenerarXML_Click(object sender, EventArgs e)
        {
            XElement miXML = new XElement("ListadoArticulos"
                , from x in miVenta.ListadoArticulos
                  select new XElement("Articulo"
                        ,new XElement("IDArticulo", x.IDArticulo)
                        ,new XElement("NombreArticulo", x.NombreArticulo)
                        ,new XElement("Cantidad", x.Cantidad)
                        ,new XElement("Precio", x.Precio)
                )
            );

            txtXML.Text = miXML.ToString();
        }

        private void botInsertarActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "[dbo].[InsertaListadoArticulos]"; // Nombre del SP
                SqlParameter[] parametros = new SqlParameter[6];
                parametros[0] = new SqlParameter("@IDVenta", SqlDbType.Int);
                parametros[0].Value
                    = Int32.Parse(dgvVenta.SelectedRows[0].Cells["_IDVenta"].Value.ToString());
                parametros[1] = new SqlParameter("@Fecha", SqlDbType.Date);
                parametros[1].Value
                    = DateTime.Parse(dgvVenta.SelectedRows[0].Cells["_Fecha"].Value.ToString());
                parametros[2] = new SqlParameter("@ArticulosXML", SqlDbType.Xml);
                parametros[2].Value = txtXML.Text;
                parametros[3] = new SqlParameter("@IDRegreso", SqlDbType.Int);
                parametros[3].Direction = ParameterDirection.Output;
                parametros[4] = new SqlParameter("@spRegreso", SqlDbType.Bit);
                parametros[4].Direction = ParameterDirection.Output;
                parametros[5] = new SqlParameter("@spMensaje", SqlDbType.VarChar);
                parametros[5].Size = 500;
                parametros[5].Direction = ParameterDirection.Output;

                int IDRegreso = 0;
                Boolean Regreso = false;
                String Mensaje = "";

                miConn.EjecutaStoreProcedureParametros(consulta, parametros
                                    , out IDRegreso, out Regreso, out Mensaje);
                if (Regreso == true)
                {
                    MessageBox.Show("Se insertó o actualizó el registro con ID "
                                    + IDRegreso.ToString() + ".");
                }
                else
                {
                    MessageBox.Show("Error:  " + Mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.ToString());
            }
        }

        private void txtIDArticulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIDArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)13) // Es un Enter
            {
                try
                {
                    DBConexion miConn = new DBConexion();
                    String consulta = "SELECT NombreProducto, Precio "
                                        + " FROM DS3.dbo.Producto " 
                                        + " WHERE IDProducto = @IDProducto";
                    SqlParameter[] parametros = new SqlParameter[1];
                    parametros[0] = new SqlParameter("@IDProducto", SqlDbType.Int);
                    parametros[0].Value = Int32.Parse(txtIDArticulo.Text);

                    DataTable dt = miConn.ejecutaSelect(consulta, parametros);
                    if(dt.Rows.Count == 1)
                    {
                        txtNombreArticulo.Text = dt.Rows[0]["NombreProducto"].ToString();
                        txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
                    } else
                    {
                        txtNombreArticulo.Text = "";
                        txtPrecio.Text = "0.00";
                        MessageBox.Show("No se encontró el IDProducto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. Mensaje: " + ex.ToString());
                }
            }
        }

        private void dgvVenta_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
