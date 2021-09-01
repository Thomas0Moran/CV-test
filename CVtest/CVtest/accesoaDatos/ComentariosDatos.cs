using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoaDatos
{
    public class ComentariosDatos
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-L0FHG61;Database=MiSitioPersonal;Trusted_Connection=True;");

        public ComentariosDatos()
        {
            //comentarios = new List<Comentario>();
        }

        public void AgregarComentario (Comentario comentario)
        {
            //comentarios.Add(comentario);
        }

        public List<Comentario> ObtenerComentarios()
        {
            string consulta = @"SELECT Id, Nombre,Texto FROM Comentarios";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            conexion.Close();
        }

    }
}
