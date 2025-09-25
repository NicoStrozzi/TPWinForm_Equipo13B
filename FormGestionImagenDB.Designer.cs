namespace TP_GestionArticulos
{
    partial class FormGestionImagenDB
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
            this.dataGridViewImagenDB = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagenDB = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagenDB = new System.Windows.Forms.Button();
            this.btnModificarImagenDB = new System.Windows.Forms.Button();
            this.btnEliminarImagenDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImagenDB
            // 
            this.dataGridViewImagenDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewImagenDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImagenDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewImagenDB.Location = new System.Drawing.Point(24, 22);
            this.dataGridViewImagenDB.MultiSelect = false;
            this.dataGridViewImagenDB.Name = "dataGridViewImagenDB";
            this.dataGridViewImagenDB.ReadOnly = true;
            this.dataGridViewImagenDB.RowHeadersWidth = 51;
            this.dataGridViewImagenDB.RowTemplate.Height = 24;
            this.dataGridViewImagenDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImagenDB.Size = new System.Drawing.Size(451, 286);
            this.dataGridViewImagenDB.TabIndex = 0;
            this.dataGridViewImagenDB.SelectionChanged += new System.EventHandler(this.dataGridViewImagenDB_SelectionChanged);
            // 
            // pictureBoxImagenDB
            // 
            this.pictureBoxImagenDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxImagenDB.Location = new System.Drawing.Point(602, 22);
            this.pictureBoxImagenDB.Name = "pictureBoxImagenDB";
            this.pictureBoxImagenDB.Size = new System.Drawing.Size(363, 356);
            this.pictureBoxImagenDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenDB.TabIndex = 1;
            this.pictureBoxImagenDB.TabStop = false;
            // 
            // btnAgregarImagenDB
            // 
            this.btnAgregarImagenDB.Location = new System.Drawing.Point(24, 335);
            this.btnAgregarImagenDB.Name = "btnAgregarImagenDB";
            this.btnAgregarImagenDB.Size = new System.Drawing.Size(79, 29);
            this.btnAgregarImagenDB.TabIndex = 2;
            this.btnAgregarImagenDB.Text = "Agregar";
            this.btnAgregarImagenDB.UseVisualStyleBackColor = true;
            this.btnAgregarImagenDB.Click += new System.EventHandler(this.btnAgregarImagenDB_Click);
            // 
            // btnModificarImagenDB
            // 
            this.btnModificarImagenDB.Location = new System.Drawing.Point(164, 335);
            this.btnModificarImagenDB.Name = "btnModificarImagenDB";
            this.btnModificarImagenDB.Size = new System.Drawing.Size(79, 29);
            this.btnModificarImagenDB.TabIndex = 3;
            this.btnModificarImagenDB.Text = "Modificar";
            this.btnModificarImagenDB.UseVisualStyleBackColor = true;
            this.btnModificarImagenDB.Click += new System.EventHandler(this.btnModificarImagenDB_Click);
            // 
            // btnEliminarImagenDB
            // 
            this.btnEliminarImagenDB.Location = new System.Drawing.Point(316, 335);
            this.btnEliminarImagenDB.Name = "btnEliminarImagenDB";
            this.btnEliminarImagenDB.Size = new System.Drawing.Size(79, 29);
            this.btnEliminarImagenDB.TabIndex = 4;
            this.btnEliminarImagenDB.Text = "Eliminar";
            this.btnEliminarImagenDB.UseVisualStyleBackColor = true;
            this.btnEliminarImagenDB.Click += new System.EventHandler(this.btnEliminarImagenDB_Click);
            // 
            // FormGestionImagenDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 404);
            this.Controls.Add(this.btnEliminarImagenDB);
            this.Controls.Add(this.btnModificarImagenDB);
            this.Controls.Add(this.btnAgregarImagenDB);
            this.Controls.Add(this.pictureBoxImagenDB);
            this.Controls.Add(this.dataGridViewImagenDB);
            this.Name = "FormGestionImagenDB";
            this.Text = "Gestion de Imagen";
            this.Load += new System.EventHandler(this.FormGestionImagenDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewImagenDB;
        private System.Windows.Forms.PictureBox pictureBoxImagenDB;
        private System.Windows.Forms.Button btnAgregarImagenDB;
        private System.Windows.Forms.Button btnModificarImagenDB;
        private System.Windows.Forms.Button btnEliminarImagenDB;
    }
}