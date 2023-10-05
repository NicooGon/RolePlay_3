using System.Collections.Generic;

namespace RoleplayGame
{
    public class Bandido : Personaje, Enemigo
    {
        public override int Health
        {
            get { return 90; }
            set
        {
        }
        }

        public Bandido(string name) : base(name)
        {
            AddItem(new Daga());
            AddItem(new Escudo());
        }
    }
}