namespace tp2
{
    partial class frmDetalles
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
            this.pibVerDetalle = new System.Windows.Forms.PictureBox();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblPreci = new System.Windows.Forms.Label();
            this.lblMarc = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(172, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pibVerDetalle
            // 
            this.pibVerDetalle.Location = new System.Drawing.Point(86, 167);
            this.pibVerDetalle.Name = "pibVerDetalle";
            this.pibVerDetalle.Size = new System.Drawing.Size(253, 253);
            this.pibVerDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibVerDetalle.TabIndex = 3;
            this.pibVerDetalle.TabStop = false;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(118, 30);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreArticulo.TabIndex = 4;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(149, 76);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblDescripcionArticulo.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(358, 76);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 6;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioArticulo.Location = new System.Drawing.Point(108, 120);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioArticulo.TabIndex = 7;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(380, 120);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblCategoriaArticulo.TabIndex = 9;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(422, 30);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoArticulo.TabIndex = 10;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(56, 30);
            this.lblArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(47, 13);
            this.lblArt.TabIndex = 11;
            this.lblArt.Text = "Artículo:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(57, 76);
            this.lblDescrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblDescrip.TabIndex = 12;
            this.lblDescrip.Text = "Descripción:";
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(316, 30);
            this.lblCodArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(98, 13);
            this.lblCodArt.TabIndex = 13;
            this.lblCodArt.Text = "Código de Artículo:";
            // 
            // lblPreci
            // 
            this.lblPreci.AutoSize = true;
            this.lblPreci.Location = new System.Drawing.Point(60, 120);
            this.lblPreci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreci.Name = "lblPreci";
            this.lblPreci.Size = new System.Drawing.Size(40, 13);
            this.lblPreci.TabIndex = 14;
            this.lblPreci.Text = "Precio:";
            // 
            // lblMarc
            // 
            this.lblMarc.AutoSize = true;
            this.lblMarc.Location = new System.Drawing.Point(316, 76);
            this.lblMarc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarc.Name = "lblMarc";
            this.lblMarc.Size = new System.Drawing.Size(40, 13);
            this.lblMarc.TabIndex = 15;
            this.lblMarc.Text = "Marca:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(316, 120);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(57, 13);
            this.lblCat.TabIndex = 16;
            this.lblCat.Text = "Categoría:";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(46, 167);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(20, 253);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(360, 167);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(20, 253);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 540);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblMarc);
            this.Controls.Add(this.lblPreci);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.pibVerDetalle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del articulo";
            this.Load += new System.EventHandler(this.frmVentana3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibVerDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pibVerDetalle;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblPreci;
        private System.Windows.Forms.Label lblMarc;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSiguiente;
    }
}