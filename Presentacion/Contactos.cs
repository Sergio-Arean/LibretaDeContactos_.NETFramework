using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Presentacion
{
    public partial class Contactos : Form
    {
        private LibretaDeContactos libreta;
        private List<Contacto> contactos;
        private Principal formulario_padre;
        public Contactos(LibretaDeContactos libreta,Principal formulario_padre)
        {
            this.libreta = libreta;
            this.formulario_padre = formulario_padre;
            InitializeComponent();
            ActualizarContactos();
            MensajeEnGrilla(false); 
        }



        /// <summary>
        /// Metodo que carga los contactos en la grilla, una vez que estos han sido ordenados.
        /// </summary>
        public void ActualizarContactos()
        {
            contactos = libreta.listarContactos();
            OrdenarLista();
            dgvContactos.DataSource = contactos;
            PersonalizarTabla();
        }

        /// <summary>
        /// Le da formato a nuestra tabla (datagrid) personalizando sus respectivas columnas, y mensajes en pantalla.
        /// </summary>
        private void PersonalizarTabla()
        {
            // Ocultar columnas
            dgvContactos.Columns["Id"].Visible = false;
            dgvContactos.Columns["ImagenUrl"].Visible = false;

            //Nombres personalizados
            dgvContactos.Columns["Telefono"].HeaderText = "Teléfono";

            //tamaño de columnas
            dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvContactos.Columns["Nombre"].Width = 150;
            dgvContactos.Columns["Telefono"].Width = 100;
            dgvContactos.Columns["Email"].Width = 215;


            //Cargar 1ra imagen o bien logo generico
            if (dgvContactos.Rows.Count > 0)
            {
                Contacto primer_Contacto = (Contacto)dgvContactos.Rows[0].DataBoundItem;
                CargarImagen(primer_Contacto.ImagenUrl);
            }
            else
            {
                CargarImagen("");
            }
          
            
        }

        /// <summary>
        /// Muestra en la grilla un mensaje de busqueda si hay una busqueda activa.
        /// </summary>
        /// <param name="v"> true, si hay una busqueda activa, false en caso de que no lo sea</param>
        public void MensajeEnGrilla(bool v)
        {
            if (v)
            {
                if(dgvContactos.Rows.Count == 0)
                {
                    lblInicio.Visible = false;
                    lblSinResultados.Visible = true;
                }
            }
            else
            {
                if (dgvContactos.Rows.Count != 0)
                {
                    lblSinResultados.Visible = false;
                    if (contactos.Count == 0)
                    {
                        lblInicio.Visible = true;
                    }
                    
                }
            }

        }


        /// <summary>
        /// Ordena los contactos alfabeticamente
        /// </summary>
        private void OrdenarLista()
        {
            contactos.Sort();
        }


        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                CargarDatos((Contacto)dgvContactos.CurrentRow.DataBoundItem);
        }

        /// <summary>
        /// Metodo llamado cada vez que se selecciona un elemento de la tabla. Por el momento, se limita a cargar una foto de perfil.
        /// </summary>
        private void CargarDatos(Contacto contacto)
        {
            CargarImagen(contacto.ImagenUrl);
        }

        /// <summary>
        /// Carga la imagen asociada al articulo segun la url enviada por parametro.. De presentarse algun error, carga un icono generico.
        /// </summary>
        private void CargarImagen(string texto_url)
        {

            try
            {
                pbFoto.Load(texto_url);
                ipbIconoGenerico.Visible = false;
                pbFoto.Visible = true;
            }
            catch (Exception ex)
            {
                pbFoto.Visible = false;
                ipbIconoGenerico.Visible = true;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarTabla();
        }

        /// <summary>
        /// Filtra tabla de contactos en funcion de la cadena ingresada. 
        /// </summary>
        private void FiltrarTabla()
        {
            if (tbBuscar.Text != "")
            {
                dgvContactos.DataSource = null;
                dgvContactos.DataSource = DevuelveListaFiltrada(tbBuscar.Text);
                MensajeEnGrilla(true);
                
            }
            else
            {
                dgvContactos.DataSource = null;
                dgvContactos.DataSource = contactos;
                MensajeEnGrilla(false);

            }
            PersonalizarTabla();
        }

        private List <Contacto> DevuelveListaFiltrada(string text)
        {
            List <Contacto> listaFiltrada = new List<Contacto> ();
            listaFiltrada = contactos.FindAll(item => item.Nombre.ToUpper().Contains(text.ToUpper()) || item.Telefono.Contains(text));
            return listaFiltrada;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvContactos.CurrentRow != null)
            {
                Contacto contacto_seleccionado = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                EliminarContacto(contacto_seleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contacto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Elimina un contacto una vez que el usuario confirma operacion.
        /// </summary>
        private void EliminarContacto(Contacto contacto)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar?", contacto.Nombre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                libreta.eliminarContacto(contacto.Id);
                MessageBox.Show("El contacto " + contacto.Nombre + " ha sido eliminado.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarContactos();
            }

        }

        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedCells.Count > 0)
                abrirFormularioEditar();
            else
                MessageBox.Show("Debe seleccionar un contacto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void abrirFormularioEditar()
        {
            if (dgvContactos.CurrentRow!=null)
            {
                Contacto contacto_seleccionado = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                formulario_padre.abrirFormularioEditar(contacto_seleccionado);
            }
            else {
                MessageBox.Show("Debe seleccionar un contacto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }
    }
    
}
