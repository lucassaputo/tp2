using Negocio;
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

namespace tp2
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            txtIdMarca.Enabled = false;
            Cargar();
        }

        private void Cargar()
        {
           MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarcas.DataSource = negocio.listar();
                dgvMarcas.Columns[0].HeaderText = "ID";
                dgvMarcas.Columns[1].HeaderText = "Marca";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor ingrese una marca válida.");
                return false;
            }

            return true;
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            if (!ValidarDescripcion(txtMarca.Text))
            {
                return;
            }
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @Descripcion where ID = @ID");
                datos.setearParametro("@ID", txtIdMarca.Text);
                datos.setearParametro("@Descripcion", txtMarca.Text);
                datos.ejecutarAccion();
                Cargar();
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

        private void btnAgregarMarca_Click(object sender, EventArgs ea)
        {
                       
            AccesoDatos datos = new AccesoDatos();          
            if (!ValidarDescripcion(txtMarca.Text))
            {
                return;
            }
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", txtMarca.Text);
                datos.ejecutarAccion();
                Cargar();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
 
            try
            {
                datos.setearConsulta("delete from MARCAS where ID = @ID");
                datos.setearParametro("@ID", txtIdMarca.Text);
                datos.ejecutarAccion();
                Cargar();
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

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            txtIdMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
