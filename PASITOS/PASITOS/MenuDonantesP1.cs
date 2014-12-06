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
    public partial class MenuDonantesP1 : UserControl,iModulo
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        public MenuDonantesP1()
        {
            InitializeComponent();
        }

       
        I_NuevoDonante_Contacto NuevoAspirante;

       
        MenuPrincipal_P1 MenuPrincipalP1;
        I_MenuPrincipal MenuPrincipal;
        private void BtnMenuP_Click(object sender, EventArgs e)
        {
            MenuPrincipalP1 = new MenuPrincipal_P1();
            MenuPrincipalP1.DelP1 = DelP1;
            MenuPrincipalP1.DelP2 = DelP2;
            DelP1(MenuPrincipalP1);

            MenuPrincipal = new I_MenuPrincipal();
            DelP2(MenuPrincipal);
        }

        private void BtnNuevoAspirante_Click(object sender, EventArgs e)
        {
            NuevoAspirante = new I_NuevoDonante_Contacto();
            NuevoAspirante.DelP2 = DelP2;
            DelP2(NuevoAspirante);
        }

        CatalogoAspirantesDcs CatalogoAspirantes;
        private void BtnAspirantes_Click(object sender, EventArgs e)
        {
            CatalogoAspirantes = new CatalogoAspirantesDcs();
            CatalogoAspirantes.DelP2 = DelP2;
            DelP2(CatalogoAspirantes);
        }
        CatalogoDonantesD CatalogoDonantes;
        private void BtnDonantes_Click(object sender, EventArgs e)
        {
            CatalogoDonantes = new CatalogoDonantesD();
            CatalogoDonantes.DelP2 = DelP2;
            DelP2(CatalogoDonantes);
        }

        

     
     
    }
}
