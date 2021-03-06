using System.Collections.Generic;

namespace dio.desafio.rep.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclue(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}