namespace TP_GestionArticulos
{
    partial class FormDetalleArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.lbl1de1 = new System.Windows.Forms.Label();
            this.lblMostrarCodigo = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblMostrarDescrpcion = new System.Windows.Forms.Label();
            this.lblMostrarMarca = new System.Windows.Forms.Label();
            this.lblMostrarCategoria = new System.Windows.Forms.Label();
            this.lblMostrarPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(179, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(179, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(179, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(179, 172);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(179, 205);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(179, 242);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(182, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(332, 388);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 15;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(208, 388);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 14;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // lbl1de1
            // 
            this.lbl1de1.AutoSize = true;
            this.lbl1de1.Location = new System.Drawing.Point(289, 393);
            this.lbl1de1.Name = "lbl1de1";
            this.lbl1de1.Size = new System.Drawing.Size(37, 13);
            this.lbl1de1.TabIndex = 13;
            this.lbl1de1.Text = "1 de 1";
            this.lbl1de1.Click += new System.EventHandler(this.lbl1de1_Click);
            // 
            // lblMostrarCodigo
            // 
            this.lblMostrarCodigo.AutoSize = true;
            this.lblMostrarCodigo.Location = new System.Drawing.Point(264, 84);
            this.lblMostrarCodigo.Name = "lblMostrarCodigo";
            this.lblMostrarCodigo.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarCodigo.TabIndex = 13;
            this.lblMostrarCodigo.Text = "\"  \"";
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.AutoSize = true;
            this.lblMostrarNombre.Location = new System.Drawing.Point(264, 111);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarNombre.TabIndex = 14;
            this.lblMostrarNombre.Text = "\"  \"";
            // 
            // lblMostrarDescrpcion
            // 
            this.lblMostrarDescrpcion.AutoSize = true;
            this.lblMostrarDescrpcion.Location = new System.Drawing.Point(264, 139);
            this.lblMostrarDescrpcion.Name = "lblMostrarDescrpcion";
            this.lblMostrarDescrpcion.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarDescrpcion.TabIndex = 15;
            this.lblMostrarDescrpcion.Text = "\"  \"";
            this.lblMostrarDescrpcion.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblMostrarMarca
            // 
            this.lblMostrarMarca.AutoSize = true;
            this.lblMostrarMarca.Location = new System.Drawing.Point(264, 172);
            this.lblMostrarMarca.Name = "lblMostrarMarca";
            this.lblMostrarMarca.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarMarca.TabIndex = 16;
            this.lblMostrarMarca.Text = "\"  \"";
            this.lblMostrarMarca.Click += new System.EventHandler(this.lblMostrarMarca_Click);
            // 
            // lblMostrarCategoria
            // 
            this.lblMostrarCategoria.AutoSize = true;
            this.lblMostrarCategoria.Location = new System.Drawing.Point(264, 205);
            this.lblMostrarCategoria.Name = "lblMostrarCategoria";
            this.lblMostrarCategoria.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarCategoria.TabIndex = 17;
            this.lblMostrarCategoria.Text = "\"  \"";
            // 
            // lblMostrarPrecio
            // 
            this.lblMostrarPrecio.AutoSize = true;
            this.lblMostrarPrecio.Location = new System.Drawing.Point(264, 242);
            this.lblMostrarPrecio.Name = "lblMostrarPrecio";
            this.lblMostrarPrecio.Size = new System.Drawing.Size(23, 13);
            this.lblMostrarPrecio.TabIndex = 18;
            this.lblMostrarPrecio.Text = "\"  \"";
            // 
            // FormDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.lblMostrarPrecio);
            this.Controls.Add(this.lbl1de1);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.lblMostrarCategoria);
            this.Controls.Add(this.lblMostrarMarca);
            this.Controls.Add(this.lblMostrarDescrpcion);
            this.Controls.Add(this.lblMostrarNombre);
            this.Controls.Add(this.lblMostrarCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormDetalleArticulo";
            this.Text = "Detalle de Artículo";
            this.Load += new System.EventHandler(this.FormDetalleArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Label lbl1de1;
        private System.Windows.Forms.Label lblMostrarCodigo;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.Label lblMostrarDescrpcion;
        private System.Windows.Forms.Label lblMostrarMarca;
        private System.Windows.Forms.Label lblMostrarCategoria;
        private System.Windows.Forms.Label lblMostrarPrecio;
    }
}