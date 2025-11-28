using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    namespace CapaEntidad
    {
        public class MovimientoBancario
        {
            public int IdMovimiento { get; set; }

            public CuentaBancaria oCuenta { get; set; }

            public string TipoMovimiento { get; set; } // DEPOSITO / PAGO
            public decimal Monto { get; set; }
            public string Descripcion { get; set; }
            public string FechaRegistro { get; set; }
        }
    }

}
