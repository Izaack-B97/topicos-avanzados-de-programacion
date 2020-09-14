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
    public partial class Practica5 : Form
    {
        int contador = 0;
        Modelos.Renta renta;
        Modelos.RentaVideo a;

        public Practica5()
        {
            InitializeComponent();
            contador = 1;
        }

        private void Practica5_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            a = new Modelos.RentaVideo();
            a.IDRentaVideo = Int32.Parse(txtID.Text);
            a.Precio = Double.Parse(txtPrecio.Text);

            renta.Listado.Add(a);
            object[] renglonarticulo = {a.IDRentaVideo, txtNombre.Text
                                        , a.Precio};

            dgvRentaProducto.Rows.Add(renglonarticulo);
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            XElement miXML = new XElement("ListadoVideos"
               , from x in renta.Listado
                 select new XElement("Video"
                       , new XElement("IDVideo", x.IDRentaVideo)
                       , new XElement("Precio", x.Precio)
               )
           );

           txtXML.Text = miXML.ToString();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "[dbo].[InsertaRentaConVideos]"; // Nombre del SP
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("@Usuario", SqlDbType.VarChar);
                parametros[0].Value = "Isaac";
                parametros[1] = new SqlParameter("@VideosXML", SqlDbType.Xml);
                parametros[1].Value = txtXML.Text;
                parametros[2] = new SqlParameter("@IDRegreso", SqlDbType.Int);
                parametros[2].Direction = ParameterDirection.Output;
                parametros[3] = new SqlParameter("@spRegreso", SqlDbType.Bit);
                parametros[3].Direction = ParameterDirection.Output;
                parametros[4] = new SqlParameter("@spMensaje", SqlDbType.VarChar);
                parametros[4].Size = 500;
                parametros[4].Direction = ParameterDirection.Output;

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

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Es un Enter
            {
                try
                {
                    DBConexion miConn = new DBConexion();
                    String consulta = "SELECT NombreVideo, Precio "
                                        + " FROM DS3.dbo.Video "
                                        + " WHERE IDVideo = @IDVideo";
                    SqlParameter[] parametros = new SqlParameter[1];
                    parametros[0] = new SqlParameter("@IDVideo", SqlDbType.Int);
                    parametros[0].Value = Int32.Parse(txtID.Text);

                    DataTable dt = miConn.ejecutaSelect(consulta, parametros);

                    if (dt.Rows.Count == 1)
                    {
                        txtNombre.Text = dt.Rows[0]["NombreVideo"].ToString();
                        txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
                    }
                    else
                    {
                        txtNombre.Text = "";
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void W_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {

            renta = new Modelos.Renta();
            renta.IDRenta = contador++;

            renta.Listado = new List<Modelos.RentaVideo>();
            Object[] renglonVenta = { renta.IDRenta };
            dataGridView1.Rows.Add(renglonVenta);

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
