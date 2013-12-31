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

       //desde aqui aremos las busquedas por tiempo

       public DataTable ListarAsistenciaxMes(String mes)
       {
           List<Parametros> lst = new List<Parametros>();
           lst.Add(new Parametros("@mes", mes));
           return manejador.Listado("sp_ASISTENCIA_MES", lst);
       }

    public DataTable ListarFaltaxMes(String mes)
       { 
           List<Parametros> lst = new List<Parametros>();
           lst.Add(new Parametros("@mes", mes));
           return manejador.Listado("sp_FALTA_MES", lst);
       }
    public DataTable ListarTardanzaxMes(String mes)
    {
        List<Parametros> lst = new List<Parametros>();
        lst.Add(new Parametros("@mes", mes));
        return manejador.Listado("sp_TARDANZA_MES", lst);
    }

       //entre fechas

         public DataTable ListarAsistenciaEntreFechas(DateTime fecha1 ,DateTime fecha2)
         {
                List<Parametros> lst = new List<Parametros>();
                lst.Add(new Parametros("@FECHA1", fecha1));
                lst.Add(new Parametros("@FECHA2", fecha2));
                return manejador.Listado("sp_ASISTENCIA_FECHAS", lst);
        }
        public DataTable ListarFaltaEntreFechas(DateTime fecha1 ,DateTime fecha2)
         {
                List<Parametros> lst = new List<Parametros>();
                lst.Add(new Parametros("@FECHA1", fecha1));
                lst.Add(new Parametros("@FECHA2", fecha2));
                return manejador.Listado("sp_FALTA_FECHAS", lst);
        }
        public DataTable ListarTardanzaEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@FECHA1", fecha1)); 
            lst.Add(new Parametros("@FECHA2", fecha2));
            return manejador.Listado("sp_TARDANZA_FECHAS", lst);
        }
        
    }
}
