using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_MenuPrincipal : UserControl,iModulo
    {
        //Delegado Del;
        

        public I_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void I_MenuPrincipal_Load(object sender, EventArgs e)
        {
            //TopLevel = false;
            //FormBorderStyle = FormBorderStyle.None;

        }

        public void CargarDelegado(I_FormaPrincipal x)
        {
            //Del = new Delegado(x.CambioInterfazDonante);

        }
        private void BtnDonaciones_Click(object sender, EventArgs e)
        {
            
            

            //Del();
            //this.Close();


            //this.Controls.Remove(this);


            

        }
    }
}
