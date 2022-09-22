
namespace Sol_Minimarket.Presentacion
{
    partial class Frm_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
            this.Tbp_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Txt_descripcion_pr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_descripcion_ct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_lupa1 = new System.Windows.Forms.Button();
            this.Btn_lupa2 = new System.Windows.Forms.Button();
            this.Txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_stock_max = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_stock_min = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbp_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbp_principal
            // 
            this.Tbp_principal.Controls.Add(this.tabPage1);
            this.Tbp_principal.Controls.Add(this.tabPage2);
            this.Tbp_principal.Location = new System.Drawing.Point(21, 23);
            this.Tbp_principal.Name = "Tbp_principal";
            this.Tbp_principal.SelectedIndex = 0;
            this.Tbp_principal.Size = new System.Drawing.Size(1102, 496);
            this.Tbp_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_Buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            this.Dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_principal.ColumnHeadersHeight = 35;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_principal.Location = new System.Drawing.Point(18, 54);
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            this.Dgv_principal.Size = new System.Drawing.Size(1048, 370);
            this.Dgv_principal.TabIndex = 3;
            this.Dgv_principal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_principal_CellContentClick);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(394, 25);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 2;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click_1);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(61, 27);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(318, 20);
            this.Txt_Buscar.TabIndex = 1;
            this.Txt_Buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Txt_stock_min);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Txt_stock_max);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Btn_lupa2);
            this.tabPage2.Controls.Add(this.Txt_descripcion_um);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Btn_lupa1);
            this.tabPage2.Controls.Add(this.Txt_descripcion_ct);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Txt_descripcion_pr);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_Retornar);
            this.tabPage2.Controls.Add(this.Btn_Guardar);
            this.tabPage2.Controls.Add(this.Btn_Cancelar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_descripcion_pr
            // 
            this.Txt_descripcion_pr.Location = new System.Drawing.Point(128, 25);
            this.Txt_descripcion_pr.MaxLength = 5;
            this.Txt_descripcion_pr.Name = "Txt_descripcion_pr";
            this.Txt_descripcion_pr.Size = new System.Drawing.Size(281, 20);
            this.Txt_descripcion_pr.TabIndex = 1;
            this.Txt_descripcion_pr.TextChanged += new System.EventHandler(this.Txt_Abreviatura_um_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto(*):";
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.Location = new System.Drawing.Point(335, 345);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Retornar.TabIndex = 4;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = true;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click_1);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(226, 345);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click_1);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(119, 345);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click_1);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.Btn_Nuevo.ImageKey = "new.png";
            this.Btn_Nuevo.ImageList = this.imageList1;
            this.Btn_Nuevo.Location = new System.Drawing.Point(43, 525);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(82, 66);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "new.png");
            this.imageList1.Images.SetKeyName(1, "update01.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "report.png");
            this.imageList1.Images.SetKeyName(4, "exit.png");
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.Btn_Actualizar.ImageKey = "update01.png";
            this.Btn_Actualizar.ImageList = this.imageList1;
            this.Btn_Actualizar.Location = new System.Drawing.Point(143, 525);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(82, 66);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click_1);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.Btn_Eliminar.ImageKey = "delete.png";
            this.Btn_Eliminar.ImageList = this.imageList1;
            this.Btn_Eliminar.Location = new System.Drawing.Point(243, 525);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(82, 66);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click_1);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.Btn_Reporte.Enabled = false;
            this.Btn_Reporte.ImageKey = "report.png";
            this.Btn_Reporte.ImageList = this.imageList1;
            this.Btn_Reporte.Location = new System.Drawing.Point(343, 525);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(82, 66);
            this.Btn_Reporte.TabIndex = 4;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click_1);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.Btn_Salir.ImageKey = "exit.png";
            this.Btn_Salir.ImageList = this.imageList1;
            this.Btn_Salir.Location = new System.Drawing.Point(679, 525);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(82, 66);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // Txt_descripcion_ct
            // 
            this.Txt_descripcion_ct.Location = new System.Drawing.Point(128, 83);
            this.Txt_descripcion_ct.MaxLength = 5;
            this.Txt_descripcion_ct.Name = "Txt_descripcion_ct";
            this.Txt_descripcion_ct.Size = new System.Drawing.Size(172, 20);
            this.Txt_descripcion_ct.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria(*):";
            // 
            // Btn_lupa1
            // 
            this.Btn_lupa1.Location = new System.Drawing.Point(334, 81);
            this.Btn_lupa1.Name = "Btn_lupa1";
            this.Btn_lupa1.Size = new System.Drawing.Size(75, 23);
            this.Btn_lupa1.TabIndex = 8;
            this.Btn_lupa1.Text = ":::";
            this.Btn_lupa1.UseVisualStyleBackColor = true;
            // 
            // Btn_lupa2
            // 
            this.Btn_lupa2.Location = new System.Drawing.Point(334, 141);
            this.Btn_lupa2.Name = "Btn_lupa2";
            this.Btn_lupa2.Size = new System.Drawing.Size(75, 23);
            this.Btn_lupa2.TabIndex = 11;
            this.Btn_lupa2.Text = ":::";
            this.Btn_lupa2.UseVisualStyleBackColor = true;
            // 
            // Txt_descripcion_um
            // 
            this.Txt_descripcion_um.Location = new System.Drawing.Point(128, 143);
            this.Txt_descripcion_um.MaxLength = 5;
            this.Txt_descripcion_um.Name = "Txt_descripcion_um";
            this.Txt_descripcion_um.Size = new System.Drawing.Size(172, 20);
            this.Txt_descripcion_um.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medida(*):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = ":::";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Txt_stock_max
            // 
            this.Txt_stock_max.Location = new System.Drawing.Point(129, 260);
            this.Txt_stock_max.MaxLength = 5;
            this.Txt_stock_max.Name = "Txt_stock_max";
            this.Txt_stock_max.Size = new System.Drawing.Size(172, 20);
            this.Txt_stock_max.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock Maximo(*):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = ":::";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Txt_stock_min
            // 
            this.Txt_stock_min.Location = new System.Drawing.Point(129, 199);
            this.Txt_stock_min.MaxLength = 5;
            this.Txt_stock_min.Name = "Txt_stock_min";
            this.Txt_stock_min.Size = new System.Drawing.Size(172, 20);
            this.Txt_stock_min.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock Minimo(*):";
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1151, 614);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tbp_principal);
            this.Name = "Frm_Productos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            this.Tbp_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbp_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Txt_descripcion_pr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_lupa1;
        private System.Windows.Forms.TextBox Txt_descripcion_ct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_lupa2;
        private System.Windows.Forms.TextBox Txt_descripcion_um;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_stock_min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_stock_max;
        private System.Windows.Forms.Label label5;
    }
}