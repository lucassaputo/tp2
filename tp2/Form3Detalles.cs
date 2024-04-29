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
        private Articulo articuloSeleccionado;
        public frmDetalles(Articulo seleccionado)
        {
            InitializeComponent();
            articuloSeleccionado = seleccionado;
            lblNombreArticulo.Text = seleccionado.Nombre;
            lblDescripcionArticulo.Text = seleccionado.Descripcion;
            lblPrecioArticulo.Text = seleccionado.Precio.ToString();
            lblCodigoArticulo.Text = seleccionado.Codigo;
            lblMarca.Text = seleccionado.Marca.Descripcion;
            lblCategoriaArticulo.Text = seleccionado.Categoria.Descripcion;
            //CargarImagen(seleccionado.UrlImagen);
            if (seleccionado.Imagenes.Count > 0)
            {
                CargarImagen(seleccionado.Imagenes[0].UrlImagen);
            }
            else
            {
                CargarImagen("XXX");
            }
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
                pibVerDetalle.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg?w=826");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(articuloSeleccionado .Imagenes.Count > 0)
            {
                List<Imagen> imagenes = new List<Imagen>();
                imagenes = articuloSeleccionado.Imagenes;
                int i = 0;
                foreach (Imagen img in imagenes)
                {
                    if (img.UrlImagen == pibVerDetalle.ImageLocation)
                    {
                        if (i == imagenes.Count - 1)
                        {
                            CargarImagen(imagenes[0].UrlImagen);
                            break;
                        }
                        else
                        {
                            CargarImagen(imagenes[i + 1].UrlImagen);
                            break;
                        }
                    }
                    i++;
                }
            }
           

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado.Imagenes.Count > 0)
            {
                List<Imagen> imagenes = new List<Imagen>();
                imagenes = articuloSeleccionado.Imagenes;
                int i = 0;
                foreach (Imagen img in imagenes)
                {
                    if (img.UrlImagen == pibVerDetalle.ImageLocation)
                    {
                        if (i == 0)
                        {
                            CargarImagen(imagenes[imagenes.Count - 1].UrlImagen);
                            break;
                        }
                        else
                        {
                            CargarImagen(imagenes[i - 1].UrlImagen);
                            break;
                        }
                    }
                    i++;
                }
            }
        }
    }
}
