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
using negocio;

namespace TP_GestionArticulos
{
    public partial class FormGestionCategoria : Form
    {
        private CategoriaNegocio negocio = new CategoriaNegocio();
        public FormGestionCategoria()
        {
            InitializeComponent();
        }

        private void FormGestionCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                dgvCategoria.DataSource = negocio.Listar();
                if (dgvCategoria.Columns["Id"] != null)
                {
                    dgvCategoria.Columns["Id"].Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = tbDescripcionCat.Text.Trim();
            if (descripcion == "")
            {
                MessageBox.Show("Ingrese categoria para agregar");
                return;
            }

            if (negocio.existeCategoria(tbDescripcionCat.Text.Trim()))
            {
                MessageBox.Show("La categoria ya existe;");
                return;
            }

            Categoria nuevaCat = new Categoria();
            nuevaCat.Descripcion = descripcion;

            try
            {
                nuevaCat.Descripcion = tbDescripcionCat.Text;

                negocio.agregar(nuevaCat);
                cargar();
                tbDescripcionCat.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            seleccionada.Descripcion = tbDescripcionCat.Text.Trim();


            if (seleccionada.Descripcion == "")
            {
                MessageBox.Show("Ingrese descripcion para modificar");
                return;
            }

            if (negocio.existeCategoria(tbDescripcionCat.Text.Trim()))
            {
                MessageBox.Show("La categoria ya existe;");
                return;
            }

            negocio.modificar(seleccionada);
            cargar();
            tbDescripcionCat.Clear();
        }
    }
}
