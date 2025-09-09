using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace TP_GestionArticulos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

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
            dgvArticulos.DataSource = negocio.listar();
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
    }
}
