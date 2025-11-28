using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PagoProveedor
    {
        public int IdPago { get; set; }

        public Proveedor oProveedor { get; set; }

        public CuentaBancaria oCuenta { get; set; }

        public decimal Monto { get; set; }
        public string Referencia { get; set; }
        public string FechaRegistro { get; set; }
    }
}
