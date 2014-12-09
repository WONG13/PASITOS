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

        public CatalogoBeneficiario()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            ObjDT=ObjAD.ConsultaBeneficiarioMos();
            dataGridView1.DataSource = ObjDT;
        }
    }
}
