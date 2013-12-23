using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocios
{
   public class clsFacultad
    {
        private Manejador manejador = new Manejador();
        private CapaEntidad.clsFacultad Facultad = new CapaEntidad.clsFacultad();

        public DataTable ListarAsistenciaxEscuela(String estado)
        {
            List<Parametros> lst = new List<Parametros>();



            lst.Add(new Parametros("@escuela", estado));



            return manejador.Listado("sp_ASISTENCIA_ESCUELA", lst);


        }
        public DataTable ListarFaltaxEscuela(String estado)
        {
            List<Parametros> lst = new List<Parametros>();



            lst.Add(new Parametros("@escuela", estado));



            return manejador.Listado("FALTA_escuela", lst);


        }
       public DataTable ListarTardanzaxEscuela(String estado)
        {
            List<Parametros> lst = new List<Parametros>();



            lst.Add(new Parametros("@escuela", estado));



            return manejador.Listado("TARDANZA_ESCUELA", lst);


        }

    }
}
