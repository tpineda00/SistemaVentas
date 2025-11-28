using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CD_Deposito
    {
        public bool DepositarDistribuido(DataTable detalle, string descripcion, out string mensaje)
        {
            mensaje = "";

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_DepositoDistribuido", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro tipo tabla
                    SqlParameter parametro = cmd.Parameters.AddWithValue("@DetalleDeposito", detalle);
                    parametro.SqlDbType = SqlDbType.Structured;

                    // Otros parámetros
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    return true;
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    return false;
                }
            }
        }

    }
}
