using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDato
{
    public class CD_CuentaBancaria
    {
        public List<CuentaBancaria> Listar()
        {
            List<CuentaBancaria> lista = new List<CuentaBancaria>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"
                SELECT C.IdCuenta, C.NumeroCuenta, C.Saldo,
                       B.IdBanco, B.NombreBanco
                FROM CuentaBancaria C
                INNER JOIN Banco B ON C.IdBanco = B.IdBanco
                WHERE C.Estado = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new CuentaBancaria
                        {
                            IdCuenta = (int)dr["IdCuenta"],
                            NumeroCuenta = dr["NumeroCuenta"].ToString(),
                            Saldo = (decimal)dr["Saldo"],
                            oBanco = new Banco
                            {
                                IdBanco = (int)dr["IdBanco"],
                                NombreBanco = dr["NombreBanco"].ToString()
                            }
                        });
                    }
                }
            }
            return lista;
        }
    }
}
