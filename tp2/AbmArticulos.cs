using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
namespace tp2
{
    public partial class AbmArticulos : Form
    {
        private Articulo articulo = null;
        private List<Imagen> imagenes;
        private OpenFileDialog archivo = null;
        public AbmArticulos()
        {
            InitializeComponent();           
        }
        public AbmArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void form_Load(object sender, EventArgs e)
        {
            
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtUrlImagen.Enabled = false;
                    btnAgregarImagen.Enabled = false;
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                   // txtUrlImagen.Text = articulo.UrlImagen;
                    //cargarImagen(articulo.UrlImagen);
                    cargarImagenes(articulo.Imagenes);
                    //cargarImagenes(10);
                    txtPrecio.Text = articulo.Precio.ToString("#0.00", System.Globalization.CultureInfo.InvariantCulture);
                    cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al cargar ventana.");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarImagenes(List<Imagen> imagenes)
        {
            if (imagenes.Count > 0)
            {
                txtUrlImagen.Text = imagenes[0].UrlImagen;
                cargarImagen(imagenes[0].UrlImagen);
            }
            else
            {
                cargarImagen("xxxxx");
            }
        }
        private void cargarImagen(string imag)
        {
            try
            {
                pbxArticulo.Load(imag);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                pbxArticulo.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg?w=826");
            }
        }

        private bool validarArticulo()
        {
            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la marca del articulo.");
                return true;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la categoria del articulo.");
                return true;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debes cargar el Código.");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debes cargar el Nombre.");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debes cargar el Precio.");
                return true;
            }
            if (!(esDecimal(txtPrecio.Text)))
            {
                MessageBox.Show("Solo nros son admitidos en el precio, utilice punto para colocar decimales.");
                return true;
            }
            return false;
        }
        private bool esDecimal(string cadena)
        {
            decimal resultado;
            if (decimal.TryParse(cadena, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
            {
                return true;
            }
            return false;
        }
        private decimal pasarADecimal(string cadena)
        {
            decimal resultado;
            if (decimal.TryParse(cadena, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
            {
                return resultado;
            }
            return -1;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            int id;
            try
            {
                if (validarArticulo())
                    return;
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                //articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = pasarADecimal(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.ID != 0)
                {
                    negocioArticulo.modificar(articulo);
                    
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocioArticulo.agregar2(articulo);
                    id = negocioArticulo.buscarUltimo();
                    MessageBox.Show("Agregado exitosamente" + id);
                }

                //Guardo imagen si la levantó localmente:
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al guardar/modificar. Intente nuevamente.");
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }



        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = true;
            txtUrlImagen.Text = "";
            btnAgregarImagen.Enabled = true;
        }

        private void btnAceptarImagen_Click(object sender, EventArgs e)
        {
            txtUrlImagen.Enabled = false;
            //txtUrlImagen.Text = "";
            btnAgregarImagen.Enabled = false;
            //articulo.Imagenes.Add
        }
    }
}
