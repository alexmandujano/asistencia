using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
   public class clsHecho
    {
        //atributos de la tabla hecho
        private string m_idhecho;
        private string m_descripcion;
        private string m_fech_inicio;
        private string m_fech_fin;
        private string m_id_tipo_hecho;

        //atributos de la tabla hecho_facultad
        private string m_id_hecho_facu;
        private string m_idfacu;

        //atributos de la tabla tipo_hecho
        private string m_tipo_hecho;



        public string Idhecho
        {
            get { return m_idhecho; }
            set { m_idhecho = value; }
        }
        

        public string Descripcion
        {
            get { return m_descripcion; }
            set { m_descripcion = value; }
        }
        

        public string Fech_inicio
        {
            get { return m_fech_inicio; }
            set { m_fech_inicio = value; }
        }

        public string Fech_fin
        {
            get { return m_fech_fin; }
            set { m_fech_fin = value; }
        }
        

        public string Id_tipo_hecho
        {
            get { return m_id_tipo_hecho; }
            set { m_id_tipo_hecho = value; }
        }

     

        public string Id_hecho_facu
        {
            get { return m_id_hecho_facu; }
            set { m_id_hecho_facu = value; }
        }
        

        public string Idfacu
        {
            get { return m_idfacu; }
            set { m_idfacu = value; }
        }

       
        public string Tipo_hecho
        {
            get { return m_tipo_hecho; }
            set { m_tipo_hecho = value; }
        }
    }
}
