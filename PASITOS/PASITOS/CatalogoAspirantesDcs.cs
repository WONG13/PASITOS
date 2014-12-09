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
    public partial class CatalogoAspirantesDcs : PASITOS.I_Plantilla
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        AccesoDatos ObjAD = new AccesoDatos();
        DataTable ObjDT = new DataTable();
        O_Donante Obj_Don;
        int IndexA;
        int Id;

        public CatalogoAspirantesDcs()
        {
            InitializeComponent();
        }

        private void CatalogoAspirantesDcs_Load(object sender, EventArgs e)
        {
            DesplegarGrid();
        }

        private void DesplegarGrid()
        {
            
            DG_Catalog.DataSource = null;
            DG_Catalog.AutoGenerateColumns = true;

            ObjDT = ObjAD.ConsultaAspirantes_a_Donantes();
            DG_Catalog.DataSource = ObjDT;

            DG_Catalog.Columns[0].ReadOnly = true;
            DG_Catalog.Columns[0].HeaderText = "ID";
            DG_Catalog.Columns[0].Width = 25;
        }

        I_MenuPrincipal MenuPrincipal;
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal = new I_MenuPrincipal();
            MenuPrincipal.DelP2 = DelP2;
            DelP2(MenuPrincipal);
        }
        I_NuevoContacto NuevoContacto;
        private void BtnNuevoContacto_Click(object sender, EventArgs e)
        {
            NuevoContacto = new I_NuevoContacto(Id,1);
            NuevoContacto.DelP2 = DelP2;
            DelP2(NuevoContacto);
        }

        private void DG_Catalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexA = DG_Catalog.CurrentRow.Index;
            Id = int.Parse(DG_Catalog[0, IndexA].Value.ToString());
            catalagoContacto1.Cargar(Id);
        }
    }
}
