using System.Collections.Generic;

namespace RoleplayGame
{
    public class Araña : Personaje
    {
        public override int Health
        {
            get { return 70; }
            set
        {
        }
        }
        public override int VP {get; set;} = 3;
        public Araña (string name) : base(name)
        {
            AddItem(new Telaraña());
            AddItem(new Picadura());
        }
    }
}