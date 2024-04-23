using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace tp2
{
    public partial class frmDetalles : Form
    {
        public frmDetalles(Articulo seleccionado)
        {
            InitializeComponent();

            lblNombreArticulo.Text = seleccionado.Nombre;
            lblDescripcionArticulo.Text = seleccionado.Descripcion;
            lblPrecioArticulo.Text = seleccionado.Precio.ToString();
            lblCodigoArticulo.Text = seleccionado.Codigo;
            lblMarca.Text = seleccionado.Marca.Descripcion;
            lblCategoriaArticulo.Text = seleccionado.Categoria.Descripcion;
            CargarImagen(seleccionado.Imagen.UrlImagen);
        }

        private void frmVentana3_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pibVerDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pibVerDetalle.Load("https://www.trecebits.com/wp-content/uploads/2019/07/imagen.jpg");
            }
        }

    }
}
