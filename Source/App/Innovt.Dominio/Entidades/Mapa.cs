using System.Collections.Generic;

namespace Innovt.Dominio.Entidades
{
    /// <summary>
    /// Entidade que representa o Mapa
    /// </summary>
    public class Mapa
    {
        /// <summary>
        /// Método construtor
        /// </summary>
        public Mapa()
        {
            Noticias = new HashSet<Noticia>();
        }

        /// <summary>
        /// Get e Set do campo identidade do mapa
        /// </summary>
        public int MapaId { get; set; }

        /// <summary>
        /// Get e Set da Latitude para a coordenada geográfica do mapa
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Get e Set da Longetudade para a coordenada geográfica do mapa
        /// </summary>
        public string Longetude { get; set; }

        /// <summary>
        /// Get e Set da Lista de Notícias localizados naquele mapa
        /// </summary>
        public IEnumerable<Noticia> Noticias { get; set; }
    }
}
