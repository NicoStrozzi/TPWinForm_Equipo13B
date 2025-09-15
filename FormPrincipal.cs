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
    public partial class FormPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public FormPrincipal()
        {
            InitializeComponent();

           //ToolTip ttBuscar = new ToolTip();
           //ttBuscar.SetToolTip(txtBuscarArticulos, "Ingrese primeros caracteres para buscar articulos en los campos Codigo y Nombre");
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo AgregarArticulo = new FormAgregarArticulo();
            AgregarArticulo.ShowDialog();
            cargar();            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormDetalleArticulo DetalleArticulo = new FormDetalleArticulo(seleccionado);
            DetalleArticulo.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            cargar();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagenes"].Visible = false;

            if (!(listaArticulos == null || listaArticulos.Count == 0))
                cargarImagen(listaArticulos[0].Imagenes);

            
            actualizarBotonesSegunLista(listaArticulos);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormAgregarArticulo modificar = new FormAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        

        private void dgvArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagenes);
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

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar?","Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
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

        private bool validarBuscar()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un Campo.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un Criterio.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingresar un número para filtrar un campo numérico...");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Ingresar solo números para un campo numérico...");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void actualizarBotonesSegunLista(List<Articulo> lista)
        {
            bool hayArticulos = lista != null && lista.Count > 0;

            btnModificar.Enabled = hayArticulos;
            btnEliminar.Enabled = hayArticulos;
            btnDetalle.Enabled = hayArticulos;
            btnBuscar.Enabled = hayArticulos;
        }
        private void actualizarBotonesSegunGrilla(DataGridView dgv)
        {
            bool hayFilas = dgv != null && dgv.Rows.Count > 0;

            btnModificar.Enabled = hayFilas;
            btnEliminar.Enabled = hayFilas;
            btnDetalle.Enabled = hayFilas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarBuscar())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource=negocio.filtrar(campo,criterio,filtro);

                actualizarBotonesSegunGrilla(dgvArticulos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btBuscarARticulos_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscarArticulos.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["Imagenes"].Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
