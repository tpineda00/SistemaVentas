using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleDeposito
    {
        public int IdDetalle { get; set; }

        public CuentaBancaria oCuenta { get; set; }

        public decimal Monto { get; set; }
    }
}
