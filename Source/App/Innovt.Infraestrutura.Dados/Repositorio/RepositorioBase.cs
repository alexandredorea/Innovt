using Innovt.Dominio.Interfaces.Repositorio;
using Innovt.Infraestrutura.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Innovt.Infraestrutura.Dados.Repositorio
{
    /// <summary>
    /// Repositório Básico de um CRUD
    /// </summary>
    /// <typeparam name="TipoEntidade">Tipo de Entidade a ser trabalhada</typeparam>
    public class RepositorioBase<TipoEntidade> : IDisposable, IRepositorioBase<TipoEntidade> where TipoEntidade : class
    {
        private readonly ContextoBanco _contexto;
        private DbSet<TipoEntidade> _entidade;
        string errorMessage = string.Empty;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="contextoBanco">Contexto do Banco de Dados</param>
        public RepositorioBase(ContextoBanco contextoBanco)
        {
            _contexto = contextoBanco;
            _entidade = contextoBanco.Set<TipoEntidade>();
        }

        /// <summary>
        /// Adicionar a entidade no banco de dados
        /// </summary>
        /// <param name="objeto">Entidade preenchida</param>
        public void Adicionar(TipoEntidade objeto)
        {

            if (objeto == null)
            {
                throw new ArgumentNullException("entity");
            }
            //_contexto.Set<TipoEntidade>().Add(entidade);
            _entidade.Add(objeto);
            _contexto.SaveChanges();

        }

        /// <summary>
        /// Atualizar a informação da entidade em questão no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade preenchida</param>
        public void Atualizar(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entity");
            }
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Obtem uma entidade especifica
        /// </summary>
        /// <param name="id">Identificado da entidade</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEntidade ObterPorId(int id)
        {
            //return _contexto.Set<TipoEntidade>().Find(id);
            return _entidade.Find(id);
        }

        /// <summary>
        /// Obtem todas as entidades no banco de dados
        /// </summary>
        /// <returns>Entidade preenchida</returns>
        public IEnumerable<TipoEntidade> ObterTodos()
        {
            //return _contexto.Set<TipoEntidade>().AsEnumerable(); 
            //return _entidade.ToList(); 
            //return _contexto.Set<TipoEntidade>().ToList(); 
            return _entidade.AsEnumerable();
        }

        /// <summary>
        /// Remove a informação especifica no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade a ser removida</param>
        public void Remover(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entity");
            }
            //_contexto.Set<TipoEntidade>().Remove(entidade);
            _entidade.Remove(entidade);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Liberar a memória
        /// </summary>
        public void Dispose()
        {
            _entidade = null;
            if (_contexto != null)
                _contexto.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
