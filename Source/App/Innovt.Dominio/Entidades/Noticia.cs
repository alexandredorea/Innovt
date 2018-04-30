using System;

namespace Innovt.Dominio.Entidades
{
    /// <summary>
    /// Entidade que representa a Notícia
    /// </summary>
    public class Noticia
    {
        /// <summary>
        /// Get e Set do campo identidade da Notícia
        /// </summary>
        public int NoticiaId { get; set; }

        /// <summary>
        /// Get e Set do título da Notícia
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Get e Set da Chamada Social da Notícia
        /// </summary>
        public string ChamadaSocial { get; set; }

        /// <summary>
        /// Get e Set da Data e Hora da instância da criação
        /// </summary>
        public DateTime? DataCadastro { get; set; }

        /// <summary>
        /// Get e Set do Autor da Notícia
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Get e Set do Texto integral da Notícia
        /// </summary>
        public string TextoMateria { get; set; }

        /// <summary>
        /// Get e Set da Imagem associada à Notícia
        /// </summary>
        public byte[] Imagem { get; set; }

        /// <summary>
        /// Get e Set da Chave Estrangeira para o Mapa
        /// </summary>
        public int MapaId { get; set; }

        /// <summary>
        /// Get e Set do Mapa associado à Notícia
        /// </summary>
        public virtual Mapa Mapa { get; set; }
    }
}
