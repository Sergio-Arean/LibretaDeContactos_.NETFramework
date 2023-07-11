using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contacto : IComparable<Contacto>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string ImagenUrl { get; set; }

        public int CompareTo(Contacto other)
        {
            if(other is Contacto)
            {
                return string.Compare(this.Nombre, other.Nombre);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
