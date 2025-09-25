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
    public partial class FormGestionImagenDB : Form
    {
        private List<Imagen> listaDeImagen;
        public FormGestionImagenDB()
        {
            InitializeComponent();
        }

        private void FormGestionImagenDB_Load(object sender, EventArgs e)
        {
            cargar();
            if (!(listaDeImagen == null || listaDeImagen.Count == 0))
                cargarImagen(listaDeImagen[0].ImagenUrl);
            actualizarBotonesSegunLista(listaDeImagen);
        }

        private void cargar()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            listaDeImagen = negocio.listar();
            dataGridViewImagenDB.DataSource = listaDeImagen;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenDB.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxImagenDB.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }

        }

        private void dataGridViewImagenDB_SelectionChanged(object sender, EventArgs e)
        {
            Imagen seleccionado = (Imagen)dataGridViewImagenDB.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void btnAgregarImagenDB_Click(object sender, EventArgs e)
        {
            FormAgregarImagen agregarImagen = new FormAgregarImagen();
            agregarImagen.ShowDialog();
            cargar();
            actualizarBotonesSegunLista(listaDeImagen);
        }

        private void btnModificarImagenDB_Click(object sender, EventArgs e)
        {
            Imagen seleccionado;
            seleccionado = (Imagen)dataGridViewImagenDB.CurrentRow.DataBoundItem;

            FormAgregarImagen modificar = new FormAgregarImagen(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarImagenDB_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Imagen)dataGridViewImagenDB.CurrentRow.DataBoundItem;
                    negocio.eliminarImagen(seleccionado.Id);
                    cargar();
                    actualizarBotonesSegunLista(listaDeImagen);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        //********************VALIDACIONES***************************
        private void actualizarBotonesSegunLista(List<Imagen> lista)
        {
            bool hayImagen = lista != null && lista.Count > 0;

            btnModificarImagenDB.Enabled = hayImagen;
            btnEliminarImagenDB.Enabled = hayImagen;

        }

    }
}
