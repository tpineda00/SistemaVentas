using System;
using System.Data;
using CapaDato;

namespace CapaNegocio
{
    public class CN_Deposito
    {
        private CD_Deposito objDato = new CD_Deposito();

        public bool DepositarEnCuentas(DataTable detalle, string descripcion, decimal montoTotal, out string mensaje)
        {
            decimal suma = 0;

            foreach (DataRow row in detalle.Rows)
            {
                suma += Convert.ToDecimal(row["Monto"]);
            }

            if (suma != montoTotal)
            {
                mensaje = "El total distribuido no coincide con el monto total";
                return false;
            }

            return objDato.DepositarDistribuido(detalle, descripcion, out mensaje);
        }
    }
}
