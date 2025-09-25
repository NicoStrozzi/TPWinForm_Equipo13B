namespace TP_GestionArticulos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFiltrosAvanzados = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btBuscarARticulos = new System.Windows.Forms.Button();
            this.txtBuscarArticulos = new System.Windows.Forms.TextBox();
            this.ttBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.btnGestionMarcas = new System.Windows.Forms.Button();
            this.btnGestionDeImagen = new System.Windows.Forms.Button();
            this.gbFiltrosAvanzados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltrosAvanzados
            // 
            this.gbFiltrosAvanzados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbFiltrosAvanzados.Controls.Add(this.lblFiltro);
            this.gbFiltrosAvanzados.Controls.Add(this.lblCriterio);
            this.gbFiltrosAvanzados.Controls.Add(this.lblCampo);
            this.gbFiltrosAvanzados.Controls.Add(this.btnBuscar);
            this.gbFiltrosAvanzados.Controls.Add(this.txtFiltro);
            this.gbFiltrosAvanzados.Controls.Add(this.cboCriterio);
            this.gbFiltrosAvanzados.Controls.Add(this.cboCampo);
            this.gbFiltrosAvanzados.Location = new System.Drawing.Point(212, 164);
            this.gbFiltrosAvanzados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltrosAvanzados.Name = "gbFiltrosAvanzados";
            this.gbFiltrosAvanzados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltrosAvanzados.Size = new System.Drawing.Size(875, 117);
            this.gbFiltrosAvanzados.TabIndex = 0;
            this.gbFiltrosAvanzados.TabStop = false;
            this.gbFiltrosAvanzados.Text = "Filtrar Articulos";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(363, 33);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(36, 16);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro";
            this.lblFiltro.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(181, 33);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 6;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(8, 33);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(367, 53);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(132, 22);
            this.txtFiltro.TabIndex = 2;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(185, 53);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(160, 24);
            this.cboCriterio.TabIndex = 1;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(8, 53);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(160, 24);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvArticulos.Location = new System.Drawing.Point(212, 287);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(875, 308);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(25, 287);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 60);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(25, 367);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 60);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(25, 453);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 60);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetalle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDetalle.Location = new System.Drawing.Point(25, 538);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(151, 57);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImagen.Location = new System.Drawing.Point(1115, 287);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(388, 308);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(212, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 60);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de articulos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btBuscarARticulos);
            this.gbBusqueda.Controls.Add(this.txtBuscarArticulos);
            this.gbBusqueda.Location = new System.Drawing.Point(1115, 164);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBusqueda.Size = new System.Drawing.Size(389, 116);
            this.gbBusqueda.TabIndex = 9;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar Articulos";
            // 
            // btBuscarARticulos
            // 
            this.btBuscarARticulos.Location = new System.Drawing.Point(253, 54);
            this.btBuscarARticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscarARticulos.Name = "btBuscarARticulos";
            this.btBuscarARticulos.Size = new System.Drawing.Size(100, 28);
            this.btBuscarARticulos.TabIndex = 8;
            this.btBuscarARticulos.Text = "Buscar";
            this.btBuscarARticulos.UseVisualStyleBackColor = true;
            this.btBuscarARticulos.Click += new System.EventHandler(this.btBuscarARticulos_Click);
            // 
            // txtBuscarArticulos
            // 
            this.txtBuscarArticulos.Location = new System.Drawing.Point(29, 54);
            this.txtBuscarArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarArticulos.Name = "txtBuscarArticulos";
            this.txtBuscarArticulos.Size = new System.Drawing.Size(197, 22);
            this.txtBuscarArticulos.TabIndex = 8;
            this.ttBusqueda.SetToolTip(this.txtBuscarArticulos, "*Ingrese primeros caracteres para una busqueda rapida.\r\n*Presione \"Buscar\" sin in" +
        "gresos para traer lista completa.");
            // 
            // ttBusqueda
            // 
            this.ttBusqueda.AutoPopDelay = 5000;
            this.ttBusqueda.InitialDelay = 50;
            this.ttBusqueda.ReshowDelay = 100;
            this.ttBusqueda.ShowAlways = true;
            // 
            // btnGestionMarcas
            // 
            this.btnGestionMarcas.Location = new System.Drawing.Point(352, 106);
            this.btnGestionMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionMarcas.Name = "btnGestionMarcas";
            this.btnGestionMarcas.Size = new System.Drawing.Size(133, 28);
            this.btnGestionMarcas.TabIndex = 10;
            this.btnGestionMarcas.Text = "Gestionar Marcas";
            this.btnGestionMarcas.UseVisualStyleBackColor = true;
            this.btnGestionMarcas.Click += new System.EventHandler(this.btnGestionMarcas_Click);
            // 
            // btnGestionDeImagen
            // 
            this.btnGestionDeImagen.Location = new System.Drawing.Point(915, 106);
            this.btnGestionDeImagen.Name = "btnGestionDeImagen";
            this.btnGestionDeImagen.Size = new System.Drawing.Size(171, 28);
            this.btnGestionDeImagen.TabIndex = 11;
            this.btnGestionDeImagen.Text = "Gestionar Imagenes";
            this.btnGestionDeImagen.UseVisualStyleBackColor = true;
            this.btnGestionDeImagen.Click += new System.EventHandler(this.btnGestionDeImagen_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 652);
            this.Controls.Add(this.btnGestionDeImagen);
            this.Controls.Add(this.btnGestionMarcas);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbFiltrosAvanzados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbFiltrosAvanzados.ResumeLayout(false);
            this.gbFiltrosAvanzados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrosAvanzados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btBuscarARticulos;
        private System.Windows.Forms.TextBox txtBuscarArticulos;
        private System.Windows.Forms.ToolTip ttBusqueda;
        private System.Windows.Forms.Button btnGestionMarcas;
        private System.Windows.Forms.Button btnGestionDeImagen;
    }
}

