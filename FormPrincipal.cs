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
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo AgregarArticulo = new FormAgregarArticulo();
            AgregarArticulo.Show();
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FormDetalleArticulo DetalleArticulo = new FormDetalleArticulo();
            DetalleArticulo.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            DatoArticulo negocio = new DatoArticulo();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            pbImagen.Load(listaArticulos[0].Imagenes);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarArticulo ModificarArticulo = new FormModificarArticulo();
            ModificarArticulo.Show();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatoArticulo negocio = new DatoArticulo();
            //dgvArticulos.DataSource = negocio.listar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           // Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
           // pbImagen.Load(seleccionado.Imagenes);
        }

        private void dgvArticulos_Click(object sender, EventArgs e)
        {
            // Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            // pbImagen.Load(seleccionado.Imagenes);
        }
    }
}
