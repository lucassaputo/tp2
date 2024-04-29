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
        private List<Imagen> imagenes = new List<Imagen>();
        private List<Imagen> imagenesAux = new List<Imagen>();
        private List<Imagen> imagenesBackups = new List<Imagen>();
        private OpenFileDialog archivo = null;
        private Articulo articuloSeleccionado;
        private int contImagenes = -1;
        public AbmArticulos()
        {
            InitializeComponent();
        }
        public AbmArticulos(Articulo articulo)
        {
            InitializeComponent();
            articuloSeleccionado = articulo;
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void form_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            txtUrlImagen.Enabled = false;
            btnAgregarImagen.Enabled = false;
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
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cargarImagenes(articulo.Imagenes);
                    txtPrecio.Text = articulo.Precio.ToString("#0.00", System.Globalization.CultureInfo.InvariantCulture);
                    cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                }
                else
                {
                    cargarImagen("x");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al cargar ventana.");
            }
        }  

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
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
                articulo.Precio = pasarADecimal(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.ID != 0)//modificacion
                {
                    negocioArticulo.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else//alta
                {
                    negocioArticulo.agregar(articulo);
                    id = negocioArticulo.buscarUltimo();
                    if (imagenesBackups.Count > 0)
                    {
                        for (int i = 0; i < imagenesBackups.Count; i++)
                        {
                            imagenesBackups[i].IdArticulo = id;
                            imagenNegocio.agregar(imagenesBackups[i]);
                            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + imagenesBackups[i].UrlImagen);
                        }
                    }
                    MessageBox.Show("Agregado exitosamente" + id);
                }

                //Guardo imagen si la levantó localmente:
                /*if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);*/

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al guardar/modificar. Intente nuevamente.");
            }
        }

        private void btnAgregarImagenArchivo(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen aux = new Imagen();
            Imagen imagenBackup = new Imagen(); 
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                if (articulo != null)//modificacion
                {
                    aux.ID = -1;
                    aux.IdArticulo = articulo.ID;
                    if (archivo != null)
                    {                        
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                        aux.UrlImagen = archivo.SafeFileName;
                    }                    
                    articulo.Imagenes.Add(aux);
                    imagenNegocio.agregar(aux);
                    cargarImagen(archivo.SafeFileName);
                    MessageBox.Show("Imagen agregada exitosamente");
                }
                else//alta
                {
                    aux.UrlImagen = archivo.FileName;
                    aux.ID = -1;
                    aux.IdArticulo = -1;
                    imagenesAux.Add(aux);
                    aux.UrlImagen = archivo.SafeFileName;
                    imagenesBackups.Add(aux);
                    cargarImagen(archivo.FileName);
                }
            }
        }

        private void btnGuardarUrl(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen aux = new Imagen();
            Imagen imagenBackup = new Imagen();
            if (articulo != null)//modificacion
            {
                aux.ID = -1;
                aux.IdArticulo = articulo.ID;
                aux.UrlImagen = txtUrlImagen.Text;
                articulo.Imagenes.Add(aux);
                imagenNegocio.agregar(aux);
                cargarImagen(txtUrlImagen.Text);
                MessageBox.Show("Imagen agregada exitosamente");
            }
            else//alta
            {
                aux.UrlImagen = txtUrlImagen.Text;
                aux.ID = -1;
                aux.IdArticulo = -1;
                imagenesAux.Add(aux);
                imagenesBackups.Add(aux);   
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
                //txtUrlImagen.Text = imagenes[0].UrlImagen;
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
                if (!(imag.ToUpper().Contains("HTTP")))//archivo
                {
                    if (articulo != null)
                    {

                        pbxArticulo.Load(ConfigurationManager.AppSettings["images-folder"] + imag);
                    }
                    else
                    {
                        pbxArticulo.Load(imag);
                    }
                }
                else//url
                {
                    pbxArticulo.Load(imag);
                }
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg?w=826");
                //pbxArticulo.Load(ConfigurationManager.AppSettings["images-folder"] + "nodisponible.jpg");
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null) {
                    if (articulo.Imagenes.Count > 0)
                    {
                        List<Imagen> imagenes = new List<Imagen>();
                        imagenes = articulo.Imagenes;
                        int i = 0;
                        foreach (Imagen img in imagenes)
                        {
                            if (!(img.UrlImagen.ToUpper().Contains("HTTP")))//archivo
                            {
                                string path = ConfigurationManager.AppSettings["images-folder"] + img.UrlImagen;
                                if (path == pbxArticulo.ImageLocation)
                                {
                                    if (i == 0)
                                    {
                                        cargarImagen(imagenes[imagenes.Count - 1].UrlImagen);
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i - 1].UrlImagen);
                                        break;
                                    }
                                }
                            }
                            else//url
                            {
                                if (img.UrlImagen == pbxArticulo.ImageLocation)
                                {
                                    if (i == 0)
                                    {
                                        cargarImagen(imagenes[imagenes.Count - 1].UrlImagen);
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i - 1].UrlImagen);
                                        break;
                                    }
                                }
                            }
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay imagenes para mostrar.");
                    }
                }
                else//alta
                {
                    if (imagenesAux.Count > 0)
                    {
                        List<Imagen> imagenes = new List<Imagen>();
                        imagenes = imagenesAux; ;
                        int i = 0;
                        foreach (Imagen img in imagenes)
                        {
                            if (img.UrlImagen == pbxArticulo.ImageLocation)
                            {
                                if (i == 0)
                                {
                                    cargarImagen(imagenes[imagenes.Count - 1].UrlImagen);
                                    break;
                                }
                                else
                                {
                                    cargarImagen(imagenes[i - 1].UrlImagen);
                                    break;
                                }
                            }
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay imagenes para mostrar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null)//modificacion
                {
                    if (articulo.Imagenes.Count > 0)
                    {
                        List<Imagen> imagenes = new List<Imagen>();
                        imagenes = articulo.Imagenes;
                        int i = 0;
                        foreach (Imagen img in imagenes)
                        {
                            if (!(img.UrlImagen.ToUpper().Contains("HTTP")))//archivo
                            {
                                string path = ConfigurationManager.AppSettings["images-folder"] + img.UrlImagen;
                                if (path == pbxArticulo.ImageLocation)
                                {
                                    if (i == imagenes.Count - 1)
                                    {
                                        cargarImagen(imagenes[0].UrlImagen);
                                        contImagenes = 0;
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i + 1].UrlImagen);
                                        contImagenes = i + 1;
                                        break;
                                    }
                                }
                            }
                            else//url
                            {
                                if (img.UrlImagen == pbxArticulo.ImageLocation)
                                {
                                    if (i == imagenes.Count - 1)
                                    {
                                        cargarImagen(imagenes[0].UrlImagen);
                                        contImagenes = 0;
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i + 1].UrlImagen);
                                        contImagenes = i + 1;
                                        break;
                                    }
                                }
                            }
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay imagenes para mostrar.");
                    }
                }
                else//alta
                {
                    if (imagenesAux.Count > 0)
                    {
                        List<Imagen> imagenes = new List<Imagen>();
                        imagenes = imagenesAux; ;
                        int i = 0;
                        foreach (Imagen img in imagenes)
                        {
                            if (!(img.UrlImagen.ToUpper().Contains("HTTP")))//archivo
                            {
                                string path = ConfigurationManager.AppSettings["images-folder"] + img.UrlImagen;
                                if (path == pbxArticulo.ImageLocation)
                                {
                                    if (i == imagenes.Count - 1)
                                    {
                                        cargarImagen(imagenes[0].UrlImagen);
                                        contImagenes = 0;
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i + 1].UrlImagen);
                                        contImagenes = i + 1;
                                        break;
                                    }
                                }
                            }
                            else//url
                            {
                                if (img.UrlImagen == pbxArticulo.ImageLocation)
                                {
                                    if (i == imagenes.Count - 1)
                                    {
                                        cargarImagen(imagenes[0].UrlImagen);
                                        contImagenes = 0;
                                        break;
                                    }
                                    else
                                    {
                                        cargarImagen(imagenes[i + 1].UrlImagen);
                                        contImagenes = i + 1;
                                        break;
                                    }
                                }
                            }
                                i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay imagenes para mostrar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
