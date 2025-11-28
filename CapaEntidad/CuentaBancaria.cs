using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CuentaBancaria
    {
        public int IdCuenta { get; set; }
        public Banco oBanco { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }

}
