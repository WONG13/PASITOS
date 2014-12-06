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
    public partial class MenuBeneficiariosP1 : UserControl,iModulo
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        public MenuBeneficiariosP1()
        {
            InitializeComponent();
        }

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

        I_NuevoBeneficiario NuevoBeneficiario;
        private void BtnNuevoAspirante_Click(object sender, EventArgs e)
        {
            NuevoBeneficiario = new I_NuevoBeneficiario();
            NuevoBeneficiario.DelP1 = DelP1;
            NuevoBeneficiario.DelP2 = DelP2;
            DelP2(NuevoBeneficiario);
        }

       

    }
}
