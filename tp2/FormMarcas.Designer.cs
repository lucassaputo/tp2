﻿namespace tp2
{
    partial class FormMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBoxABCcategorias = new System.Windows.Forms.GroupBox();
            this.lblEliminarCategoria = new System.Windows.Forms.Label();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBoxABCcategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(91, 12);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(271, 287);
            this.dgvMarcas.TabIndex = 4;
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(6, 38);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(82, 37);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Location = new System.Drawing.Point(121, 38);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(82, 37);
            this.btnEditarMarca.TabIndex = 1;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = false;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.Red;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(238, 38);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(82, 37);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(12, 342);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(92, 22);
            this.txtIdMarca.TabIndex = 0;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(163, 342);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(292, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Location = new System.Drawing.Point(12, 320);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(156, 16);
            this.lblIDMarca.TabIndex = 6;
            this.lblIDMarca.Text = "Ingrese el ID de la marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese la Marca";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(373, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBoxABCcategorias
            // 
            this.groupBoxABCcategorias.Controls.Add(this.lblEliminarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.lblModificarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.lblAgregarMarca);
            this.groupBoxABCcategorias.Controls.Add(this.btnAgregarMarca);
            this.groupBoxABCcategorias.Controls.Add(this.btnEditarMarca);
            this.groupBoxABCcategorias.Controls.Add(this.btnEliminarMarca);
            this.groupBoxABCcategorias.Location = new System.Drawing.Point(15, 380);
            this.groupBoxABCcategorias.Name = "groupBoxABCcategorias";
            this.groupBoxABCcategorias.Size = new System.Drawing.Size(326, 81);
            this.groupBoxABCcategorias.TabIndex = 2;
            this.groupBoxABCcategorias.TabStop = false;
            // 
            // lblEliminarCategoria
            // 
            this.lblEliminarCategoria.AutoSize = true;
            this.lblEliminarCategoria.Location = new System.Drawing.Point(250, 11);
            this.lblEliminarCategoria.Name = "lblEliminarCategoria";
            this.lblEliminarCategoria.Size = new System.Drawing.Size(55, 16);
            this.lblEliminarCategoria.TabIndex = 5;
            this.lblEliminarCategoria.Text = "Eliminar";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(135, 11);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(62, 16);
            this.lblModificarCategoria.TabIndex = 4;
            this.lblModificarCategoria.Text = "Modificar";
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Location = new System.Drawing.Point(19, 11);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(52, 16);
            this.lblAgregarMarca.TabIndex = 3;
            this.lblAgregarMarca.Text = "Agegar";
            // 
            // FormMarcas
            // 
            this.ClientSize = new System.Drawing.Size(471, 483);
            this.Controls.Add(this.groupBoxABCcategorias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIDMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMarcas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Marcas";
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBoxABCcategorias.ResumeLayout(false);
            this.groupBoxABCcategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBoxABCcategorias;
        private System.Windows.Forms.Label lblEliminarCategoria;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.Label lblAgregarMarca;
    }
}