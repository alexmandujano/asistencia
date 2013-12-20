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
        public string docenteparametro ;
        public Boolean DniNombre = false;

        private void reporteDocente()
        {
            DataTable dt = new DataTable();

            dt = OpcionDocente.Listar(docenteparametro);
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
        private void estados()
        {
            DataTable dt = new DataTable();

            dt = OpcionDocente.ListarEstado(docenteparametro);
            dtgbus.DataSource = dt;
        }
        public frmbus()
        {
            InitializeComponent();
        }
         
        private void frmbus_Load(object sender, EventArgs e)
        {
            if (DniNombre==true)
            {
                reporteDocente(); 
            }else{
                estados();
            } 


            
        }
    }
}
