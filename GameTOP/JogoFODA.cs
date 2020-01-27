using GameTOP.Interface;
using GameTOP.lib;

namespace GameTOP
{
    public class JogoFODA
    {
         public readonly IJogador _jogadorA;
          public readonly IJogador _jogadorB;
        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Passe());
            System.Console.Write(_jogadorA.Chuta());

            System.Console.Write("\n Proximo Jogador \n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Passe());
            System.Console.Write(_jogadorB.Chuta());
        }        
    }
}