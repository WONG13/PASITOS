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
        DelegadoCon DelCon;
        AccesoDatos ObjAD = new AccesoDatos();
        public O_Donante donante;
        public CatalagoContacto()
        {
            InitializeComponent();
            
        }

        public void Cargar(int ID)
        {
            dataGridView1.DataSource=ObjAD.ConsultarContatoPorDonanteID(ID);
        }

        //public void Desmarcar()
        //{
        //    if (dataGridView1.CurrentRow != null)
        //    {
        //        dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Selected = false;
        //        btnAceptar.Visible = false;
        //    }
        //}
        private void btnAceptar_Click(object sender, EventArgs e)
        {




        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CatalogoDonantesD CD = new CatalogoDonantesD();
        //    DelCon = new DelegadoCon(CD.DesmarcarGrid);
        //    DelCon();
        //}
    }
}
