using System.Collections.Generic;

namespace RoleplayGame
{
    public class Araña : Personaje
    {
        public Araña (string name) : base(name)
        {
            VP = 3;
            Health = 70;
            AddItem(new Telaraña());
            AddItem(new Picadura());
        }
    }
}