using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComentarioNegocio
    {
        private ComentantariosDatos comentantarios = new ComentantariosDatos();

        public bool GuardarComentario(Comentario comentario)
        {
            bool resultado = false;

            if (comentario.Nombre!=""&& comentario.Texto !="")
            {
                ComentantariosDatos.AgregarComentario(comentario);
                    resultado = true;
            }
            return resultado;
        }
    }
}
