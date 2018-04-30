using Innovt.Aplicacao.Interfaces;
using System;

namespace Innovt.Aplicacao.Servicos
{
    class ServicoBaseAplicacao<TipoEndidade> : IDisposable, IServicoBaseAplicacao<TipoEndidade> where TipoEndidade : class
    {
        private readonly IServicoBaseAplicacao<TipoEndidade> _servicoBase;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="entidade">Instância da entidade</param>
        public ServicoBaseAplicacao(IServicoBaseAplicacao<TipoEndidade> entidade)
        {
            _servicoBase = entidade;
        }

        /// <summary>
        /// Adicionar a entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Adicionar(TipoEndidade endidade)
        {
            _servicoBase.Adicionar(endidade);
        }

        /// <summary>
        /// Obtem uma entidade especifica
        /// </summary>
        /// <param name="id">Identificado da entidade</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEndidade ObterPorId(int id)
        {
            return _servicoBase.ObterPorId(id);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _servicoBase.Dispose();
        }
    }
}