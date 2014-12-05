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
    public partial class I_Plantilla : Form
    {
        public I_Plantilla()
        {
            InitializeComponent();
         
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void I_Plantilla_Load(object sender, EventArgs e)
        {
            //TopLevel = false;
            //FormBorderStyle = FormBorderStyle.None;
        }
    }
}
