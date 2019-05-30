using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public  bool estado { get; set; }
        public Cliente cliente { get; set; }
        public Producto producto { get; set; }
        public DateTime fecharegistro { get; set; }
    }
}
