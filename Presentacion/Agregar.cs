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
    public partial class Agregar : Form
    {
        private LibretaDeContactos libreta;
        private Principal formulario_padre;
        private Contacto amodificar;
        public Agregar(LibretaDeContactos libreta, Principal formulario_padre)
        {
            this.libreta = libreta;
            this.formulario_padre = formulario_padre;
            InitializeComponent();
            SetearBotones(true);
            groupBoxContacto.Text = "Nuevo Contacto";
        }

        public Agregar(LibretaDeContactos libreta, Principal formulario_padre,Contacto amodificar)
        {
            this.libreta = libreta;
            this.formulario_padre = formulario_padre;
            InitializeComponent();

            this.amodificar = amodificar;
            CargarCampos();
            SetearBotones(false);
            groupBoxContacto.Text = "Editar Contacto";
        }


        /// <summary>
        /// Setea el texto y la funcionalidad de los botones a mostrar dependiendo si se trata de agregar o modificar un contacto.
        /// </summary>
        private void SetearBotones(bool v)
        {
            if (v)
            {
                btnCancelar.Text = "Limpiar";
                btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            }
            else
            {
                btnCancelar.Text = "Cancelar";
                btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            }
        }


        /// <summary>
        /// Cargar campos con la informacion del contacto que quiera modificarse.
        /// </summary>
        private void CargarCampos()
        {
            tbNombre.Text = amodificar.Nombre;
            tbTelefono.Text = amodificar.Telefono;
            tbEmail.Text = amodificar.Email;
            tbFoto.Text = amodificar.ImagenUrl;
            CargarImagen(amodificar.ImagenUrl);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ElegirImagen();
        }

        /// <summary>
        /// Abre explorador de archivos para elegir foto de perfil
        /// </summary>
        private void ElegirImagen()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                CargarImagen(archivo.FileName);

                tbFoto.Text = archivo.FileName;

            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (amodificar == null)
            {
                LimpiarCampos();
            }
            else
            {
                formulario_padre.abrirFormularioContactos();
            }
            
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbTelefono.Text = "";
            tbEmail.Text = "";
            tbFoto.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AgregarModificarContacto();
            
        }


        /// <summary>
        /// Agrega o modifica un contacto, segun el contexto en que el metodo es llamado.
        /// </summary>
        private void AgregarModificarContacto()
        {
            try
            {
                Contacto contacto = new Contacto();
                contacto.Nombre = tbNombre.Text;
                contacto.Telefono = tbTelefono.Text;
                contacto.Email = tbEmail.Text;
                contacto.ImagenUrl = tbFoto.Text;

                if (amodificar == null) //Agregando Contacto
                {
                    libreta.agregarContacto(contacto);
                    MessageBox.Show("El contacto ha sido agregado exitosamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //Modificando contacto
                {
                    contacto.Id = amodificar.Id;
                    libreta.modificarContacto(contacto);
                    MessageBox.Show("El contacto ha sido modificado exitosamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
                formulario_padre.abrirFormularioContactos();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
