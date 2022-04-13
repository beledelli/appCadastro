using System;

namespace Series
{
    public class Serie : entidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; } 
        private string Descricao { get; set; }
        private int Ano { get; set; }
        

        //Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;  
            this.Descricao = descricao; 
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.Newline;
            retorno += "Título: " + this.Titulo + Environment.Newline;
            retorno += "Descrição: " + this.Descricao + Environment.Newline;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

    }
}