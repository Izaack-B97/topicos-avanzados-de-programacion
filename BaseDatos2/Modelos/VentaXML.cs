using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{

    public class VentaXML
    {
        public int IDVenta { get; set; }
        public DateTime Fecha { get; set; }
        public List<ArticuloXML> ListadoArticulos { get; set; }
    }

}
