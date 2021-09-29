using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;
        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Texto 1",
                Autor = "João Carlos",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            });
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Texto 2",
                Autor = "Carlos",
                Data = DateTime.Today.AddDays(-2),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Texto 3",
                Autor = "Marcos",
                Data = DateTime.Today.AddDays(-5),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Texto 4",
                Autor = "Eustacio",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Texto 5",
                Autor = "Cleiton",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            });
        }
    }
}