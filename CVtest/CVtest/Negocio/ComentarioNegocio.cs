using accesoaDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ComentarioNegocio
    {
        private ComentariosDatos comentantarios = new ComentariosDatos();
        public object ComentariosDatos;



        public bool GuardarComentario(Comentario comentario)
        {
            bool resultado = false;

            if (string.IsNullOrWhiteSpace(comentario.Nombre)== false &&
                string.IsNullOrWhiteSpace(comentario.Texto) ==false)
            {
                comentariosDatos.AgregarComentario(comentario);
                    resultado = true;
            }
            return resultado;
        }

        public List<Comentario>ObtenerComentarios()
        {
            return comentariosDatos.ObtenerComentarios();
        }

        public object ComentariosDatos()
        {
            throw new NotImplementedException();
        }
    }
}
