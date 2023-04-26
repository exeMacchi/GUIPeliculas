using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPeliculas1
{
    public partial class FormAgregar : Form
    {
        // Campos
        private string titulo;
        private string director;
        private int estreno;
        private string genero;
        private bool tituloTxBx, directorTxBx, estrenoTxBx, generoTxBx;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Director { get { return director; } set { director = value; } }
        public int Estreno { get { return estreno; } set { estreno = value; } }
        public string Genero { get { return genero; } set { genero = value; } }

        // Constructor
        public FormAgregar()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.folder_movie;
        }

        // Métodos
        public void Limpiar()
        {
            tbTitulo.Text = "";
            tbDirector.Text = "";
            tbEstreno.Text = "";
            tbGenero.Text = "";

            tituloTxBx = false;
            directorTxBx = false;
            estrenoTxBx = false;
            generoTxBx = false;

            btAniadir.Enabled = false;
        }

        public void Edicion(string titulo, string director, int estreno, string genero)
        {
            tbTitulo.Text = titulo;
            tbDirector.Text = director;
            tbEstreno.Text = Convert.ToString(estreno);
            tbGenero.Text = genero;
        }

        // Eventos
        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "")
            {
                tituloTxBx = false;
                btAniadir.Enabled = false;
            }
            else
            {
                tituloTxBx = true;
                if (tituloTxBx && directorTxBx && estrenoTxBx && generoTxBx)
                {
                    btAniadir.Enabled = true;
                }
            }
        }

        private void tbDirector_TextChanged(object sender, EventArgs e)
        {
            if (tbDirector.Text == "")
            {
                directorTxBx = false;
                btAniadir.Enabled = false;
            }
            else
            {
                directorTxBx = true;
                if (tituloTxBx && directorTxBx && estrenoTxBx && generoTxBx)
                {
                    btAniadir.Enabled = true;
                }
            }

        }

        private void tbAnioDeEstreno_TextChanged(object sender, EventArgs e)
        {
            if (tbEstreno.Text == "")
            {
                estrenoTxBx = false;
                btAniadir.Enabled = false;
            }
            else
            {
                estrenoTxBx = true;
                if (tituloTxBx && directorTxBx && estrenoTxBx && generoTxBx)
                {
                    btAniadir.Enabled = true;
                }
            }

        }

        private void tbGenero_TextChanged(object sender, EventArgs e)
        {
            if (tbGenero.Text == "")
            {
                generoTxBx = false;
                btAniadir.Enabled = false;
            }
            else
            {
                generoTxBx = true;
                if (tituloTxBx && directorTxBx && estrenoTxBx && generoTxBx)
                {
                    btAniadir.Enabled = true;
                }
            }

        }

        private void tbEstreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btAniadir_Click(object sender, EventArgs e)
        {
            Titulo = tbTitulo.Text;
            Director = tbDirector.Text;
            try
            {
                Estreno = Convert.ToInt32(tbEstreno.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Genero = tbGenero.Text;

            this.Close();
        }
    }
}
