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
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        public bool Error;
        O_Beneficiario Obj_Ben;
        O_Tutor Obj_Tut;
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Cargar;
        int ID = -1;
        int Forma = 0;
        int Accion;

        public I_NuevoBeneficiario(int ID, int Forma, int Accion)
        {
            InitializeComponent();
            CB_GeneroCargar();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            this.Forma = Forma;
            if (Accion == 1)
            {
                this.ID = ID;
            }

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
            if (i_NuevoTutor1.txtNombretut.Text == "")
            {
                ErrorDatos.SetError(i_NuevoTutor1.txtNombretut, "Campo Vacio");
                Error = true;
            }
            if (i_NuevoTutor1.txtDirecciontut.Text == "")
            {
                ErrorDatos.SetError(i_NuevoTutor1.txtDirecciontut, "Campo Vacio");
                Error = true;
            }
            if (i_NuevoTutor1.txtTelefonotut.Text == "")
            {
                ErrorDatos.SetError(i_NuevoTutor1.txtTelefonotut, "Campo Vacio");
                Error = true;
            }
            if (i_NuevoTutor1.CB_Parentesco.Text == "")
            {
                ErrorDatos.SetError(i_NuevoTutor1.CB_Parentesco, "Campo Vacio");
                Error = true;
            }

            if (Error==false)
            {
                CapturarDatos();

                if (Accion == 0)
                {
                    ObjAD.NuevoBeneficiario(Obj_Ben);
                    ObjAD.NuevoTutor(Obj_Tut);

                    MessageBox.Show("Beneficiario Agregado");
                    txtNombre.Clear();
                    CB_Genero.SelectedIndex = 0;
                    txtPadecimiento.Clear();
                    txtNecesidades.Clear();
                    txtNombre.Focus();
                    i_NuevoTutor1.txtNombretut.Clear();
                    i_NuevoTutor1.txtDirecciontut.Clear();
                    i_NuevoTutor1.txtTelefonotut.Clear();
                    i_NuevoTutor1.CB_Parentesco.SelectedIndex = -1;




                    int Id_ben= ObjAD.ConsultaIDBeneficiario();
                    
                    int Id_Tut = ObjAD.ConsultaIDTutor();
                    ObjAD.RelacionTutor(Id_ben, Id_Tut);



                }
                else
                { 
                    
                }
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
            Obj_Tut = new O_Tutor();
            Obj_Tut.Nombre_Tut = i_NuevoTutor1.txtNombretut.Text;
            Obj_Tut.Direccion_Tut = i_NuevoTutor1.txtDirecciontut.Text;
            Obj_Tut.Telefono_Tut = i_NuevoTutor1.txtTelefonotut.Text;
            Obj_Tut.Parentesco_Tut = i_NuevoTutor1.CB_Parentesco.Text;
            Obj_Tut.FecNac_Tut =  i_NuevoTutor1.dtpFecha.Text;




        }

        I_MenuPrincipal MenuPrincipal;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal = new I_MenuPrincipal();
            MenuPrincipal.DelP2 = DelP2;
            DelP2(MenuPrincipal);
        }


        
    }
}
