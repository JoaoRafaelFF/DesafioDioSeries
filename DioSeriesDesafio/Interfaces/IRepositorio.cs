using System.Collections.Generic;

namespace DioSeriesDesafio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetonaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}