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
    public partial class FormDetalleArticulo : Form
    {
        private Articulo articulo;
        private List<string> imagenes;
        private int indiceActual = 0;
        public FormDetalleArticulo(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl1de1_Click(object sender, EventArgs e)
        {

        }

        private void FormDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblMostrarCodigo.Text =articulo.Codigo;
            lblMostrarNombre.Text = articulo.Nombre;
            lblMostrarDescripcion.Text = articulo.Descripcion;
            lblMostrarMarca.Text = articulo.Marca.Descripcion;
            lblMostrarCategoria.Text = articulo.Categoria.Descripcion;
            lblMostrarPrecio.Text = articulo.Precio.ToString();

            // Cargar TODAS las imágenes del artículo 
            List<string> imgs = new ArticuloNegocio().ListarImagenes(articulo.Id);
            imagenes = imgs;            // tu lista privada para recorrer
            if (imagenes.Count > 0)
            {
                cargarImagen(imagenes[0]);
            }
            else
            {
                cargarImagen(articulo.Imagenes);
            }
        }

        private void cargarImagen(string imagenes)
        {
            try
            {
                pbImagenDetalle.Load(imagenes);
            }
            catch (Exception)
            {

                pbImagenDetalle.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }

        }

        private void lblMostrarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
            {
                return;
            }
            else
            {
                indiceActual = (indiceActual - 1 + imagenes.Count) % imagenes.Count;
                cargarImagen(imagenes[indiceActual]);

            }

        }

        private void btnDerecha_Click_1(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
            {
                return;
            }
            else
            {
                indiceActual = (indiceActual + 1) % imagenes.Count;
                cargarImagen(imagenes[indiceActual]);
            }
        }
    }
}
