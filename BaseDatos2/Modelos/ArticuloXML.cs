using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class ArticuloXML
    {
        public int IDArticulo { get; set; }
        public String NombreArticulo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public ArticuloXML()
        {

        }
        
    }
}
