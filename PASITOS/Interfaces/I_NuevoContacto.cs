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
        public DelegadoP2 DelP2;

        public bool Error;
        O_Contacto Obj_Con;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();

        int Forma=0;
        int Accion;
        int ID = -1;
        public I_NuevoContacto(int ID, int Forma, int Accion)
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.Accion = Accion;
           this.ID = ID;
           this.Forma = Forma;
           if (Forma != 0&& Accion==1)
           {
               
               CargarDatos(ID);
           }
            
        }

        private void CargarDatos(int ID)
        {
            ObjDT = ObjAD.ConsultaBusquedaContacto(ID);

            txtNombre.Text = ObjDT.Rows[0][2].ToString();
            txtTelefono.Text=ObjDT.Rows[0][3].ToString();
            txtCorreo.Text=ObjDT.Rows[0][4].ToString();
            txtPuesto.Text=ObjDT.Rows[0][5].ToString();
            dateTimePicker1.Text=ObjDT.Rows[0][6].ToString();
            txtHoraAten.Text=ObjDT.Rows[0][7].ToString();
            txtInformacion.Text=ObjDT.Rows[0][8].ToString();
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
                if (Accion==0)
                {
                ObjAD.NuevoContacto(Obj_Con);

                MessageBox.Show("Contacto Agregado");
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtPuesto.Clear();
                txtHoraAten.Clear();
                txtInformacion.Clear();
                txtNombre.Focus();
                }
                else
                {
                    ObjAD.ActualizarContacto(Obj_Con, ID);
                    MessageBox.Show("Datos Actualizados");
                    RegresoForma();
                }
            }
        }



        private void CapturarDatos()
        {
            Obj_Con = new O_Contacto();
            Obj_Con.ID_Donante = ID;
            Obj_Con.Nombre_Con = txtNombre.Text;
            Obj_Con.Tel_Con = txtTelefono.Text;
            Obj_Con.Correo_Con = txtCorreo.Text;
            Obj_Con.Puesto_Con = txtPuesto.Text;
            Obj_Con.Cumpleaños_Con = dateTimePicker1.Text;
            Obj_Con.Hora_Atencion = txtHoraAten.Text;
            Obj_Con.Info_Con = txtInformacion.Text;
        }
        I_MenuPrincipal MenuPrincipal;
        CatalogoAspirantesDcs CatalogoAspirantes;
        CatalogoDonantesD CatalogoDonantes;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            RegresoForma();
           

         
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
