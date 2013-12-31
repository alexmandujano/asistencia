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
    public partial class frmbus : Form
    {
        private CapaNegocios.clsDocente OpcionDocente = new CapaNegocios.clsDocente();
        private CapaEntidad.clsDocente docente = new CapaEntidad.clsDocente();
        private CapaNegocios.clsFacultad OpcionFacultad = new CapaNegocios.clsFacultad();
        private CapaEntidad.clsFacultad facultad = new CapaEntidad.clsFacultad();
        public string ParametroDocente;
        
        public string ParametroFacultad;
        public string ParametroFacultadTipo;
        public Boolean DniNombre = false;

        private void ReporteDocente()
        {
            DataTable dt = new DataTable();

            dt = OpcionDocente.Listar(ParametroDocente);
            dtgbus.DataSource = dt;
            //recorremos el data table
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
              
            //    dtgbus.Rows.Add(dt.Rows[i][0]);
            //    dtgbus.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
            //    dtgbus.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
            //    dtgbus.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
            //    dtgbus.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
            //    dtgbus.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
            //    dtgbus.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
            //    dtgbus.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
            //}
        }
        private void EstadosDocente()
        {
            DataTable dt = new DataTable();

            dt = OpcionDocente.ListarEstado(ParametroDocente);
            dtgbus.DataSource = dt;
        }
        private void AsistenciaEscuela()
        { 
            DataTable dt = new DataTable();

            dt = OpcionFacultad.ListarAsistenciaxEscuela(ParametroFacultad);
            dtgbus.DataSource = dt;
        
        }
        private void FaltaxEscuela()
        {
            DataTable dt = new DataTable();

            dt = OpcionFacultad.ListarFaltaxEscuela(ParametroFacultad);
            dtgbus.DataSource = dt;

        }
        private void TardanzaxEscuela()
        {
            DataTable dt = new DataTable();

            dt = OpcionFacultad.ListarTardanzaxEscuela(ParametroFacultad);
            dtgbus.DataSource = dt;

        }
        public frmbus()
        {
            InitializeComponent();
        }
         
        private void frmbus_Load(object sender, EventArgs e)
        {
            if (ParametroDocente !="") {
            
                  if (DniNombre==true)
                    {
                        if (ParametroDocente == "Todos") ParametroDocente = ""; //esto es Para q busque a todos
                        ReporteDocente(); 
                    }else{
                        EstadosDocente();
                    } 
             }
            if (ParametroFacultadTipo=="Asistencias")AsistenciaEscuela();
            if (ParametroFacultadTipo == "Faltas") FaltaxEscuela();
            if (ParametroFacultadTipo == "Tardanzas") TardanzaxEscuela();




            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (DniNombre==true)
            {
               
               frmreportdoc informe = new frmreportdoc();
               informe.parametro = ParametroDocente;
               informe.BusDNI = true;
               informe.Show();
               DniNombre = false;
            }else{
               
                frmreportdoc informe = new frmreportdoc();
                informe.parametro = ParametroDocente;
                informe.BusDNI = false;
                 informe.Show();
                DniNombre = false;
                
            } 

        }

        private void dtgbus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
