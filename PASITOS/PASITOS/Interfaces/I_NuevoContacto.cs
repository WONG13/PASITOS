using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_NuevoContacto : PASITOS.I_Plantilla
    {
        public bool Error;
        O_Contacto Obj_Con;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        int x;
      

        public I_NuevoContacto(int x)
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
           this.x = x;
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
            if (txtTelefono.Text == "")
            {
                ErrorDatos.SetError(txtTelefono, "Campo Vacio");
                Error = true;
            }
            if (txtCorreo.Text == "")
            {
                ErrorDatos.SetError(txtCorreo, "Campo Vacio");
                Error = true;
            }
            if (txtPuesto.Text == "")
            {
                ErrorDatos.SetError(txtPuesto, "Campo Vacio");
                Error = true;
            }
            if (txtHoraAten.Text == "")
            {
                ErrorDatos.SetError(txtHoraAten, "Campo Vacio");
                Error = true;
            }

            if (Error == false)
            {
                CapturarDatos();
                x = ObjAD.ConsultaIDDonante();

                ObjAD.NuevoContacto(Obj_Con, x);

                MessageBox.Show("Contacto Agregado");
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtPuesto.Clear();
                txtHoraAten.Clear();
                txtInformacion.Clear();
                txtNombre.Focus();
            }
        }
        private void CapturarDatos()
        {
            Obj_Con = new O_Contacto();
            Obj_Con.Nombre_Con = txtNombre.Text;
            Obj_Con.Tel_Con = txtTelefono.Text;
            Obj_Con.Correo_Con = txtCorreo.Text;
            Obj_Con.Puesto_Con = txtPuesto.Text;
            Obj_Con.Cumpleaños_Con = dateTimePicker1.Text;
            Obj_Con.Hora_Atencion = txtHoraAten.Text;
            Obj_Con.Info_Con = txtInformacion.Text;
        }

        

    }
}
