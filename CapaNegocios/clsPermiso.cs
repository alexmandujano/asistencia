using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    class clsPermiso
    {
        private Manejador manejador = new Manejador();
       private CapaEntidad.clsPermiso permiso = new CapaEntidad.clsPermiso();
       
        public DataTable Mostrar_permiso_fecha(String campo, String campo1)
        {
            List<Parametros> lst = new List<Parametros>();
           // String mensaje;
            
            lst.Add(new Parametros("@fecha", campo));
            lst.Add(new Parametros("@DNI", campo1));
              return manejador.Listado("bus_permiso_fecha", lst);
                    }


      

        public String InsertarPermiso(CapaEntidad.clsPermiso permiso)
        {
            List<Parametros> lst = new List<Parametros>();
            String mensaje;
            try
            {

                lst.Add(new Parametros("@fech_inicio", permiso.Fech_inicio));
                lst.Add(new Parametros("@fech_final", permiso.Fech_final));
                lst.Add(new Parametros("@motivo", permiso.Motivo));
                lst.Add(new Parametros("@DNI", permiso.DNI));
            

                manejador.EjecutarSP("INSERTARPERMISO", ref lst);
                mensaje = "Permiso registrado..";

            }
            catch (Exception ex)
            {

                mensaje = "Error al Registrar, intente de nuevo o pongase al contacto del administrador, " + ex.Message;
            }

            return mensaje;
        }

    }
}
