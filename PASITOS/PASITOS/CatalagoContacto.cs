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
    public partial class CatalagoContacto : PASITOS.I_Plantilla, iModulo
    {
       public  DelegadoP2 DelP2;
        DelegadoCon DelCon;
        AccesoDatos ObjAD = new AccesoDatos();
        public O_Donante donante;
        public int Forma=0;
        int ID=-1;
        public CatalagoContacto()
        {
            InitializeComponent();
            

            
        }

        public void Cargar(int ID)
        {
            dataGridView1.DataSource=ObjAD.ConsultarContatoPorDonanteID(ID);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {




        }
        I_NuevoContacto NuevoContacto;
        public void ActualizarContacto()
        {
            if (ID > 0)
            {
                NuevoContacto = new I_NuevoContacto(ID, Forma,1);
                NuevoContacto.DelP2 = DelP2;
                DelP2(NuevoContacto);
            }
            else
                MessageBox.Show("Seleccione un Contacto primero");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex].Field<int>("ID_Contacto");//e.RowIndex
            }
        }




        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CatalogoDonantesD CD = new CatalogoDonantesD();
        //    DelCon = new DelegadoCon(CD.DesmarcarGrid);
        //    DelCon();
        //}

        internal void EliminarContacto()
        {
            if (ID > 0)
            {
                ObjAD.EliminarContacto(ID);
                MessageBox.Show("Contacto Eliminado");

                dataGridView1.DataSource = ObjAD.ConsultarContatoPorDonanteID(ID);
            }
            else
                MessageBox.Show("Seleccione un Contacto primero");
        }
    }
}
