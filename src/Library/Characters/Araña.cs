using System.Collections.Generic;

namespace RoleplayGame
{
    public class Araña : Personaje, Enemigo
    {
        public override int Health
        {
            get { return 70; }
            set
        {
        }
        }
        public int VP {get; set;} = 100;
        public Araña(string name) : base(name)
        {
            AddItem(new Telaraña());
            AddItem(new Picadura());
        }
    }
}