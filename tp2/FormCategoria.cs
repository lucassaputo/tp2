﻿using Negocio; // agrego la capa de negocio
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

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            txtCategoria.Text = categoria.Descripcion; // seteo el valor del textbox con la descripcion de la categoria seleccionada
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
            //ocultarColumnas(); para no mostrar la columna de ID de Categorias
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
                DialogResult respuesta = MessageBox.Show("Estas seguro de insertar la nueva categoria?", "Agregar categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // mensaje modal de confirmacion para que el usuario confirme
                if (respuesta == DialogResult.Yes)
                {
                    datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                    datos.setearParametro("@Descripcion", txtCategoria.Text); // seteo el valor del parametro descipcion con el valor del textbox txtCategoria
                    datos.ejecutarAccion(); //ejecuto la accion de agrear a la BD
                    Cargar(); // finalmente lo cargo y muestro la grilla actualizada
                }
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
                DialogResult respuesta = MessageBox.Show("Seguro queres eliminar la categoria: " + seleccionada.Descripcion + "?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // mensaje modal de confirmacion. El show es un method que devuelve un DialogResult

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionada.ID); // aca le paso de la categoria seleecionada, el ID
                    Cargar(); // actualizo y muestro la grilla
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }


        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            //Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem; // selecciono la CATEGORIA de la DGV que quiero modificar

            AccesoDatos datos = new AccesoDatos();

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro queres modificar la categoria a: " + txtCategoria.Text + "?", "Modificar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // mensaje modal de confirmacion para que el usuario confirme 

                if (respuesta == DialogResult.Yes)
                {

                    datos.setearConsulta("update CATEGORIAS set Descripcion = @Descripcion where ID = @ID"); // le paso la query de update
                    datos.setearParametro("@ID", txtIDCategoria.Text); // seteo el parametro ID con el valor del txtID
                    datos.setearParametro("@Descripcion", txtCategoria.Text); // seteo el parametro Descripcion con el valor del txtCategoria
                    datos.ejecutarAccion(); // ejecuto la accion de modificar el registro
                    Cargar(); // actualizo y muestro la grilla
                }
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

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            txtCategoria.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString(); // seteo el valor del textbox con la descripcion de la categoria seleccionada
            txtIDCategoria.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString(); // seteo el valor del textbox con el ID de la categoria seleccionada
        }

        private void ocultarColumnas()
        {
            dgvCategorias.Columns["Id"].Visible = false;
        }
    }
}
