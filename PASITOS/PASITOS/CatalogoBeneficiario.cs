using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PASITOS
{
    public partial class CatalogoBeneficiario : I_Plantilla,iModulo 
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        int ID = -1;

        public CatalogoBeneficiario()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            ObjDT=ObjAD.ConsultaBeneficiarioMos();
            dataGridView1.DataSource = ObjDT;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 25;
        
        }

        I_MenuPrincipal MenuPrincipal;
        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal = new I_MenuPrincipal();
            MenuPrincipal.DelP2 = DelP2;
            DelP2(MenuPrincipal);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex].Field<int>("ID_Donante");//e.RowIndex
                catalagoTutor1.Cargar(ID);
            }

        }
        I_NuevoBeneficiario NuevoBeneficiario;
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                NuevoBeneficiario = new I_NuevoBeneficiario(ID, 2, 1);
                NuevoBeneficiario.DelP2 = DelP2;
                DelP2(NuevoBeneficiario);
            }
            else
                MessageBox.Show("Seleccione un Niño primero");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObjAD.EliminarDonante(ID);
            MessageBox.Show("Beneficiario Eliminado");
            Cargar();
        }

        I_NuevoTutor NuevoTutor;
        private void BtnNuevoContacto_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                NuevoTutor = new I_NuevoTutor(ID, 2, 0);
                NuevoTutor.DelP2 = DelP2;
                DelP2(NuevoTutor);
            }
            else
                MessageBox.Show("Seleccione un Donante primero");
        }


    }
}
