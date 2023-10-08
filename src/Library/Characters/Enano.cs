using System.Collections.Generic;
namespace RoleplayGame
{

    public class Enano: Personaje
    {
        public Enano (string name) : base(name)
        {
            VP = 0;
            Health = 150;
            AddItem(new Hacha());
            AddItem(new Escudo());
        }
    }
}
       
        