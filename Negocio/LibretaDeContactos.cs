using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Negocio
{
    public class LibretaDeContactos
    {
        private ContactoDatos contacto_datos;
        private List<Contacto> contactos;

        public LibretaDeContactos()
        {
            contacto_datos = new ContactoDatos();
            contactos = new List<Contacto>();
        }
        public List<Contacto> listarContactos()
        {
            contactos = contacto_datos.listar();
            return contactos;
        }

        public Contacto getContacto(int id)
        {
            return contacto_datos.get(id);
        }

        public bool eliminarContacto(int id)
        {
            return contacto_datos.Eliminar(id);
        }


        public bool agregarContacto(Contacto contacto)
        {
            if (ContactoValido(contacto) && !ContactoRepetido(contacto))
            {
                contacto_datos.agregar(contacto);
            }
            return true;
        }

        public bool modificarContacto (Contacto contacto) 
        {
            if (ContactoValido(contacto))
            {
                contacto_datos.modificar(contacto);
            }
            return true;
        }
        /// <summary>
        /// Permite validar que los campos correspondientes al contacto enviado por parametro.
        /// </summary>
        public bool ContactoValido(Contacto contacto)
        {
            if (!nombreValido(contacto.Nombre))
            {
                throw new CampoInvalidoException("Debe completar el campo nombre!");
            }
            if (!telefonoValido(contacto.Telefono))
            {
                throw new CampoInvalidoException("El campo teléfono solo debe incluir números!");
            }
            if (!emailValido(contacto.Email))
            {
                throw new CampoInvalidoException("El email ingresado no es válido!");
            }
            return true;
        }

        
        

        /// <summary>
        /// Permite determinar si un contacto se encuentra repetido, por concidencia de nombre y/o telefono.
        /// </summary>
        private bool ContactoRepetido(Contacto contacto)
        {
            for(int i=0; i<contactos.Count; i++)
            {
                if (contactos[0].Nombre.ToUpper().Equals(contacto.Nombre.ToUpper())){
                    throw new CampoInvalidoException("El nombre que desea ingresar pertenece a otro contacto!");
                }
                if (contactos[0].Telefono.Equals(contacto.Telefono)){
                    throw new CampoInvalidoException("El teléfono que desea ingresar pertenece a otro contacto!");
                }
            }
            return false;
        }

        private bool nombreValido(string nombre)
        {
            return CampoCompleto(nombre);
        }

        private bool CampoCompleto(string campo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new CampoInvalidoException("Debe completar todos los campos!");
            }
            return true;
        }

        private bool telefonoValido(string telefono)
        {
            bool rta = CampoCompleto(telefono);
            if (rta)
            {
                for (int i = 0; i < telefono.Length && rta; i++)
                {
                    if (!char.IsDigit(telefono[i]))
                        rta = false;
                }
            }
            return rta;
        }


        private bool emailValido(string email)
        {
            bool email_valido = true;
            int cantidad_arrobas = 0;
            if (CampoCompleto(email))
            {
                for (int i = 0; i < email.Length && email_valido; i++)
                {
                    if (email[i] == '@')
                    {
                        cantidad_arrobas++;
                        if (cantidad_arrobas > 1)
                        {
                            email_valido = false;
                        }

                    }
                }
                if (cantidad_arrobas < 1)
                {
                    email_valido = false;
                }

            }

            return email_valido;
        }


    }
}
