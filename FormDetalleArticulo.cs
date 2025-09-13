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

namespace TP_GestionArticulos
{
    public partial class FormDetalleArticulo : Form
    {
        private Articulo articulo;
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
                   
            cargarImagen(articulo.Imagenes);
        }

        private void cargarImagen(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url))
                    pbxImagen.Load("https://via.placeholder.com/300x400?text=Sin+imagen");
                else
                    pbxImagen.Load(url);
            }
            catch
            {
                pbxImagen.Load("https://via.placeholder.com/300x400?text=Error");
            }
        }

        private void lblMostrarMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
