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
                    Link = "https://estebanbv0.github.io/Barberia/index.html/"
                    },
                    new Proyecto
                    {
                    Titulo = "Taller Mecanico Confiable",
                    Descripcion = "Taller mecanico con todos los servicios para tu automovil (API Restfull)",
                    ImagenUrl = "/imagenes/Mecanico.png",
                    Link = "https://github.com/EstebanBV0/TallerMecanicoConfiable"
                    },
                    new Proyecto
                    {
                    Titulo = "Hospitalización en casa",
                    Descripcion = "API Hospitalización en casa",
                    ImagenUrl = "/imagenes/HospiEnCasa.png",
                    Link = "https://github.com/EstebanBV0?tab=repositories"
                    }
            };
        }

    }
}
    

