using CapaEntidad;
using CapaEntidad.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class CD_MovimientoBancario
    {
        public List<MovimientoBancario> Listar()
        {
            List<MovimientoBancario> lista = new List<MovimientoBancario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                    SELECT M.IdMovimiento, M.TipoMovimiento, M.Monto, M.Fecha, M.Descripcion,
                           C.NumeroCuenta, B.NombreBanco
                    FROM MovimientoBancario M
                    INNER JOIN CuentaBancaria C ON M.IdCuenta = C.IdCuenta
                    INNER JOIN Banco B ON C.IdBanco = B.IdBanco
                    ORDER BY M.Fecha DESC";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new MovimientoBancario()
                        {
                            IdMovimiento = Convert.ToInt32(dr["IdMovimiento"]),
                            TipoMovimiento = dr["TipoMovimiento"].ToString(),
                            Monto = Convert.ToDecimal(dr["Monto"]),
                            Descripcion = dr["Descripcion"].ToString(),
                            FechaRegistro = Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yyyy"),

                            oCuenta = new CuentaBancaria()
                            {
                                NumeroCuenta = dr["NumeroCuenta"].ToString(),
                                oBanco = new Banco()
                                {
                                    NombreBanco = dr["NombreBanco"].ToString()
                                }
                            }
                        });
                    }
                }
                catch
                {
                    lista = new List<MovimientoBancario>();
                }
            }

            return lista;
        }
    }
}
