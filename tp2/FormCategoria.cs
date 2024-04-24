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
            Close();
        }
    }
}
