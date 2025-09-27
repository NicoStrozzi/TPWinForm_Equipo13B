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
    public partial class FormGestionarMarcas : Form
    {
        private MarcaNegocio negocio = new MarcaNegocio();
        
        public FormGestionarMarcas()
        {
            InitializeComponent();
        }
        private void FormGestionarMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                dgvMarcas.DataSource = negocio.Listar();
                if (dgvMarcas.Columns["Id"] != null)
                {
                    dgvMarcas.Columns["Id"].Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionada.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarcas != null)
            {
                return;
            }
            Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            txtDescripcion.Text=seleccionada.Descripcion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion=txtDescripcion.Text.Trim();
            if (descripcion == "")
            {
                MessageBox.Show("Ingrese una marca para agregar");
                return;
            }

            if (negocio.existeMarca(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("La marca ya existe;");
                return;
            }

            Marca nuevaMarca= new Marca();
            nuevaMarca.Descripcion = descripcion;
            try
            {
                negocio.agregar(nuevaMarca);
                cargar();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            seleccionada.Descripcion= txtDescripcion.Text.Trim();

            
            if (seleccionada.Descripcion == "")
            {
                MessageBox.Show("Ingrese una Marca en descripcion");
                return;
            }

            if (negocio.existeMarca(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("La marca ya existe;");
                return;
            }

            negocio.modificar(seleccionada);
            cargar();
            txtDescripcion.Clear();
        }
    }
}
