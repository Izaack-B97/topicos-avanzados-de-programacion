using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class Renta
    {
        public int IDRenta { get; set; }
        public List<RentaVideo>  Listado { get; set; }
    }
}
