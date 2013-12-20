using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class clsPermiso
    {
        //atributos de la tabla  permiso
        private string m_idpermiso;
        private string m_fech_inicio;
        private string m_fech_final;
        private string m_motivo;
        private string m_DNI;


        public string Idpermiso
        {
            get { return m_idpermiso; }
            set { m_idpermiso = value; }
        }
        

        public string Fech_inicio
        {
            get { return m_fech_inicio; }
            set { m_fech_inicio = value; }
        }
        

        public string Fech_final
        {
            get { return m_fech_final; }
            set { m_fech_final = value; }
        }
        

        public string Motivo
        {
            get { return m_motivo; }
            set { m_motivo = value; }
        }
        

        public string DNI
        {
            get { return m_DNI; }
            set { m_DNI = value; }
        }

    }
}
