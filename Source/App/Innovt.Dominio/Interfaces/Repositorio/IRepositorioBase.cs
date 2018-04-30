using System.Collections.Generic;

namespace Innovt.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<TipoEntidade> where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        TipoEntidade ObterPorId(int id);
        IEnumerable<TipoEntidade> ObterTodos();
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        void Dispose();
    }
}
