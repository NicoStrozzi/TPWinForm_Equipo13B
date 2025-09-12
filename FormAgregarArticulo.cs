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
    public partial class FormAgregarArticulo : Form
    {
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio= new MarcaNegocio();
            CategoriaNegocio categoriaNegocio= new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxCategoria.DataSource=categoriaNegocio.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArt = new Articulo();
            DatoArticulo negocio= new DatoArticulo();
            try
            {
                nuevoArt.Codigo=txtCodigo.Text;
                nuevoArt.Nombre=txtNombre.Text;
                nuevoArt.Descripcion=txtDescripcion.Text;
                nuevoArt.marca = (Marca)cbxMarca.SelectedItem;
                nuevoArt.categoria = (Categoria)cbxCategoria.SelectedItem;
                nuevoArt.precio=decimal.Parse(txtPrecio.Text);

                negocio.agregar(nuevoArt);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
