using System.Collections.Generic;
namespace RoleplayGame
{

    public class Enano: Personaje
    {
        public override int VP {get; set;} = 0;  
        public Enano (string name) : base(name)
        {
            Health = 150;
            AddItem(new Hacha());
            AddItem(new Escudo());
        }
    }
}
       
        