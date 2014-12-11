using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PASITOS
{
    public partial class I_Catalogo : PASITOS.I_Plantilla
    {
        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        DataTable Carga;
        O_Beneficiario Obj_B;
        O_Contacto Obj_Con;
        O_Donante Obj_Don;
        O_Donativo Obj_Dona;

        int Index, IndexA;
        int Id;

        public I_Catalogo()
        {
            InitializeComponent();
            CB_Categoria.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {





        }

        private void CB_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesplegarGrid();



        }

        private void DesplegarGrid()
        {
            Index = CB_Categoria.SelectedIndex;
            DG_Catalog.DataSource = null;
            DG_Catalog.AutoGenerateColumns = true;
            switch (Index)
            {
                //  //  // // // // // // // // // // // // BENEFICIARIO
                case 0:
                    CaseBeneficiario();

                    break;
                //  //  // // // // // // // // // // // // CONTACTO
                case 1:
                    CaseContacto();
                    break;
                //  //  // // // // // // // // // // // // DONANTE
                case 2:
                    CaseDonante();
                    break;
                //  //  // // // // // // // // // // // // DONATIVO
                case 3:
                    CaseDonativo();
                    break;



            }

            DG_Catalog.Columns[0].ReadOnly = true;
            DG_Catalog.Columns[0].HeaderText = "ID";
            DG_Catalog.Columns[0].Width = 25;
        }

         

        private void CaseBeneficiario()
        {
            ObjDT = ObjAD.ConsultaBeneficiarioMos();
            DG_Catalog.DataSource = ObjDT;
        }

        private void CaseContacto()
        {
            ObjDT = ObjAD.ConsultaContactoMos();
            DG_Catalog.DataSource = ObjDT;
        }
        
        private void CaseDonante()
        {
            
        }

        private void CaseDonativo()
        {
           
        }
        



    }
}
