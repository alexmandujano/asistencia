﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SistemaAsistencia
{
    public partial class frmPrincipal : Form
    {
        string OpcionTipo="";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelcurso.Visible = true;
            paneldocente.Visible = false;
            panelasistencia.Visible = false;
            panelreporte.Visible = false;
        }

        private void btnreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmDocente docente = new frmDocente();
            docente.TopLevel = false;
            docente.FormBorderStyle = FormBorderStyle.None;
            docente.Dock = DockStyle.None;
            this.panelprincipal.Controls.Add(docente);
            this.panelprincipal.Tag = docente;
            docente.Show();
        }

        private void btndis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmdisponibilidad disponibilidad = new frmdisponibilidad();
            disponibilidad.TopLevel = false;
            disponibilidad.FormBorderStyle = FormBorderStyle.None;
            disponibilidad.Dock = DockStyle.Left;
            this.panelprincipal.Controls.Add(disponibilidad);
            this.panelprincipal.Tag = disponibilidad;
            disponibilidad.Show();
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmCargaHoraria cargahoraria = new frmCargaHoraria();
            cargahoraria.TopLevel = false;
            cargahoraria.FormBorderStyle = FormBorderStyle.None;
            cargahoraria.Dock = DockStyle.None;
            this.panelprincipal.Controls.Add(cargahoraria);
            this.panelprincipal.Tag = cargahoraria;
            cargahoraria.Show();
        }

        private void btndocente_Click(object sender, EventArgs e)
        {
            panelcurso.Visible = false;
            paneldocente.Visible = true;
            panelasistencia.Visible = false;
            panelreporte.Visible = false;
            
        }

        private void btnasistencia_Click(object sender, EventArgs e)
        {
            panelcurso.Visible = false;
            paneldocente.Visible = false;
            panelasistencia.Visible = true;
            panelreporte.Visible = false;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            panelcurso.Visible = false;
            paneldocente.Visible = false;
            panelasistencia.Visible = false;
            panelreporte.Visible = true;
        }

        private void btnagrecur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmCurso curso = new frmCurso();
            curso.TopLevel = false;
            curso.FormBorderStyle = FormBorderStyle.None;
            curso.Dock = DockStyle.None;
            this.panelprincipal.Controls.Add(curso);
            this.panelprincipal.Tag = curso;
            curso.Show();
        }

        private void btnasigcur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmAsignacionCurso asignarcurso = new frmAsignacionCurso();
            asignarcurso.TopLevel = false;
            asignarcurso.FormBorderStyle = FormBorderStyle.None;
            asignarcurso.Dock = DockStyle.None ;
            this.panelprincipal.Controls.Add(asignarcurso);
            this.panelprincipal.Tag = asignarcurso;
            asignarcurso.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            String opcion = e.Node.Name;
            string ParametroDocente="";
            string ParametroFacultad="";
            string ParametroFacultadTipo = "";
            string ParametroMes = "";
            string ParametroMesTipo = "";
            Boolean BusquedaPorTiempo=false;
            Boolean DniNombre = false;
          
                if (opcion == "menudni")
                {
                    ParametroDocente = Interaction.InputBox("Ingrese su DNI");
                    DniNombre = true;
                }
                if (opcion == "menunom")
                {
                    ParametroDocente = Interaction.InputBox("Ingrese Nombre o Ape Paterno");
                    DniNombre = true;
                }
                if (opcion == "menuact") ParametroDocente = "A";
                if (opcion == "menuina") ParametroDocente = "I";
                if (opcion == "menuvac") ParametroDocente = "V";
                if (opcion == "menutod")
                {
                    DniNombre = true;
                    ParametroDocente = "Todos";
                }
                if (opcion == "facasi")
                {
                    ParametroFacultad = Interaction.InputBox("Ingrese Facultad o Escuela");
                    ParametroFacultadTipo = "Asistencias";
                }
                if (opcion == "facfal")
                {
                    ParametroFacultad = Interaction.InputBox("Ingrese Facultad o Escuela");
                    ParametroFacultadTipo = "Faltas";
                }
                if (opcion == "factar")
                {
                    ParametroFacultad = Interaction.InputBox("Ingrese Facultad o Escuela");
                    ParametroFacultadTipo = "Tardanzas";
                }
                if (opcion == "menasi")
                {
                    ParametroMes = Interaction.InputBox("Ingrese Mes","asistencia");
                    ParametroMesTipo = "Asistencias";
                    BusquedaPorTiempo = true;
                }
                if (opcion == "menfal")
                {
                    ParametroMes = Interaction.InputBox("Ingrese Mes","falta");
                    ParametroMesTipo = "Faltas";
                    BusquedaPorTiempo = true;
                }
                if (opcion == "mentar")
                {
                    ParametroMes = Interaction.InputBox("Ingrese Mes", "tardanza");
                    ParametroMesTipo = "Tardanzas";
                    BusquedaPorTiempo = true;
                }
                if (opcion=="fecasi" || opcion=="fecfal" || opcion =="fectar" )
                {
                    if (this.panelprincipal.Controls.Count > 0)this.panelprincipal.Controls.RemoveAt(0);
                    OpcionTipo = opcion;
                    pnlbusfech.Visible = true;
                    return;
                   


                }
                
            if (BusquedaPorTiempo == false)
             {
                if (this.panelprincipal.Controls.Count > 0)
                    this.panelprincipal.Controls.RemoveAt(0);
                frmbus FormularioBuscar = new frmbus();
                FormularioBuscar.TopLevel = false;
                FormularioBuscar.FormBorderStyle = FormBorderStyle.None;
                FormularioBuscar.Dock = DockStyle.None;
                this.panelprincipal.Controls.Add(FormularioBuscar);
                this.panelprincipal.Tag = FormularioBuscar;
                FormularioBuscar.ParametroDocente = ParametroDocente;
                FormularioBuscar.ParametroFacultad = ParametroFacultad;
                FormularioBuscar.ParametroFacultadTipo = ParametroFacultadTipo;
                FormularioBuscar.DniNombre = DniNombre;
                FormularioBuscar.Show();
            }
            else
            {
                if (this.panelprincipal.Controls.Count > 0)
                    this.panelprincipal.Controls.RemoveAt(0);
                frmBuscarPorTiempo frmBuscarPorTiempo = new frmBuscarPorTiempo();
                frmBuscarPorTiempo.TopLevel = false;
                frmBuscarPorTiempo.FormBorderStyle = FormBorderStyle.None;
                frmBuscarPorTiempo.Dock = DockStyle.None;
                this.panelprincipal.Controls.Add(frmBuscarPorTiempo);
                this.panelprincipal.Tag = frmBuscarPorTiempo;

                frmBuscarPorTiempo.ParametroMes = ParametroMes;
                frmBuscarPorTiempo.ParametroMesTipo = ParametroMesTipo;
                frmBuscarPorTiempo.Show();

            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DateTime fechainicial = dtpini.Value;
            DateTime Fechafinal = dtpfin.Value;
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            frmBuscarPorTiempo frmBuscarPorTiempo = new frmBuscarPorTiempo();
            frmBuscarPorTiempo.TopLevel = false;
            frmBuscarPorTiempo.FormBorderStyle = FormBorderStyle.None;
            frmBuscarPorTiempo.Dock = DockStyle.None;
            this.panelprincipal.Controls.Add(frmBuscarPorTiempo);
            this.panelprincipal.Tag = frmBuscarPorTiempo;
            frmBuscarPorTiempo.fechaini = fechainicial;
            frmBuscarPorTiempo.fechafin = Fechafinal;
            frmBuscarPorTiempo.ParametroMesTipo = OpcionTipo; // pasamos el tipo de consulta al formualrio buscar
            frmBuscarPorTiempo.Show();
            pnlbusfech.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlbusfech.Visible = false;
        }

        private void pnlbusfech_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
