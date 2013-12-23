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
    class clsHecho
    {
        private Manejador manejador = new Manejador();
        private CapaEntidad.clsHecho hecho = new CapaEntidad.clsHecho();

        public DataTable Mostrar_hecho(String fecha)
        {
            List<Parametros> lst = new List<Parametros>();
            // String mensaje;

            lst.Add(new Parametros("@fecha", fecha));
            return manejador.Listado("sp_BUSCAR_ACTIVOS", lst);
        }


        public DataTable Mostrar_hecho_DNI(String DNI)
        {
            List<Parametros> lst = new List<Parametros>();
            // String mensaje;

            lst.Add(new Parametros("@DNI", DNI));
            return manejador.Listado("sp_BUSCAR_ACTIVOS", lst);
        }


        public String InsertarHecho(CapaEntidad.clsHecho hecho)
        {
            List<Parametros> lst = new List<Parametros>();
            String mensaje;
            try
            {

                lst.Add(new Parametros("@desripcion", hecho.Descripcion));
                lst.Add(new Parametros("@fech_inicio", hecho.Fech_inicio));
                lst.Add(new Parametros("@fech_fin", hecho.Fech_fin));
                lst.Add(new Parametros("@motivo", hecho.Id_tipo_hecho));
             
                
                manejador.EjecutarSP("INSERTARHECHO", ref lst);
                mensaje = "Hecho registrado..";

            }
            catch (Exception ex)
            {

                mensaje = "Error al Registrar, intente de nuevo o pongase al contacto del administrador, " + ex.Message;
            }

            return mensaje;
        }

    }
}
