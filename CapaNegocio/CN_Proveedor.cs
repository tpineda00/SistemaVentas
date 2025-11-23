using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.RazonSocial == "")
            {
                Mensaje = "La Razon Social del Proveedor no puede estar vacio\n";
            }
            if (obj.Documento == "")
            {
                Mensaje = "El documento del Proveedor no puede estar vacio\n";
            }
            if (obj.Correo == "")
            {
                Mensaje = "El correo del Proveedor no puede estar vacio\n";
            }
          

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }
        public Boolean Editar(Proveedor obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.RazonSocial == "")
            {
                Mensaje = "La Razon Social del Proveedor no puede estar vacio\n";
            }
            if (obj.Documento == "")
            {
                Mensaje = "El documento del Proveedor no puede estar vacio\n";
            }
            if (obj.Correo == "")
            {
                Mensaje = "El correo del Proveedor no puede estar vacio\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            { return objcd_Proveedor.Editar(obj, out Mensaje); }
        }



        public Boolean Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
