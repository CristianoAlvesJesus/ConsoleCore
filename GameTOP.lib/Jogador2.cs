using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando";
        }

        public string Corre()
        {
            return "Maradona estas corriendo";
        }

        public string Passe()
        {
            return "Maradona estas pasando";
        }
    }
}