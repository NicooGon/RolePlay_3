using System.Collections.Generic;
namespace RoleplayGame
{
    public class Caballero: Personaje
    {
        public override int Health 
        {
            get {return 130;}
            set
        { 
        }
        }
        public override int VP {get; set;} = 0;
        public Caballero (string name) : base(name)
        {
            AddItem(new Espada());
            AddItem(new Armadura());
        }
    }
}