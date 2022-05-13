using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace examen_parcial2
{
    public partial class _Default : Page
    {
        static List<Actores> actoresTemp = new List<Actores>();
        static List<Pelicula> PeliculaTemp = new List<Pelicula>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregaActor_Click(object sender, EventArgs e)
        {
            Actores Actorestemp = new Actores();
            Actorestemp.Nombre=TextBoxActor.Text;
            Actorestemp.FechaN=Convert.ToInt16(TextboxFechaActor.Text);
            actoresTemp.Add(Actorestemp);
            GridView1.DataSource = actoresTemp;
            GridView1.DataBind();
        }
        private void GuardarJason()
        {
            string json = JsonConvert.SerializeObject(PeliculaTemp);
            string archivo = Server.MapPath("Peliculas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Pelicula peliculatemp = new Pelicula();
            peliculatemp.Titulo = TextBoxTitulo.Text;
            peliculatemp.FechaL=Convert.ToInt32(TextBoxLanzamiento.Text);
            peliculatemp.Genero = TextboxGenero.Text;
            peliculatemp.Elencos = actoresTemp.ToArray().ToList();
            PeliculaTemp.Add(peliculatemp);
            
            GuardarJason();
        }
    }
}