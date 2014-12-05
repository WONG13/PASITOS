using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_NuevoDonativo : PASITOS.I_Plantilla
    {
        public bool Error;
        O_Donativo Obj_Don;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Cargar;
        
        public I_NuevoDonativo()
        {
            InitializeComponent();
            CB_CargarDatos();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

        }

        private void CB_CargarDatos()
        {
            Cargar = new DataTable();
            Cargar = ObjAD.ConsultaBeneficiarioCB();
            CB_Beneficiario.DisplayMember = "Nombre_Ben";
            CB_Beneficiario.ValueMember = "ID_Beneficiario";
            CB_Beneficiario.DataSource = Cargar;

            Cargar = ObjAD.ConsultaDonanteCB();
            CB_Donante.DisplayMember = "Nombre_Don";
            CB_Donante.ValueMember = "ID_Donante";
            CB_Donante.DataSource = Cargar;

            Cargar = ObjAD.ConsultaTipoDonCB();
            CB_TipoDon.DisplayMember = "TipoDonativo";
            CB_TipoDon.ValueMember = "ID_Tipo_Donativo";
            CB_TipoDon.DataSource = Cargar;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Error = false;
            ErrorDatos.Clear();
            if (lbl3.Text == "")
            {
                ErrorDatos.SetError(lbl3, "Campo Vacio");
                Error = true;
            }
            if (lbl2.Text == "")
            {
                ErrorDatos.SetError(lbl2, "Campo Vacio");
                Error = true;
            }
            if (lbl1.Text == "")
            {
                ErrorDatos.SetError(lbl1, "Campo Vacio");
                Error = true;
            }
            if (txtEstadoDon.Text == "")
            {
                ErrorDatos.SetError(txtEstadoDon, "Campo Vacio");
                Error = true;
            }
            if (txtUsoDon.Text == "")
            {
                ErrorDatos.SetError(txtUsoDon, "Campo Vacio");
                Error = true;
            }
            if (Error == false)
            {
                CapturarDatos();
                ObjAD.NuevoDatosDonativo(Obj_Don);

                MessageBox.Show("Datos Donativo Agregado");
                txtPerio.Clear();
                txtCantDon.Clear();
                txtFormPag.Clear();
                CB_Beneficiario.SelectedIndex = 0;
                CB_Donante.SelectedIndex = 0;
                CB_TipoDon.SelectedIndex = 0;
                
                txtEstadoDon.Clear();
                txtUsoDon.Clear();
                txtPerio.Focus();
            }

            
        }
        private void CapturarDatos()
        {
            Obj_Don = new O_Donativo();
            Obj_Don.ID_Donante = Int16.Parse(CB_Donante.SelectedValue.ToString());
            Obj_Don.ID_Tipo_Donativo = Int16.Parse(CB_TipoDon.SelectedValue.ToString());
            Obj_Don.Fecha_inicio = dateTimePicker1.Text;
            Obj_Don.Periodicidad = txtPerio.Text;
            Obj_Don.Don_monetario = Int16.Parse(txtCantDon.Text);
            Obj_Don.Forma_pago = txtFormPag.Text;
            Obj_Don.ID_beneficiario = Int16.Parse(CB_Beneficiario.SelectedValue.ToString());
            Obj_Don.Estado = txtEstadoDon.Text;
            Obj_Don.UsoDon = txtUsoDon.Text;
        }
    }
}
