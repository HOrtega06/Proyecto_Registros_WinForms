using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Registros.Reportes
{
    public partial class Frm_Rpt_Categorias : Form
    {
        public Frm_Rpt_Categorias()
        {
            InitializeComponent();
        }

        private void USP_Listado_caNewBindingSource_CurrentChanged(object sender, EventArgs e) 
        { 

        }
        private void Frm_Rpt_Categorias_Load(object sender, EventArgs e)
        {
            this.USP_Listado_caNewTableAdapter.Fill(this.DataSet_Registros.USP_Listado_caNew, cTexto: txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }
        
    }
}
