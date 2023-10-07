using System.Collections.Generic;

namespace RoleplayGame
{
    public class Bandido : Personaje
    {
        public override int VP {get; set;} = 2;
    
        public Bandido(string name) : base(name)
        {
            Health = 90;
            AddItem(new Daga());
            AddItem(new Escudo());
        }
    }
}