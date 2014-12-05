using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_NuevoBeneficiario : PASITOS.I_Plantilla
    {

        public bool Error;
        O_Beneficiario Obj_Ben;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Cargar;

        public I_NuevoBeneficiario()
        {
            InitializeComponent();
            CB_GeneroCargar();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void CB_GeneroCargar()
        {
            Cargar = new DataTable();
            Cargar = ObjAD.ConsultaGenero();
            CB_Genero.DisplayMember = "Genero";
            CB_Genero.ValueMember = "ID_Genero";
            CB_Genero.DataSource = Cargar;
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
            if (txtPadecimiento.Text == "")
            {
                ErrorDatos.SetError(txtPadecimiento, "Campo Vacio");
                Error = true;
            }
            if (txtNecesidades.Text == "")
            {
                ErrorDatos.SetError(txtNecesidades, "Campo Vacio");
                Error = true;
            }

            if (Error==false)
            {
                CapturarDatos();
                ObjAD.NuevoBeneficiario(Obj_Ben);

                MessageBox.Show("Beneficiario Agregado");
                txtNombre.Clear();
                CB_Genero.SelectedIndex = 0;
                txtPadecimiento.Clear();
                txtNecesidades.Clear();
                txtNombre.Focus();
            }
           

        }


        private void CapturarDatos()
        {
            Obj_Ben = new O_Beneficiario();
            Obj_Ben.Nombre_Ben = txtNombre.Text;
            Obj_Ben.Fec_Nac_Ben = dateTimePicker1.Text;
            Obj_Ben.Genero_Ben = Int16.Parse(CB_Genero.SelectedValue.ToString());
            Obj_Ben.Padecimiento_Ben = txtPadecimiento.Text;
            Obj_Ben.Necesidad_Ben = txtNecesidades.Text;
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
