using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1: IJogador
    {
        
         public readonly string Nome ;

         public Jogador1(string _nome ="Ronaldo")
         {
             this.Nome = _nome;
         }

        public string Chuta() 
        { 
            return $"{Nome} esta chutando . \n";
         }
        public string Corre() 
        { 
            return $"{Nome} esta correndo. \n";
         }
        public string Passe() 
        {  
            return $"{Nome} esta passando. \n";
        }
    }
}