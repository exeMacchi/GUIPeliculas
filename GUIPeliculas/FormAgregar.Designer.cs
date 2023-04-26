namespace GUIPeliculas1
{
    partial class FormAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbTituloPelicula = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbAnioEstreno = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbEstreno = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.btAniadir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(46, 48);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(443, 41);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Ficha técnica película";
            // 
            // lbTituloPelicula
            // 
            this.lbTituloPelicula.AutoSize = true;
            this.lbTituloPelicula.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPelicula.Location = new System.Drawing.Point(77, 113);
            this.lbTituloPelicula.Name = "lbTituloPelicula";
            this.lbTituloPelicula.Size = new System.Drawing.Size(85, 23);
            this.lbTituloPelicula.TabIndex = 1;
            this.lbTituloPelicula.Text = "Título";
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirector.Location = new System.Drawing.Point(50, 160);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(112, 23);
            this.lbDirector.TabIndex = 2;
            this.lbDirector.Text = "Director";
            // 
            // lbAnioEstreno
            // 
            this.lbAnioEstreno.AutoSize = true;
            this.lbAnioEstreno.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnioEstreno.Location = new System.Drawing.Point(64, 202);
            this.lbAnioEstreno.Name = "lbAnioEstreno";
            this.lbAnioEstreno.Size = new System.Drawing.Size(98, 23);
            this.lbAnioEstreno.TabIndex = 3;
            this.lbAnioEstreno.Text = "Estreno";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(70, 247);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(92, 23);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "Género";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(173, 113);
            this.tbTitulo.MaxLength = 100;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(254, 27);
            this.tbTitulo.TabIndex = 5;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbTitulo_TextChanged);
            // 
            // tbDirector
            // 
            this.tbDirector.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirector.Location = new System.Drawing.Point(173, 160);
            this.tbDirector.MaxLength = 1000;
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(254, 27);
            this.tbDirector.TabIndex = 6;
            this.tbDirector.TextChanged += new System.EventHandler(this.tbDirector_TextChanged);
            // 
            // tbEstreno
            // 
            this.tbEstreno.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstreno.Location = new System.Drawing.Point(173, 202);
            this.tbEstreno.MaxLength = 5;
            this.tbEstreno.Name = "tbEstreno";
            this.tbEstreno.Size = new System.Drawing.Size(254, 27);
            this.tbEstreno.TabIndex = 7;
            this.tbEstreno.TextChanged += new System.EventHandler(this.tbAnioDeEstreno_TextChanged);
            this.tbEstreno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstreno_KeyPress);
            // 
            // tbGenero
            // 
            this.tbGenero.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenero.Location = new System.Drawing.Point(173, 247);
            this.tbGenero.MaxLength = 1000;
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(254, 27);
            this.tbGenero.TabIndex = 8;
            this.tbGenero.TextChanged += new System.EventHandler(this.tbGenero_TextChanged);
            // 
            // btAniadir
            // 
            this.btAniadir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAniadir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAniadir.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAniadir.Location = new System.Drawing.Point(59, 311);
            this.btAniadir.Name = "btAniadir";
            this.btAniadir.Size = new System.Drawing.Size(189, 44);
            this.btAniadir.TabIndex = 9;
            this.btAniadir.Text = "Añadir";
            this.btAniadir.UseVisualStyleBackColor = true;
            this.btAniadir.Click += new System.EventHandler(this.btAniadir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancelar.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(283, 311);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(189, 44);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 391);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAniadir);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbEstreno);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbAnioEstreno);
            this.Controls.Add(this.lbDirector);
            this.Controls.Add(this.lbTituloPelicula);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva película";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbTituloPelicula;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbAnioEstreno;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbEstreno;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Button btAniadir;
        private System.Windows.Forms.Button btCancelar;
    }
}