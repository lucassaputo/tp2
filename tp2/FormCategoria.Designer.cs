namespace tp2
{
    partial class FormCategoria
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.lblEliminarCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.lblCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.groupBoxABCcategorias = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.groupBoxABCcategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(373, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(103, 10);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(254, 291);
            this.dgvCategorias.TabIndex = 2;
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Location = new System.Drawing.Point(19, 11);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(41, 13);
            this.lblAgregarMarca.TabIndex = 3;
            this.lblAgregarMarca.Text = "Agegar";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(135, 11);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(50, 13);
            this.lblModificarCategoria.TabIndex = 4;
            this.lblModificarCategoria.Text = "Modificar";
            // 
            // lblEliminarCategoria
            // 
            this.lblEliminarCategoria.AutoSize = true;
            this.lblEliminarCategoria.Location = new System.Drawing.Point(250, 11);
            this.lblEliminarCategoria.Name = "lblEliminarCategoria";
            this.lblEliminarCategoria.Size = new System.Drawing.Size(43, 13);
            this.lblEliminarCategoria.TabIndex = 5;
            this.lblEliminarCategoria.Text = "Eliminar";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(2, 26);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(82, 37);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Añadir Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.LightYellow;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.Location = new System.Drawing.Point(116, 26);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(82, 37);
            this.btnModificarCategoria.TabIndex = 7;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(235, 26);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(82, 37);
            this.btnEliminarCategoria.TabIndex = 8;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // lblCategoriaSeleccionada
            // 
            this.lblCategoriaSeleccionada.AutoSize = true;
            this.lblCategoriaSeleccionada.Location = new System.Drawing.Point(280, 319);
            this.lblCategoriaSeleccionada.Name = "lblCategoriaSeleccionada";
            this.lblCategoriaSeleccionada.Size = new System.Drawing.Size(111, 13);
            this.lblCategoriaSeleccionada.TabIndex = 12;
            this.lblCategoriaSeleccionada.Text = "Descripcion Categoria";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Location = new System.Drawing.Point(53, 319);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(65, 13);
            this.lblIDCategoria.TabIndex = 11;
            this.lblIDCategoria.Text = "ID categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(207, 335);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(248, 20);
            this.txtCategoria.TabIndex = 10;
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.Location = new System.Drawing.Point(38, 335);
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.ReadOnly = true;
            this.txtIDCategoria.Size = new System.Drawing.Size(92, 20);
            this.txtIDCategoria.TabIndex = 9;
            // 
            // groupBoxABCcategorias
            // 
            this.groupBoxABCcategorias.Controls.Add(this.btnEliminarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.btnModificarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.btnAgregarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.lblEliminarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.lblModificarCategoria);
            this.groupBoxABCcategorias.Controls.Add(this.lblAgregarMarca);
            this.groupBoxABCcategorias.Location = new System.Drawing.Point(16, 377);
            this.groupBoxABCcategorias.Name = "groupBoxABCcategorias";
            this.groupBoxABCcategorias.Size = new System.Drawing.Size(326, 81);
            this.groupBoxABCcategorias.TabIndex = 13;
            this.groupBoxABCcategorias.TabStop = false;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(471, 483);
            this.Controls.Add(this.groupBoxABCcategorias);
            this.Controls.Add(this.lblCategoriaSeleccionada);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtIDCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Categorias";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.groupBoxABCcategorias.ResumeLayout(false);
            this.groupBoxABCcategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.Label lblEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label lblCategoriaSeleccionada;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtIDCategoria;
        private System.Windows.Forms.GroupBox groupBoxABCcategorias;
    }
}