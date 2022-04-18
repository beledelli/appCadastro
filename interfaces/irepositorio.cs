using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface irepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entedidade);
        void Exlui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}