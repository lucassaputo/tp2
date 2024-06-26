﻿namespace tp2
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
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.txtFiltroAv = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 76);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(633, 230);
            this.dgvArticulos.TabIndex = 13;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pibArticulos
            // 
            this.pibArticulos.Location = new System.Drawing.Point(662, 76);
            this.pibArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pibArticulos.Name = "pibArticulos";
            this.pibArticulos.Size = new System.Drawing.Size(225, 230);
            this.pibArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibArticulos.TabIndex = 1;
            this.pibArticulos.TabStop = false;
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleArticulo.Location = new System.Drawing.Point(447, 320);
            this.btnDetalleArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(125, 37);
            this.btnDetalleArticulo.TabIndex = 4;
            this.btnDetalleArticulo.Text = "Ver Detalles";
            this.btnDetalleArticulo.UseVisualStyleBackColor = false;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(11, 320);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(125, 37);
            this.btnAgregarArticulo.TabIndex = 1;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(154, 320);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(125, 37);
            this.btnModificarArticulo.TabIndex = 2;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Cyan;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(302, 320);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(125, 37);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(64, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(322, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(17, 385);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(161, 385);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblBuscarAvanzado
            // 
            this.lblBuscarAvanzado.AutoSize = true;
            this.lblBuscarAvanzado.Location = new System.Drawing.Point(331, 385);
            this.lblBuscarAvanzado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarAvanzado.Name = "lblBuscarAvanzado";
            this.lblBuscarAvanzado.Size = new System.Drawing.Size(35, 13);
            this.lblBuscarAvanzado.TabIndex = 10;
            this.lblBuscarAvanzado.Text = "Filtrar:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(62, 383);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(92, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(205, 383);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(115, 21);
            this.cboCriterio.TabIndex = 8;
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(543, 379);
            this.btnBuscarAvanzado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(56, 23);
            this.btnBuscarAvanzado.TabIndex = 10;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = true;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(425, 17);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(106, 46);
            this.btnMarcas.TabIndex = 11;
            this.btnMarcas.Text = "Administrar Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(562, 18);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(106, 46);
            this.btnCategorias.TabIndex = 12;
            this.btnCategorias.Text = "Administrar Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // txtFiltroAv
            // 
            this.txtFiltroAv.Location = new System.Drawing.Point(368, 383);
            this.txtFiltroAv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroAv.Name = "txtFiltroAv";
            this.txtFiltroAv.Size = new System.Drawing.Size(171, 20);
            this.txtFiltroAv.TabIndex = 9;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(680, 320);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(56, 19);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(814, 320);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(56, 19);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 455);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtFiltroAv);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnBuscarAvanzado);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibArticulos)).EndInit();
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
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscarAvanzado;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.TextBox txtFiltroAv;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

