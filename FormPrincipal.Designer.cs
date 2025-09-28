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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnGestionarArticulos = new System.Windows.Forms.Button();
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
            this.gbFiltrosAvanzados.Controls.Add(this.btnDetalle);
            this.gbFiltrosAvanzados.Location = new System.Drawing.Point(39, 94);
            this.gbFiltrosAvanzados.Name = "gbFiltrosAvanzados";
            this.gbFiltrosAvanzados.Size = new System.Drawing.Size(656, 95);
            this.gbFiltrosAvanzados.TabIndex = 0;
            this.gbFiltrosAvanzados.TabStop = false;
            this.gbFiltrosAvanzados.Text = "Filtrar Articulos";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(272, 27);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(136, 27);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 6;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(6, 27);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(396, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(275, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(139, 43);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 1;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(6, 43);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvArticulos.Location = new System.Drawing.Point(39, 195);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(656, 250);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged_1);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetalle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetalle.Location = new System.Drawing.Point(510, 25);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(111, 38);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Detalle Articulo";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImagen.Location = new System.Drawing.Point(716, 194);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(291, 250);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 49);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de articulos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btBuscarARticulos);
            this.gbBusqueda.Controls.Add(this.txtBuscarArticulos);
            this.gbBusqueda.Location = new System.Drawing.Point(716, 94);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(292, 94);
            this.gbBusqueda.TabIndex = 9;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar Articulos";
            // 
            // btBuscarARticulos
            // 
            this.btBuscarARticulos.Location = new System.Drawing.Point(190, 44);
            this.btBuscarARticulos.Name = "btBuscarARticulos";
            this.btBuscarARticulos.Size = new System.Drawing.Size(75, 23);
            this.btBuscarARticulos.TabIndex = 8;
            this.btBuscarARticulos.Text = "Buscar";
            this.btBuscarARticulos.UseVisualStyleBackColor = true;
            this.btBuscarARticulos.Click += new System.EventHandler(this.btBuscarARticulos_Click);
            // 
            // txtBuscarArticulos
            // 
            this.txtBuscarArticulos.Location = new System.Drawing.Point(22, 44);
            this.txtBuscarArticulos.Name = "txtBuscarArticulos";
            this.txtBuscarArticulos.Size = new System.Drawing.Size(149, 20);
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
            this.btnGestionMarcas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGestionMarcas.Location = new System.Drawing.Point(211, 465);
            this.btnGestionMarcas.Name = "btnGestionMarcas";
            this.btnGestionMarcas.Size = new System.Drawing.Size(111, 38);
            this.btnGestionMarcas.TabIndex = 10;
            this.btnGestionMarcas.Text = "Gestionar Marcas";
            this.btnGestionMarcas.UseVisualStyleBackColor = false;
            this.btnGestionMarcas.Click += new System.EventHandler(this.btnGestionMarcas_Click);
            // 
            // btnGestionDeImagen
            // 
            this.btnGestionDeImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGestionDeImagen.Location = new System.Drawing.Point(584, 465);
            this.btnGestionDeImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionDeImagen.Name = "btnGestionDeImagen";
            this.btnGestionDeImagen.Size = new System.Drawing.Size(111, 38);
            this.btnGestionDeImagen.TabIndex = 11;
            this.btnGestionDeImagen.Text = "Gestionar Imagenes";
            this.btnGestionDeImagen.UseVisualStyleBackColor = false;
            this.btnGestionDeImagen.Click += new System.EventHandler(this.btnGestionDeImagen_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCategoria.Location = new System.Drawing.Point(399, 465);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(111, 38);
            this.btnCategoria.TabIndex = 12;
            this.btnCategoria.Text = "Gestionar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnGestionarArticulos
            // 
            this.btnGestionarArticulos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGestionarArticulos.Location = new System.Drawing.Point(39, 465);
            this.btnGestionarArticulos.Name = "btnGestionarArticulos";
            this.btnGestionarArticulos.Size = new System.Drawing.Size(111, 38);
            this.btnGestionarArticulos.TabIndex = 13;
            this.btnGestionarArticulos.Text = "Gestionar Articulos";
            this.btnGestionarArticulos.UseVisualStyleBackColor = false;
            this.btnGestionarArticulos.Click += new System.EventHandler(this.btnGestionarArticulos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 527);
            this.Controls.Add(this.btnGestionarArticulos);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnGestionDeImagen);
            this.Controls.Add(this.btnGestionMarcas);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbFiltrosAvanzados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvArticulos);
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
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnGestionarArticulos;
    }
}

