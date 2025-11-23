using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {

        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje = "El nombre del Producto no puede estar vacio\n";
            }
            if (obj.Codigo == "")
            {
                Mensaje = "El Codigo del Producto no puede estar vacio\n";
            }
            if (obj.Descripcion == "")
            {
                Mensaje = "La Descripcion del Producto no puede estar vacio\n";
            }
           

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_Producto.Registrar(obj, out Mensaje);
            }
        }
        public Boolean Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje = "El nombre del Producto no puede estar vacio\n";
            }
            if (obj.Codigo == "")
            {
                Mensaje = "El Codigo del Producto no puede estar vacio\n";
            }
            if (obj.Descripcion == "")
            {
                Mensaje = "La Descripcion del Producto no puede estar vacio\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            { return objcd_Producto.Editar(obj, out Mensaje); }
        }



        public Boolean Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }

    }
}
