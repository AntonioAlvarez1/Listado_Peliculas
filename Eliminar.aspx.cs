using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Newtonsoft.Json;

namespace examen_parcial2
{
    public partial class Eliminar : System.Web.UI.Page
    {
        static List<Pelicula> peliculatemp = new List<Pelicula>();
        static string titulo;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Peliculas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            titulo = TextBoxPelicual.Text;
            bool encontrado = false;
            foreach (var u in peliculatemp)
            {

                if (u.Titulo == titulo)
                {

                    Response.Write("<script>alert('Pelicula encontrada')</script>");

                }
                if (!encontrado)
                {
                    Response.Write("<script>alert('No se encontro')</script>");
                    titulo = "";
                    

                }


            }
        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(peliculatemp);
            string archivo = Server.MapPath("Peliculas.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void TextBoxEstudio_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {

            Pelicula borrar = peliculatemp.Find(c => c.Titulo == titulo);
                if (borrar != null)
                {
                peliculatemp.Remove(borrar);

                }
            
            GuardarJason();
        }
    }
}