using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Design;

namespace GUIPeliculas1
{
    public partial class FormPrincipal : Form
    {
        // Campos
        private FormAgregar formAgregar;
        private List<Pelicula> listaPeliculas;
        private int cantidadPeliculas;
        private string rutaFichero = Path.Combine(Directory.GetCurrentDirectory(), 
                                                  "PeliculasDB.txt");

        // Constructor
        public FormPrincipal()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.folder_movie;
            formAgregar = new FormAgregar();
            listaPeliculas = new List<Pelicula>();
            if (!File.Exists(rutaFichero))
            {
                CrearBaseDeDatos(ref cantidadPeliculas);
            }
            else
            {
                CargarPeliculas(ref cantidadPeliculas);
                Refrescar();
            }
        }

        // Métodos
        private void CrearBaseDeDatos(ref int cantidadPeliculas)
        {
            DialogResult respuesta = MessageBox.Show("No existe una base de datos en " +
                                     "la ruta especificada, ¿desea crear una nueva base de datos?",
                                     "Base de datos no encontrada",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (respuesta == DialogResult.Yes)
            {
                File.CreateText(rutaFichero).Close();
                cantidadPeliculas = 0;
                MessageBox.Show("Base de datos creada con éxito.", "Base de datos creada",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }

        private void CargarPeliculas(ref int cantidadPeliculas)
        {            
            StreamReader fichero = File.OpenText(rutaFichero);
            cantidadPeliculas = Convert.ToInt32(fichero.ReadLine());
            for (int i = 0; i < cantidadPeliculas; i++)
            {
                string separador = fichero.ReadLine();
                string titulo = fichero.ReadLine();
                string director = fichero.ReadLine();
                int anioDeEstreno = Convert.ToInt32(fichero.ReadLine());
                string genero = fichero.ReadLine();

                Pelicula p = new Pelicula(titulo, director, anioDeEstreno, genero);
                listaPeliculas.Add(p);
            }
            fichero.Close();
        }

        private void AgregarNuevaPelicula()
        {
            string titulo = formAgregar.Titulo;
            string director = formAgregar.Director;
            int anioDeEstreno = formAgregar.Estreno;
            string genero = formAgregar.Genero;
            Pelicula p = new Pelicula(titulo, director, anioDeEstreno, genero);
            listaPeliculas.Add(p);
            cantidadPeliculas++;
        }

        private void GuardarPeliculas()
        {
            StreamWriter escritorFichero = File.CreateText(rutaFichero);
            escritorFichero.WriteLine(cantidadPeliculas);
            foreach(Pelicula p in listaPeliculas)
            {
                escritorFichero.WriteLine();
                escritorFichero.WriteLine(p.Titulo);
                escritorFichero.WriteLine(p.Director);
                escritorFichero.WriteLine(p.Estreno);
                escritorFichero.WriteLine(p.Genero);
            }
            escritorFichero.Close();
        }

        private void Refrescar()
        {
            if (listaPeliculas != null)
            {
                dataGridView1.DataSource = typeof(Pelicula);
                OrdenarPeliculas();
                dataGridView1.DataSource = listaPeliculas;
            }
        }

        private void OrdenarPeliculas()
        {
            listaPeliculas.Sort((p1, p2) => (p1.Titulo.CompareTo(p2.Titulo)));
        }

        // Eventos
        private void btAgregar_Click(object sender, EventArgs e)
        {
            formAgregar.Limpiar();
            formAgregar.Text = "Nueva película";
            DialogResult respuesta = formAgregar.ShowDialog();
            if (respuesta != DialogResult.Cancel)
            {
                AgregarNuevaPelicula();
                Refrescar();
                GuardarPeliculas();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("No ha seleccionado una fila", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int indice = dataGridView1.SelectedRows[0].Index;

                DialogResult respuesta = MessageBox.Show($"¿Desea eliminar la siguiente " +
                                         $"película?\n{listaPeliculas[indice]}", "Aviso", 
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    listaPeliculas.RemoveAt(indice);
                    cantidadPeliculas--;
                    Refrescar();
                    GuardarPeliculas();
                }
            }
        }

        private void borrarFilaSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btBorrar_Click(sender, e);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("No ha seleccionado una fila", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int indice = dataGridView1.SelectedRows[0].Index;

                formAgregar.Text = "Editar película";
                formAgregar.Limpiar();
                formAgregar.Edicion(listaPeliculas[indice].Titulo,
                                    listaPeliculas[indice].Director,
                                    listaPeliculas[indice].Estreno, 
                                    listaPeliculas[indice].Genero);

                DialogResult respuesta = formAgregar.ShowDialog();

                if (respuesta != DialogResult.Cancel)
                {                    
                    listaPeliculas[indice].Titulo = formAgregar.Titulo;
                    listaPeliculas[indice].Director = formAgregar.Director;
                    try
                    {
                        listaPeliculas[indice].Estreno =
                            Convert.ToInt32(formAgregar.Estreno);
                    }
                    catch (Exception ex)
                    {
                        listaPeliculas[indice].Estreno = 0;
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    listaPeliculas[indice].Genero = formAgregar.Genero;

                    GuardarPeliculas();
                    Refrescar();
                }
            }
        }

        private void btZoomMas_Click(object sender, EventArgs e)
        {
            short num = 1;
            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 
                                          dataGridView1.Font.Size + num);
        }

        private void btZoomMenos_Click(object sender, EventArgs e)
        {
            short num = -1;
            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 
                                          dataGridView1.Font.Size + num);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarPeliculas();
        }
    }
}
