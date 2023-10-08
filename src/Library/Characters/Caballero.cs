using System.Collections.Generic;
namespace RoleplayGame
{
    public class Caballero: Personaje
    {
        public Caballero (string name) : base(name)
        {
            VP = 0;
            Health = 130;
            AddItem(new Espada());
            AddItem(new Armadura());
        }
    }
}