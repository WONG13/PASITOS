﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_NuevoDonante_Contacto : PASITOS.I_Plantilla
    {
        public DelegadoP2 DelP2;

        public bool Error;
        O_Donante Obj_Don;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Cargar;
        public int x;
        //int Accion;
        int ID=-1;
        int Forma=0;
        public I_NuevoDonante_Contacto(int ID, int Forma)
        {
            InitializeComponent();
            CB_CargarDatos();
            this.Forma = Forma;
            if (ID != -1 && Forma != -1)
            {
                this.ID = ID;
                
                CargarDatos(ID);

            }
        }

        private void CargarDatos(int ID)
        {
            ObjDT = ObjAD.ConsultaBusquedaDonante(ID);
           
            txtNombre.Text=ObjDT.Rows[0][1].ToString();
            CB_TipoDon.SelectedIndex = int.Parse(ObjDT.Rows[0][2].ToString())-1;
            txtDireccion.Text = ObjDT.Rows[0][3].ToString();
            txtRFC.Text = ObjDT.Rows[0][4].ToString();
            txtInfo.Text = ObjDT.Rows[0][5].ToString();
            CB_Estatus.SelectedIndex = int.Parse(ObjDT.Rows[0][6].ToString())-1;
           
        }


        private void CB_CargarDatos()
        {
            Cargar = new DataTable();
            Cargar = ObjAD.ConsultaEstatusDon();
            CB_Estatus.DisplayMember = "Estatus";
            CB_Estatus.ValueMember = "ID_Estatus";
            CB_Estatus.DataSource = Cargar;

            Cargar = ObjAD.ConsultaTipoDon();
            CB_TipoDon.DisplayMember = "TipoDon";
            CB_TipoDon.ValueMember = "ID_Tipo_Don";
            CB_TipoDon.DataSource = Cargar;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Error = false;
            ErrorDatos.Clear();
            if (txtNombre.Text == "")
            {
                ErrorDatos.SetError(txtNombre, "Campo Vacio");
                Error = true;
            }
            if (txtDireccion.Text == "")
            {
                ErrorDatos.SetError(txtDireccion, "Campo Vacio");
                Error = true;
            }
            if (txtRFC.Text == "")
            {
                ErrorDatos.SetError(txtRFC, "Campo Vacio");
                Error = true;
            }
            if (txtInfo.Text == "")
            {
                ErrorDatos.SetError(txtInfo, "Campo Vacio");
                Error = true;
            }
           

            if (Error == false)
            {
                CapturarDatos();
                if (ID==-1)
                {
                    ObjAD.NuevoDonante(Obj_Don);

                    MessageBox.Show("Donante Agregado");
                    txtNombre.Clear();
                    CB_TipoDon.SelectedIndex = 0;
                    CB_Estatus.SelectedIndex = 0;
                    txtDireccion.Clear();
                    txtRFC.Clear();
                    txtInfo.Clear();
                    txtNombre.Focus();

                    x = ObjAD.ConsultaIDDonante();
                    this.Visible = false;

                    NuevoContacto = new I_NuevoContacto(x, 0,0);
                    NuevoContacto.DelP2 = DelP2;
                    DelP2(NuevoContacto);
                }
                else
                {
                    ObjAD.ActualizarDonante(Obj_Don,ID);
                    MessageBox.Show("Datos Actualizados");
                    RegresoForma();



                }
            }
          

        }

        

        
        private void CapturarDatos()
        {
            Obj_Don = new O_Donante();
            Obj_Don.Nom_Don = txtNombre.Text;
            Obj_Don.ID_Tipo_Don = Int16.Parse(CB_TipoDon.SelectedValue.ToString());
            Obj_Don.Direccion_Don = txtDireccion.Text;
            Obj_Don.RFC_Don = txtRFC.Text;
            Obj_Don.Info_Don = txtInfo.Text;
            Obj_Don.Estatus_Don = Int16.Parse(CB_Estatus.SelectedValue.ToString());
        }


        I_NuevoContacto NuevoContacto;
        I_MenuPrincipal MenuPrincipal;
        private void I_NuevoDonante_Contacto_Load(object sender, EventArgs e)
        {
           
           
          
        }
        CatalogoAspirantesDcs CatalogoAspirantes;
        CatalogoDonantesD CatalogoDonantes;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            RegresoForma();
            //MenuPrincipal = new I_MenuPrincipal();
            //MenuPrincipal.DelP2 = DelP2;
            //DelP2(MenuPrincipal);
        }

        private void RegresoForma()
        {
            switch (Forma)
            {
                case 0:
                    MenuPrincipal = new I_MenuPrincipal();
                    MenuPrincipal.DelP2 = DelP2;
                    DelP2(MenuPrincipal);
                    break;

                // CatalogoAspirantesD
                case 1:
                    CatalogoAspirantes = new CatalogoAspirantesDcs();
                    CatalogoAspirantes.DelP2 = DelP2;
                    DelP2(CatalogoAspirantes);
                    break;
                // CatalogoDonantesD
                case 2:
                    CatalogoDonantes = new CatalogoDonantesD();
                    CatalogoDonantes.DelP2 = DelP2;
                    DelP2(CatalogoDonantes);
                    break;


            }
        }

        


    }
}
