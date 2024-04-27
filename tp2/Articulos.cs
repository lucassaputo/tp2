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
                listaArticulos = negocio.listarConImagenes();

                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                if (listaArticulos.Count > 0)
                {
                    CargarImagen(listaArticulos[0].Imagenes[0].UrlImagen);
                }
                else
                {
                    CargarImagen("XXX");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            // dgvArticulos.Columns["UrlImagen"].Visible = false;
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
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmDetalles detalle = new frmDetalles(seleccionado);
                detalle.ShowDialog();
                Cargar();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (seleccionado.Imagenes.Count > 0)
                {
                    CargarImagen(seleccionado.Imagenes[0].UrlImagen);
                }
                else
                {
                    CargarImagen("XXX");
                }
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

        private void deshabilitarBotones()
        {
            
            btnModificarArticulo.Enabled = false;
            btnDetalleArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
            cboCampo.Enabled = false;
            cboCriterio.Enabled = false;
            txtFiltroAv.Enabled = false;
            btnBuscarAvanzado.Enabled = false;
            btnPrev.Enabled = false;
            btnSiguiente.Enabled = false;
            CargarImagen("Vacio");
        }

        private void habilitarBotones()
        {
            
            btnModificarArticulo.Enabled = true;
            btnDetalleArticulo.Enabled = true;
            btnEliminarArticulo.Enabled = true;
            cboCampo.Enabled = true;
            cboCriterio.Enabled = true;
            txtFiltroAv.Enabled = true;
            btnBuscarAvanzado.Enabled = true;
            btnPrev.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(k => k.Nombre.ToLower().Contains(filtro.ToLower()) || k.Descripcion.ToLower().Contains(filtro.ToLower()) || k.Precio.ToString().Contains(filtro) || k.Marca.Descripcion.ToLower().Contains(filtro.ToLower()) || k.Categoria.Descripcion.ToLower().Contains(filtro.ToLower()));
                deshabilitarBotones();
                if (listaFiltrada.Count > 0 || filtro == "")
                {
                    habilitarBotones();
                }
            }
            else
            {
                habilitarBotones();
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }


        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar");
                return true;
            }
            if (string.IsNullOrEmpty(txtFiltroAv.Text))
            {
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAv.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numérico");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAv.Text)))
                {
                    MessageBox.Show("El campo debe ser numérico");
                    return true;
                }
            }


            return false;
        }


        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = listaArticulos;
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAv.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                List<Imagen> imagenes = new List<Imagen>();
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenes = seleccionado.Imagenes;
                int i = 0;
                foreach (Imagen img in imagenes)
                {
                    if (img.UrlImagen == pibArticulos.ImageLocation)
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
            Articulo seleccionado = new Articulo();
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                List<Imagen> imagenes = new List<Imagen>();
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenes = seleccionado.Imagenes;
                int i = 0;
                foreach (Imagen img in imagenes)
                {
                    if (img.UrlImagen == pibArticulos.ImageLocation)
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

        // BAJA de Articulos
        private void btnEliminarArticulo_Click(object sender, EventArgs e) 
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // selecciono el ARTICULO de la DGV que quiero eliminar
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro queres eliminar el articulo: " + seleccionado.Nombre + "?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // mensaje modal de confirmacion. El show es un method que devuelve un DialogResult

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.ID); // aca le paso del articulo seleccionado, el ID
                    Cargar(); // actualizo y muestro la grilla
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
    }
}
