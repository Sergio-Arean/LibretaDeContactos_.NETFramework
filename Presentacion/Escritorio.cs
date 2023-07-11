using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelo;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class Principal : Form
    {
        private Form formulario_vigente = null;
        private int posY = 0;
        private int posX = 0;
        private LibretaDeContactos libreta;
        
        public Principal()
        {
            InitializeComponent();
            libreta = new LibretaDeContactos();
            abrirFormularioContactos();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
           // abrirFormularioContactos();
        }
        private void abrirFormularioAgregar()
        {
            CambiarColorMenuItem(iconMenuItemAgregar);
            abrirFormularioContent(new Agregar(libreta,this));
        }

        /// <summary>
        /// Modifica el color del menu item seleccionado por el usuario.
        /// </summary>
        private void CambiarColorMenuItem(IconMenuItem iconMenu)
        {
            ReestablecerColorMenuItems();
            iconMenu.BackColor = System.Drawing.Color.LightSteelBlue;
        }

        private void ReestablecerColorMenuItems()
        {
            iconMenuItemContactos.BackColor = System.Drawing.Color.YellowGreen;
            iconMenuItemAgregar.BackColor = System.Drawing.Color.YellowGreen;
        }

        public void abrirFormularioContactos()
        {
            CambiarColorMenuItem(iconMenuItemContactos);
            Contactos contactos = new Contactos(libreta, this);
            contactos.MensajeEnGrilla(false);
            abrirFormularioContent(contactos);     
        }

        public void abrirFormularioEditar(Contacto amodificar)
        {
            abrirFormularioContent(new Agregar(libreta, this,amodificar));
        }

        private void abrirFormularioContent(Form formulario_a_abrir)
        {
            if (formulario_vigente != null)
                formulario_vigente.Close(); 

            formulario_vigente = formulario_a_abrir;
            formulario_a_abrir.TopLevel = false;
            formulario_a_abrir.FormBorderStyle = FormBorderStyle.None;
            formulario_a_abrir.Dock = DockStyle.Fill;
            content.Controls.Add(formulario_a_abrir);
            content.Tag = formulario_a_abrir;
            formulario_a_abrir.BringToFront();
            formulario_a_abrir.Show();


        }

        private void menuStripPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }

        }

        private void iconMenuItemSalir_Click(object sender, EventArgs e)
        {
            CerrarConValidacion();
        }

        /// <summary>
        /// Cierra el formulario si el usuario asi lo confirma.
        /// </summary>
        private void CerrarConValidacion()
        {
            DialogResult rta = MessageBox.Show("¿Cerrar Aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            {
                Close();
            }

        }

        private void iconMenuItemAgregar_Click(object sender, EventArgs e)
        {
            abrirFormularioAgregar();

            
        }

        private void iconMenuItemContactos_Click(object sender, EventArgs e)
        {
            abrirFormularioContactos();
        }

        private void iconMenuItemSalir_MouseEnter(object sender, EventArgs e)
        {
            iconMenuItemSalir.IconColor = System.Drawing.Color.Crimson;

        }

        private void iconMenuItemSalir_MouseLeave(object sender, EventArgs e)
        {
            iconMenuItemSalir.IconColor = System.Drawing.Color.Black;
         
        }


    }
}
