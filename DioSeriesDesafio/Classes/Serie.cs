namespace DioSeriesDesafio
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero {get;set;}
        
        private string Titulo {get;set;}
        
         private string Descricao {get;set;}

         private int Ano {get;set;}

         private bool Excluido {get;set;}

         //Metodos

         public Serie(int id, Genero genero, String titulo, String descricao, int ano)
         {
             this.Id = id;
             this.Genero = genero;
             this.Titulo = titulo;
             this.Descricao = descricao;
             this.Ano = ano;
             this.Excluido = false;
         }

         public override string ToString()
         {
             String retorno ="";
             retorno += "Gênero: " + this.Genero + Environment.NewLine;
             retorno += "Titulo: " + this.Titulo + Environment.NewLine;
             retorno += "Descricão: " + this.Descricao + Environment.NewLine;
             retorno += "Ano de Inicio: " + this.Ano;
             retorno += "Excluido: " + this.Excluido;
             return retorno;

         } 

         public string retornaTitulo()
         {
             return this.Titulo;
         }

         internal int retornaId()
         {
            return this.Id;
         }

         internal bool retornaExcluido()
         {
            return this.Excluido;
         }

         public void Excluir()
         {
             this.Excluido = true;
         }
    }
}