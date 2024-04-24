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
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulos;
        public Articulos()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            Cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Descripcion");

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas formMarca = new FormMarcas();
            formMarca.ShowDialog();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            formCategoria.ShowDialog();
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();

                CargarImagen(listaArticulos[0].Imagen.UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pibArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pibArticulos.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg?w=826");
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
                AbmArticulos formABM = new AbmArticulos();
                formABM.ShowDialog();           
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalles detalle = new frmDetalles(seleccionado);
            detalle.ShowDialog();
            Cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.Imagen.UrlImagen);
            }
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                AbmArticulos modificar = new AbmArticulos(seleccionado);
                modificar.ShowDialog();
                //cargar();
            }
        }
    }
}
