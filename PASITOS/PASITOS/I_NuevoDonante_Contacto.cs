using System;
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
        public bool Error;
        O_Donante Obj_Don;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Cargar;
        public int x;

        public I_NuevoDonante_Contacto()
        {
            InitializeComponent();
            CB_CargarDatos();
            
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

                Del(x);

                new I_NuevoContacto(x);
            }
          

        }

        Delegado2 Del;

        public void CargarDelegado(I_FormaPrincipal x)
        {
            Del = new Delegado2(x.CambioInterfazContacto);
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

        private void I_NuevoDonante_Contacto_Load(object sender, EventArgs e)
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }


    }
}
