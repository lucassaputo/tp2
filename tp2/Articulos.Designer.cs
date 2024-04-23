namespace tp2
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pibArticulos = new System.Windows.Forms.PictureBox();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblBuscarAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.btnMenuAgregarArt = new System.Windows.Forms.ToolStripButton();
            this.btnMenuModificarArt = new System.Windows.Forms.ToolStripButton();
            this.btnMenuEliminarArt = new System.Windows.Forms.ToolStripButton();
            this.btnMenuBuscarArt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibArticulos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 94);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(749, 283);
            this.dgvArticulos.TabIndex = 0;
            // 
            // pibArticulos
            // 
            this.pibArticulos.Location = new System.Drawing.Point(769, 94);
            this.pibArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibArticulos.Name = "pibArticulos";
            this.pibArticulos.Size = new System.Drawing.Size(211, 283);
            this.pibArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibArticulos.TabIndex = 1;
            this.pibArticulos.TabStop = false;
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleArticulo.Location = new System.Drawing.Point(817, 394);
            this.btnDetalleArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(109, 46);
            this.btnDetalleArticulo.TabIndex = 2;
            this.btnDetalleArticulo.Text = "Ver Detalles";
            this.btnDetalleArticulo.UseVisualStyleBackColor = false;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(23, 394);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(109, 46);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(205, 394);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(109, 46);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(405, 394);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(109, 46);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(85, 57);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(428, 22);
            this.txtBuscar.TabIndex = 7;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(23, 474);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(215, 474);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblBuscarAvanzado
            // 
            this.lblBuscarAvanzado.AutoSize = true;
            this.lblBuscarAvanzado.Location = new System.Drawing.Point(441, 474);
            this.lblBuscarAvanzado.Name = "lblBuscarAvanzado";
            this.lblBuscarAvanzado.Size = new System.Drawing.Size(43, 16);
            this.lblBuscarAvanzado.TabIndex = 10;
            this.lblBuscarAvanzado.Text = "Filtrar:";
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(83, 471);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 24);
            this.cboCampo.TabIndex = 11;
            // 
            // cboCriterio
            // 
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(273, 471);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(152, 24);
            this.cboCriterio.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 471);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 13;
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(724, 466);
            this.btnBuscarAvanzado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarAvanzado.TabIndex = 14;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = true;
            // 
            // btnMenuAgregarArt
            // 
            this.btnMenuAgregarArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMenuAgregarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuAgregarArt.Image")));
            this.btnMenuAgregarArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuAgregarArt.Name = "btnMenuAgregarArt";
            this.btnMenuAgregarArt.Size = new System.Drawing.Size(29, 24);
            this.btnMenuAgregarArt.Text = "toolStripButton1";
            // 
            // btnMenuModificarArt
            // 
            this.btnMenuModificarArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMenuModificarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuModificarArt.Image")));
            this.btnMenuModificarArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuModificarArt.Name = "btnMenuModificarArt";
            this.btnMenuModificarArt.Size = new System.Drawing.Size(29, 24);
            this.btnMenuModificarArt.Text = "toolStripButton2";
            // 
            // btnMenuEliminarArt
            // 
            this.btnMenuEliminarArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMenuEliminarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuEliminarArt.Image")));
            this.btnMenuEliminarArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuEliminarArt.Name = "btnMenuEliminarArt";
            this.btnMenuEliminarArt.Size = new System.Drawing.Size(29, 24);
            this.btnMenuEliminarArt.Text = "toolStripButton3";
            // 
            // btnMenuBuscarArt
            // 
            this.btnMenuBuscarArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMenuBuscarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBuscarArt.Image")));
            this.btnMenuBuscarArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuBuscarArt.Name = "btnMenuBuscarArt";
            this.btnMenuBuscarArt.Size = new System.Drawing.Size(29, 24);
            this.btnMenuBuscarArt.Text = "toolStripButton4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuAgregarArt,
            this.btnMenuModificarArt,
            this.btnMenuEliminarArt,
            this.btnMenuBuscarArt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(567, 21);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(141, 57);
            this.btnMarcas.TabIndex = 16;
            this.btnMarcas.Text = "Administrar Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(749, 22);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(141, 57);
            this.btnCategorias.TabIndex = 17;
            this.btnCategorias.Text = "Administrar Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBuscarAvanzado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblBuscarAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.pibArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibArticulos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pibArticulos;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblBuscarAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarAvanzado;
        private System.Windows.Forms.ToolStripButton btnMenuAgregarArt;
        private System.Windows.Forms.ToolStripButton btnMenuModificarArt;
        private System.Windows.Forms.ToolStripButton btnMenuEliminarArt;
        private System.Windows.Forms.ToolStripButton btnMenuBuscarArt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

