using Negocio; // agrego la capa de negocio
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tp2
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio(); 
            try
            {
                dgvCategorias.DataSource = negocio.listar();
                dgvCategorias.Columns[0].HeaderText = "ID";
                dgvCategorias.Columns[1].HeaderText = "Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close(); // cierra el form y vuelve atras
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos(); // el objeto datos me permite conectarme al servidor y ejecutar las sentencias sql

            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)"); 
                datos.setearParametro("@Descripcion", txtCategoria.Text); // seteo el valor del parametro descipcion con el valor del textbox txtCategoria
                datos.ejecutarAccion(); //ejecuto la accion de agrear a la BD
                Cargar(); // finalmente lo cargo. A listo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem; // selecciono la CATEGORIA de la DGV que quiero eliminar
            try
            {
                negocio.eliminar(seleccionada.ID); // aca le paso de la categoria seleecionada, el ID
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }

      

    }
}
