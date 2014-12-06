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
    public partial class MenuPrincipal_P1 : UserControl,iModulo
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;

        public MenuPrincipal_P1()
        {
            InitializeComponent();
        }

        MenuDonantesP1 MenuDonantes_P1;
        MenuBeneficiariosP1 MenuBeneficiarios_P1;
        private void MenuPrincipal_P1_Load(object sender, EventArgs e)
        {
            MenuDonantes_P1 = new MenuDonantesP1();
            MenuBeneficiarios_P1 = new MenuBeneficiariosP1();
        }

        private void BtnDonante_Click(object sender, EventArgs e)
        {
            MenuDonantes_P1.DelP1 = DelP1;
            MenuDonantes_P1.DelP2 = DelP2;
            DelP1(MenuDonantes_P1);
        }

        private void BtnNinos_Click(object sender, EventArgs e)
        {
            MenuBeneficiarios_P1.DelP1 = DelP1;
            MenuBeneficiarios_P1.DelP2 = DelP2;
            DelP1(MenuBeneficiarios_P1);
        }

    


    }
}
