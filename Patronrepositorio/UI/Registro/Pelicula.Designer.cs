namespace Patronrepositorio.UI.Registro
{
    partial class Pelicula
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label extrenoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.registroDbDataSet4 = new Patronrepositorio.RegistroDbDataSet4();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new Patronrepositorio.RegistroDbDataSet4TableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new Patronrepositorio.RegistroDbDataSet4TableAdapters.TableAdapterManager();
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.extrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            peliculaIdLabel = new System.Windows.Forms.Label();
            extrenoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registroDbDataSet4
            // 
            this.registroDbDataSet4.DataSetName = "RegistroDbDataSet4";
            this.registroDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.registroDbDataSet4;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Patronrepositorio.RegistroDbDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(72, 52);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "PeliculaId", true));
            this.peliculaIdTextBox.Location = new System.Drawing.Point(145, 49);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.peliculaIdTextBox.TabIndex = 2;
            // 
            // extrenoLabel
            // 
            extrenoLabel.AutoSize = true;
            extrenoLabel.Location = new System.Drawing.Point(72, 79);
            extrenoLabel.Name = "extrenoLabel";
            extrenoLabel.Size = new System.Drawing.Size(46, 13);
            extrenoLabel.TabIndex = 3;
            extrenoLabel.Text = "Extreno:";
            // 
            // extrenoDateTimePicker
            // 
            this.extrenoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "Extreno", true));
            this.extrenoDateTimePicker.Location = new System.Drawing.Point(145, 75);
            this.extrenoDateTimePicker.Name = "extrenoDateTimePicker";
            this.extrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.extrenoDateTimePicker.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(72, 104);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(145, 101);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(72, 130);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 7;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // categoriaIdTextBox
            // 
            this.categoriaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CategoriaId", true));
            this.categoriaIdTextBox.Location = new System.Drawing.Point(145, 127);
            this.categoriaIdTextBox.Name = "categoriaIdTextBox";
            this.categoriaIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoriaIdTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(extrenoLabel);
            this.Controls.Add(this.extrenoDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdTextBox);
            this.Name = "Pelicula";
            this.Text = "Pelicula";
            this.Load += new System.EventHandler(this.Pelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegistroDbDataSet4 registroDbDataSet4;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private RegistroDbDataSet4TableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private RegistroDbDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.DateTimePicker extrenoDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.Button button1;
    }
}