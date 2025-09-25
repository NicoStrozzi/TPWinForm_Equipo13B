using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP_GestionArticulos
{
    public partial class FormAgregarImagen : Form
    {
        private Imagen imagen = null;
        public FormAgregarImagen()
        {
            InitializeComponent();
        }

        public FormAgregarImagen(Imagen imagen)
        {
            InitializeComponent();
            this.imagen = imagen;
            Text = "Modificar Imagen";
        }

        private void FormAgregarImagen_Load(object sender, EventArgs e)
        {
            try
            {
                if (imagen != null)
                {
                    txtIdArticulo.Text = imagen.IdArticulo.ToString();
                    txtUrlImagen.Text = imagen.ImagenUrl;

                    if (imagen.ImagenUrl != null)
                    {
                        txtUrlImagen.Text = imagen.ImagenUrl;
                    }
                    else
                    {
                        txtUrlImagen.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            try
            {


                if (txtIdArticulo.Text == "" || txtUrlImagen.Text == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }
                if (!int.TryParse(txtIdArticulo.Text, out int IdArticulo) || IdArticulo <= 0)
                {
                    MessageBox.Show("Ingresar solo números positivos para el Id Artículo...");
                    return;
                }

                if (!negocio.existeArticulo(int.Parse(txtIdArticulo.Text)))
                {
                    MessageBox.Show("El Id de artículo no existe. No se puede ingresar la imagen.");
                    return;
                }

                if (!esUrlValida(txtUrlImagen.Text))
                {
                    MessageBox.Show("La URL ingresada no es válida. Debe comenzar con http:// o https://");
                    return;
                }

                if (imagen == null)
                    imagen = new Imagen();

                imagen.IdArticulo = int.Parse(txtIdArticulo.Text);
                imagen.ImagenUrl = txtUrlImagen.Text;

                if (imagen.Id != 0)
                {
                    if (!negocio.existeImagen(imagen.Id))
                    {
                        MessageBox.Show("La imagen no existe. No se puede modificar.");
                        return;
                    }

                    negocio.modificarImagen(imagen);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                }
                else
                {
                    negocio.agregarImagen(imagen.IdArticulo, imagen.ImagenUrl);
                    MessageBox.Show("Agregado exitosamente");
                    Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Validaciones
        private bool esUrlValida(string texto)
        {
            return Uri.TryCreate(texto, UriKind.Absolute, out Uri uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
