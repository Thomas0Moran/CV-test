using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoaDatos
{
    public class ComentariosDatos
    {
        public List<Comentario> comentarios;

        public ComentariosDatos()
        {
            comentarios = new List<Comentario>();
        }

        public void AgregaComentario(Comentario comentario)
        {
            comentarios.Add(comentario);
        }

        public List<Comentario> ObtenerComentarios()
        {
            return comentarios;
        }

    }
}
