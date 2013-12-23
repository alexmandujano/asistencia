using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#region newusing
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
#endregion
namespace SistemaAsistencia
{
    public partial class frmreportdoc : Form
    {
        public string parametro;
        public Boolean BusDNI=false;
        public frmreportdoc()
        {
            InitializeComponent();
        }

        private void frmreportdoc_Load(object sender, EventArgs e)
        {
            if (BusDNI==true)
            {
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Alex\Documents\GitHub\asistencia\SistemaAsistencia\Reports\CrystalReport1.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue dni = new ParameterDiscreteValue();

                dni.Value = parametro;
                crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["FiltroxDni"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(dni);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = crystalrpt;
                crystalReportViewer1.Refresh();
            }else{
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load(@"C:\Users\Alex\Documents\GitHub\asistencia\SistemaAsistencia\Reports\EstadoDocente.rpt");

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue estado = new ParameterDiscreteValue();

                estado.Value = parametro;
                crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["EstadoDocente"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(estado);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = crystalrpt;
                crystalReportViewer1.Refresh();
 
            }
           
           

        }
    }
}
