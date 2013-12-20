using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class clsCurso
    {
        //atributos tabla curso

        private string m_idcurso;
        private string m_curso;
        private string m_idciclo;
        
        //atributos tabla curso_docente
        private string m_idcurso_docente;
        private string m_grupo;
        private string m_fecha_inicio;
        private string m_fecha_fin;

        public string Fecha_fin
        {
            get { return m_fecha_fin; }
            set { m_fecha_fin = value; }
        }
        private string m_DNI;
                

        public string Idcurso
        {
            get { return m_idcurso; }
            set { m_idcurso = value; }
        }
      

        public string Curso
        {
            get { return m_curso; }
            set { m_curso = value; }
        }

        public string Idciclo
        {
            get { return m_idciclo; }
            set { m_idciclo = value; }
        }


        public string Idcurso_docente
        {
            get { return m_idcurso_docente; }
            set { m_idcurso_docente = value; }
        }
    
        public string Grupo
        {
            get { return m_grupo; }
            set { m_grupo = value; }
        }

        public string Fecha_inicio
        {
            get { return m_fecha_inicio; }
            set { m_fecha_inicio = value; }
        }

        public string DNI
        {
            get { return m_DNI; }
            set { m_DNI = value; }
        }
    }
}
