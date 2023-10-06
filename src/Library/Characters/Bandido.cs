using System.Collections.Generic;

namespace RoleplayGame
{
    public class Bandido : Personaje
    {
        public override int Health
        {
            get { return 90; }
            set
        {
        }
        }
        public override int VP {get; set;} = 2;
    
        public Bandido(string name) : base(name)
        {
            AddItem(new Daga());
            AddItem(new Escudo());
        }
    }
}