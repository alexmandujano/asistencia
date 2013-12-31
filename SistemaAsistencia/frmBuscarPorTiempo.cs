using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SistemaAsistencia
{
    public partial class frmBuscarPorTiempo : Form
    {
        private CapaNegocios.clsFacultad OpcionFacultad = new CapaNegocios.clsFacultad();
        private CapaEntidad.clsFacultad facultad = new CapaEntidad.clsFacultad();
  
        public string ParametroMes;
        public string ParametroMesTipo;
        public DateTime fechaini;
        public DateTime fechafin;

        public void ListarfaltasxMes(String mes)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarAsistenciaxMes(mes);
            dtgbus.DataSource = dt;
        
        }
        public void ListarAsistenciaxMes(String mes)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarFaltaxMes(mes);
            dtgbus.DataSource = dt;
        
        }
        public void ListarTardanzasxMes(String mes)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarTardanzaxMes(mes);
            dtgbus.DataSource = dt;

        }
        public void ListarAsistenciaEntreFechas(DateTime FECHA1, DateTime FECHA2)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarAsistenciaEntreFechas(FECHA1,FECHA2);
            dtgbus.DataSource = dt; 
        }
        public void ListarFaltaEntreFechas(DateTime FECHA1, DateTime FECHA2)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarFaltaEntreFechas(FECHA1, FECHA2);
            dtgbus.DataSource = dt;
        }
        public void ListarTardanzaEntreFechas(DateTime FECHA1, DateTime FECHA2)
        {
            DataTable dt = new DataTable();
            dt = OpcionFacultad.ListarTardanzaEntreFechas(FECHA1, FECHA2);
            dtgbus.DataSource = dt;
        }

        public frmBuscarPorTiempo()
        {
            InitializeComponent();
        }

        private void frmBuscarPorTiempo_Load(object sender, EventArgs e)
        {
           if (ParametroMesTipo == "Asistencias") ListarAsistenciaxMes(ParametroMes);
           if (ParametroMesTipo == "Faltas") ListarfaltasxMes(ParametroMes);
           if (ParametroMesTipo == "Tardanzas") ListarTardanzasxMes(ParametroMes);
           if (ParametroMesTipo == "fecasi") ListarAsistenciaEntreFechas(fechaini,fechafin);
           if (ParametroMesTipo == "fecfal") ListarFaltaEntreFechas(fechaini, fechafin);
           if (ParametroMesTipo == "fectar") ListarTardanzaEntreFechas(fechaini, fechafin);
        
        } 
    }
}
