using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "teste chuta";
        }

        public string Corre()
        {
             return "teste Corre";
        }

        public string Passe()
        {
             return "teste passe";
        }
    }
}