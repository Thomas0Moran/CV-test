using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ComentariosDatos
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-95LI9O3;Database=MiSitioPersonal;Trusted_Connection=True;");
        public ComentariosDatos()
        {
            //comentarios = new List<Comentario>();
        }

        public bool AgregarComentario(Comentario comentario)
        {
            string consulta = $@"INSERT INTO Comentarios (Nombre,Texto) VALUES('{comentario.Nombre}','{comentario.Texto}')";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            if (resultado ==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Comentario> ObtenerComentarios()
        {
            List<Comentario> resultado = new List<Comentario>();

            string consulta = @"SELECT Id,Nombre,Texto 
                                FROM ComenTarios";


            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Comentario comentario = new Comentario()
                {
                    Nombre = reader.GetString(1),
                    Texto = reader["Texto"].ToString()
                };

                resultado.Add(comentario);

            }

            conexion.Close();

            return resultado;
        }

    }
}