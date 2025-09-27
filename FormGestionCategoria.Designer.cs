namespace TP_GestionArticulos
{
    partial class FormGestionCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.tbDescripcionCat = new System.Windows.Forms.TextBox();
            this.lblDescripcionCateg = new System.Windows.Forms.Label();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(382, 48);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(392, 209);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(6, 83);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(94, 24);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar ";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbDescripcionCat
            // 
            this.tbDescripcionCat.Location = new System.Drawing.Point(154, 23);
            this.tbDescripcionCat.Name = "tbDescripcionCat";
            this.tbDescripcionCat.Size = new System.Drawing.Size(172, 20);
            this.tbDescripcionCat.TabIndex = 2;
            // 
            // lblDescripcionCateg
            // 
            this.lblDescripcionCateg.AutoSize = true;
            this.lblDescripcionCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCateg.Location = new System.Drawing.Point(12, 26);
            this.lblDescripcionCateg.Name = "lblDescripcionCateg";
            this.lblDescripcionCateg.Size = new System.Drawing.Size(136, 13);
            this.lblDescripcionCateg.TabIndex = 3;
            this.lblDescripcionCateg.Text = "Descripcion Categoria:";
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.btnEliminarCategoria);
            this.gbAgregar.Controls.Add(this.btnModificarCategoria);
            this.gbAgregar.Controls.Add(this.lblDescripcionCateg);
            this.gbAgregar.Controls.Add(this.tbDescripcionCat);
            this.gbAgregar.Controls.Add(this.btnAgregarCategoria);
            this.gbAgregar.Location = new System.Drawing.Point(12, 38);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(339, 142);
            this.gbAgregar.TabIndex = 4;
            this.gbAgregar.TabStop = false;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(123, 83);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(94, 24);
            this.btnModificarCategoria.TabIndex = 4;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(232, 83);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(94, 24);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // FormGestionCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 288);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.dgvCategoria);
            this.Name = "FormGestionCategoria";
            this.Text = "Gestionar Categoria";
            this.Load += new System.EventHandler(this.FormGestionCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox tbDescripcionCat;
        private System.Windows.Forms.Label lblDescripcionCateg;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
    }
}