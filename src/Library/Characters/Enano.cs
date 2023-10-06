using System.Collections.Generic;
namespace RoleplayGame
{

    public class Enano: Personaje
    {
        public override int Health {get; set;} = 150;
        public override int VP {get; set;} = 0;  
        public Enano (string name) : base(name)
        {
            AddItem(new Hacha());
            AddItem(new Escudo());
        }
    }
}
       
        