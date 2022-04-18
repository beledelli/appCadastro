using System;
using Series.Interfaces;
using Series.Collections.Generic;

namespace Serie
{
    public class SerieRepositorio : irepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }
        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }
        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }
        public int ProximoId()
        {
            throw new NotImplementedException();
        }
        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

