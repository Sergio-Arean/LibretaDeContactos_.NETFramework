using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace AccesoDatos
{
    public class ContactoDatos
    {


        public List<Contacto> listar()
        {
            List<Contacto> lista = new List<Contacto>();
            ConexionBBDD conexion_bbdd = new ConexionBBDD();

            using (SqlConnection conexion = conexion_bbdd.getConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Listar", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contacto contacto = new Contacto();
                        contacto.Id = (int)reader["id"];
                        contacto.Nombre = (string)reader["nombre"];
                        contacto.Telefono = (string)reader["telefono"];
                        contacto.Email = (string)reader["email"];
                        contacto.ImagenUrl = (string)reader["imagenurl"];

                        lista.Add(contacto);
                    }

                }
            }
            return lista;
        }



        public Contacto get(int id)
        {
            Contacto contacto = new Contacto();
            ConexionBBDD conexion_bbdd = new ConexionBBDD();

            using (SqlConnection conexion = conexion_bbdd.getConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Get", conexion);
                comando.Parameters.AddWithValue("id", id);
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacto.Id = (int)reader["id"];
                        contacto.Nombre = (string)reader["nombre"];
                        contacto.Telefono = (string)reader["telefono"];
                        contacto.Email = (string)reader["email"];
                        contacto.ImagenUrl = (string)reader["imagenurl"];

                    }

                }
            }
            return contacto;
        }

        public bool agregar(Contacto contacto)
        {
            bool rta = false;

            if (contacto != null)
            {
                try
                {
                    ConexionBBDD conexion_bbdd = new ConexionBBDD();
                    using (SqlConnection conexion = conexion_bbdd.getConexion())
                    {
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("Agregar", conexion);
                        comando.Parameters.AddWithValue("nombre", contacto.Nombre);
                        comando.Parameters.AddWithValue("telefono", contacto.Telefono);
                        comando.Parameters.AddWithValue("email", contacto.Email);
                        comando.Parameters.AddWithValue("imagenurl", contacto.ImagenUrl);
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.ExecuteNonQuery();
                    }
                    rta = true;
                }
                catch (Exception e)
                {
                    string error = e.Message;
                }

            }

            return rta;
        }


        public bool modificar(Contacto contacto)
        {
            bool rta = false;
            try
            {
                ConexionBBDD conexion_bbdd = new ConexionBBDD();
                using (SqlConnection conexion = conexion_bbdd.getConexion())
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("Modificar", conexion);
                    comando.Parameters.AddWithValue("id", contacto.Id);
                    comando.Parameters.AddWithValue("nombre", contacto.Nombre);
                    comando.Parameters.AddWithValue("telefono", contacto.Telefono);
                    comando.Parameters.AddWithValue("email", contacto.Email);
                    comando.Parameters.AddWithValue("imagenurl", contacto.ImagenUrl);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.ExecuteNonQuery();
                }
                rta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
            }

            return rta;
        }

        public bool Eliminar(int id)
        {
            bool rta = false;
            try
            {
                ConexionBBDD conexion_bbdd = new ConexionBBDD();
                using (SqlConnection conexion = conexion_bbdd.getConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("Eliminar", conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
                rta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
            }

            return rta;
        }






    }
}
