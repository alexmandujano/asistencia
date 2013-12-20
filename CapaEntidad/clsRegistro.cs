using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
   public  class clsRegistro
    {
        //atributos de la tabla registro
        private string m_idregistro;
        private string m_fecha;
        private string m_hora_inic;
        private string m_hora_fin;

        //atributos de la tabla registro_horario
        private string m_id_reg_horario;
        private string m_idhorario;

        public string Idregistro
        {
            get { return m_idregistro; }
            set { m_idregistro = value; }
        }
        

        public string Fecha
        {
            get { return m_fecha; }
            set { m_fecha = value; }
        }
        

        public string Hora_inic
        {
            get { return m_hora_inic; }
            set { m_hora_inic = value; }
        }
        

        public string Hora_fin
        {
            get { return m_hora_fin; }
            set { m_hora_fin = value; }
        }

        

        public string Id_reg_horario
        {
            get { return m_id_reg_horario; }
            set { m_id_reg_horario = value; }
        }
        

        public string Idhorario
        {
            get { return m_idhorario; }
            set { m_idhorario = value; }
        }


    }
}
