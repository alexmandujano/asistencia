using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class clsDocente
    {
        //atributos

        private string m_DNI;
        private string m_ap_paterno;
        private string m_ap_materno;
        private string m_nombres;
        private DateTime m_fecha_nac;
        private string m_sexo;
        private string m_correo;
        private string m_ruta_foto;
        private char m_estado;

        
        public string DNI
        {
            get { return m_DNI; }
            set { m_DNI = value; }
        }
       

        public string Ap_paterno
        {
            get { return m_ap_paterno; }
            set { m_ap_paterno = value; }
        }
        

        public string Ap_materno
        {
            get { return m_ap_materno; }
            set { m_ap_materno = value; }
        }
       

        public string Nombres
        {
            get { return m_nombres; }
            set { m_nombres = value; }
        }

        public DateTime Fecha_nac
        {
            get { return m_fecha_nac; }
            set { m_fecha_nac = value; }
        }
        public string Sexo
        {
            get { return m_sexo; }
            set { m_sexo = value; }
        }
        

        public string Correo
        {
            get { return m_correo; }
            set { m_correo = value; }
        }

        public string Ruta_foto
        {
            get { return m_ruta_foto; }
            set { m_ruta_foto = value; }
        }


        public char Estado
        {
            get { return m_estado; }
            set { m_estado = value; }
        }
       




    }
}
