using Portafolio.Models;

namespace Portafolio.Servicios


{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyecto()
        {

            return new List<Proyecto>() {
                    new Proyecto
                    { 
                    Titulo = "Juego encriptador",
                    Descripcion = "Puedes encriptar y desencriptar mensajes!",
                    ImagenUrl = "/imagenes/Muneco.jpg",
                    Link = "https://estebanbv0.github.io/Encriptador/"

                },
                    new Proyecto
                    {
                    Titulo = "Barberia",
                    Descripcion = "Visita nuestra barberia y conoce nuestros fabulosos servicios!",
                    ImagenUrl = "/imagenes/barbar.jpg",
                    Link = "https://estebanbv0.github.io/Encriptador/"
                    },
                    new Proyecto
                    {
                    Titulo = "Hospitalización en casa",
                    Descripcion = "Visita nuestra barberia y conoce nuestros fabulosos servicios!",
                    ImagenUrl = "/imagenes/diferenciales.jpg",
                    Link = "https://estebanbv0.github.io/Encriptador/"
                    }
            };
        }

    }
}
    

