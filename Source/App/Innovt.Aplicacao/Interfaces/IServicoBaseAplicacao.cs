namespace Innovt.Aplicacao.Interfaces
{
    interface IServicoBaseAplicacao<TipoEndidade> where TipoEndidade : class
    {
        void Adicionar(TipoEndidade entidade);
        TipoEndidade ObterPorId(int id);
        //IEnumerable<TipoEndidade> ObterTodos();
        //void Atualizar(TipoEndidade entidade);
        //void Remover(TipoEndidade entidade);
        void Dispose();
    }
}