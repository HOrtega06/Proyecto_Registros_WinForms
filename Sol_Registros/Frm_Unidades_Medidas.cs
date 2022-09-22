using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sol_Registros.Entidades;
using Sol_Registros.Negocio;

namespace Sol_Minimarket.Presentacion
{
    public partial class Frm_Unidades_Medidas : Form
    {
        public Frm_Unidades_Medidas()
        {
            InitializeComponent();
        }
        #region "Mis variables"
        int Codigo_um = 0;
        int Estadoguarda = 0; //Sin ninguna accion

        #endregion
        #region "Mis metodos"
        private void Formato_um()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_UM";
            Dgv_principal.Columns[1].Width = 100;
            Dgv_principal.Columns[1].HeaderText = "ABREVUATURA";
            Dgv_principal.Columns[2].Width = 300;
            Dgv_principal.Columns[2].HeaderText = "MEDIDA";
        }

        private void Listado_um(string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Unidaes_Medidas.Listado_um(cTexto);
                this.Formato_um();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.Btn_Nuevo.Enabled = lEstado;
            this.Btn_Actualizar.Enabled = lEstado;
            this.Btn_Eliminar.Enabled = lEstado;
            this.Btn_Salir.Enabled = lEstado;

        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.Btn_Cancelar.Visible = lEstado;
            this.Btn_Guardar.Visible = lEstado;
            this.Btn_Retornar.Visible = !lEstado;
        }

        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_um = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
                Txt_Abreviatura_um.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["abreviatura_um"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_um"].Value);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Tbp_principal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Frm_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar nuevo registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.SeleccionaItem();
            Txt_descripcion_um.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_um.Focus();
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
            this.Codigo_um = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion 
            this.Codigo_um = 0;
            Txt_descripcion_um.Text = "";
            Txt_descripcion_um.ReadOnly = true;
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionaItem();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_um = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
                    Rpta = N_Categorias.Eliminar_ca(this.Codigo_um);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_um("%");
                        this.Codigo_um = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //Enviar a ejecutar la eliminacion de datos
                }
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_um(Txt_Buscar.Text.Trim());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1;//Nuevo registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_um.Text = "";
            Txt_Abreviatura_um.Text = "";
            Txt_Abreviatura_um.ReadOnly = false;
            Txt_descripcion_um.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_Abreviatura_um.Focus();
        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar nuevo registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.SeleccionaItem();
            Txt_descripcion_um.ReadOnly = false;
            Txt_Abreviatura_um.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_um.Focus();
        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_um = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
                    Rpta = N_Unidaes_Medidas.Eliminar_um(this.Codigo_um);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_um("%");
                        this.Codigo_um = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //Enviar a ejecutar la eliminacion de datos
                }
            }
        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Estas seguro de salir del sistema?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            this.Listado_um(Txt_Buscar.Text.Trim());
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion 
            this.Codigo_um = 0;
            Txt_Abreviatura_um.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_Abreviatura_um.ReadOnly = true;
            Txt_descripcion_um.ReadOnly = true;
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (Txt_Abreviatura_um.Text == String.Empty || Txt_descripcion_um.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion 
            {
                E_Unidades_Medidas oUm = new E_Unidades_Medidas();
                string Rpta = "";
                oUm.Codigo_um = this.Codigo_um;
                oUm.Abreviatura_um = Txt_Abreviatura_um.Text.Trim();
                oUm.Descripcion_um = Txt_descripcion_um.Text.Trim();
                Rpta = N_Unidaes_Medidas.Guardar_um(Estadoguarda, oUm);
                if (Rpta == "OK")
                {
                    this.Listado_um("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;//Sin ninguna accion
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_Abreviatura_um.Text = "";
                    Txt_descripcion_um.Text = "";
                    Txt_descripcion_um.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_um = 0;
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Retornar_Click_1(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
            this.Codigo_um = 0;
        }

        private void Btn_Reporte_Click_1(object sender, EventArgs e)
        {
            Sol_Registros.Reportes.Frm_Rpt_Categorias nuevo = new Sol_Registros.Reportes.Frm_Rpt_Categorias();
            nuevo.txt_p1.Text = Txt_Buscar.Text;
            nuevo.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Txt_Abreviatura_um_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
