using Innovt.Dominio.Interfaces.Repositorio;
using Innovt.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace Innovt.Dominio.Servicos
{
    public class ServicoBase<TipoEndidade> : IDisposable, IServicoBase<TipoEndidade> where TipoEndidade : class
    {
        private readonly IRepositorioBase<TipoEndidade> _repositorio;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="entidade">Instância da entidade</param>
        public ServicoBase(IRepositorioBase<TipoEndidade> entidade)
        {
            _repositorio = entidade;
        }

        /// <summary>
        /// Adicionar a entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Adicionar(TipoEndidade endidade)
        {
            _repositorio.Adicionar(endidade);
        }

        /// <summary>
        /// Atualizar a informação da entidade em questão no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade preenchida</param>
        public void Atualizar(TipoEndidade entidade)
        {
            _repositorio.Atualizar(entidade);
        }

        /// <summary>
        /// Obtem uma entidade especifica
        /// </summary>
        /// <param name="id">Identificado da entidade</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEndidade ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        /// <summary>
        /// Obtem todas as entidades no banco de dados
        /// </summary>
        /// <returns>Entidade preenchida</returns>
        public IEnumerable<TipoEndidade> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        /// <summary>
        /// Remove a informação especifica no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade a ser removida</param>
        public void Remover(TipoEndidade entidade)
        {
            _repositorio.Remover(entidade);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}
