using System;
namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //ATRIBUTOS

        private Genero Genero {get; set; }
        private string Titulo {get; set; }
        private string Descriçao {get; set; }
        private int Ano {get; set; }

        private bool Excluido {get; set; }
        //Metodos
        public Serie(int id, Genero genero, string titulo, string descriçao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descriçao = descriçao;
            this.Ano = ano;   
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descriçao: " + this.Descriçao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.id;
        }
           public bool retornaExclido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}