using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


namespace CVtest.MasInformación
{
    public partial class QuienSoy : System.Web.UI.Page
    {
        private static ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        public QuienSoy()
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();
            lstComentarios.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var comentario = txtComentario.Text;

            Comentario nuevoComentario = new Comentario()
            {
                Nombre = nombre,
                Texto = comentario
            };

            bool resultado = comentarioNegocio.GuardarComentario(nuevoComentario);

            txtComentario.Text = "";
            txtNombre.Text = "";

            lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();
            lstComentarios.DataBind();
        }
    }
}