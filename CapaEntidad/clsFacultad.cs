using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
   public class clsFacultad
    {
    //atributos tabla facultad
        private string m_idfacu;
        private string m_facultad;
                
    // atributos escuela
        private string m_idescuela;
        private string m_escuela;
              
    //atributos tablaciclo 
        private string m_idciclo;
        private string m_anio;
        private string m_ciclo;
            
        
        public string Idfacu
        {
            get { return m_idfacu; }
            set { m_idfacu = value; }
        }

        public string Facultad
        {
            get { return m_facultad; }
            set { m_facultad = value; }
        }

        public string Idescuela
        {
            get { return m_idescuela; }
            set { m_idescuela = value; }
        }

        public string Escuela
        {
            get { return m_escuela; }
            set { m_escuela = value; }
        }

        public string Idciclo
        {
            get { return m_idciclo; }
            set { m_idciclo = value; }
        }

        public string Anio
        {
            get { return m_anio; }
            set { m_anio = value; }
        }

        public string Ciclo
        {
            get { return m_ciclo; }
            set { m_ciclo = value; }
        }

    }
}
