using System.Collections.Generic;

namespace RoleplayGame
{
    public class Bandido : Personaje
    {
        public Bandido(string name) : base(name)
        {
            VP = 2;
            Health = 90;
            AddItem(new Daga());
            AddItem(new Escudo());
        }
    }
}