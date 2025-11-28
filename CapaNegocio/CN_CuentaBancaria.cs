using System.Collections.Generic;
using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_CuentaBancaria
    {
        private CD_CuentaBancaria objDato = new CD_CuentaBancaria();

        public List<CuentaBancaria> Listar()
        {
            return objDato.Listar();
        }
    }
}
