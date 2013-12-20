using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
  public  class clsHorario
    {
        //atributos de la tabla horario
        private string m_idhorario;
        private string m_dia;
        private string m_hora_inic;
        private string m_hora_fin;
        private string m_idcurso_docente;

        public string Idhorario
        {
            get { return m_idhorario; }
            set { m_idhorario = value; }
        }

        public string Dia
        {
            get { return m_dia; }
            set { m_dia = value; }
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
        

        public string Idcurso_docente
        {
            get { return m_idcurso_docente; }
            set { m_idcurso_docente = value; }
        }
        

    }
}
