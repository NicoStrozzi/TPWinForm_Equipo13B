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
    public partial class FormGestionarArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public FormGestionarArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagenes"].Visible = false;

            if (!(listaArticulos == null || listaArticulos.Count == 0))
                cargarImagen(listaArticulos[0].Imagenes);
        }

        private void cargarImagen(string imagenes)
        {
            try
            {
                pbImagen.Load(imagenes);
            }
            catch (Exception)
            {

                pbImagen.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
        private void FormGestionarArticulos_Load(object sender, EventArgs e)
        {
            cargar();

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagenes"].Visible = false;

            if (!(listaArticulos == null || listaArticulos.Count == 0))
                cargarImagen(listaArticulos[0].Imagenes);


            actualizarBotonesSegunLista(listaArticulos);

        }
        private void actualizarBotonesSegunLista(List<Articulo> lista)
        {
            bool hayArticulos = lista != null && lista.Count > 0;

            btnModificar.Enabled = hayArticulos;
            btnEliminar.Enabled = hayArticulos;
           
        }
        private void actualizarBotonesSegunGrilla(DataGridView dgv)
        {
            bool hayFilas = dgv != null && dgv.Rows.Count > 0;

            btnModificar.Enabled = hayFilas;
            btnEliminar.Enabled = hayFilas;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo AgregarArticulo = new FormAgregarArticulo();
            AgregarArticulo.ShowDialog();
            cargar();
            actualizarBotonesSegunLista(listaArticulos);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormDetalleArticulo DetalleArticulo = new FormDetalleArticulo(seleccionado);
            DetalleArticulo.Show();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormAgregarArticulo modificar = new FormAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                    actualizarBotonesSegunLista(listaArticulos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagenes);
        }
    }
}
