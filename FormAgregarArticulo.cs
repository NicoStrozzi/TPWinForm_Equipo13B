using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace TP_GestionArticulos
{
    public partial class FormAgregarArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }
        public FormAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
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

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                     if(articulo.Imagenes != null)
                    {
                        txtUrlImagen.Text=articulo.Imagenes;
                    }
                    else
                    {
                        txtUrlImagen.Text = "";
                    }
                    cargarImagen(txtUrlImagen.Text);

                    cbxMarca.Text = articulo.Marca.ToString();
                    cbxCategoria.Text = articulo.Categoria.ToString();
                    txtPrecio.Text = articulo.Precio.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio= new ArticuloNegocio();
            try
            {
                if (txtCodigo.Text == "" ||
                    txtNombre.Text == "" ||
                    txtDescripcion.Text == "" ||
                    txtPrecio.Text == "" ||
                    cbxMarca.SelectedIndex == -1 ||
                    cbxCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                decimal precio;
                try
                {
                    precio = decimal.Parse(txtPrecio.Text); 
                }
                catch
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return; 
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a 0.");
                    return;
                }

                if ((articulo == null || articulo.Id == 0) && negocio.ExisteCodigo(txtCodigo.Text.Trim()))
                {
                    MessageBox.Show("El código ya existe. Ingrese otro.");
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo=txtCodigo.Text;
                articulo.Nombre=txtNombre.Text;
                articulo.Descripcion=txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = precio; // decimal.Parse(txtPrecio.Text);
                articulo.Imagenes=txtUrlImagen.Text;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                //Guarda la imagen si la levanta localmente
                if(archivo!=null&&!(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    string destino = ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName;
                    if(!File.Exists(destino)) 
                    File.Copy(archivo.FileName, destino);
                }
                //Si estamos modificando, agregar nueva imagen si no existe
                string url = txtUrlImagen.Text.Trim();
                if (articulo.Id != 0 && url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    List<string> existentes = negocio.ListarImagenes(articulo.Id);
                    if (!existentes.Contains(url))
                        negocio.AgregarImagen(articulo.Id, url);
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gpImagenes_Enter(object sender, EventArgs e)
        {

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
      
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo=new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                string destino = ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName;

                if (File.Exists(destino))
                {
                    MessageBox.Show("La imagen ya existe en la carpeta. Elegi otra o cambia el nombre.");
                    return;
                }
                File.Copy(archivo.FileName, destino);
            }
            }
    }
}
