using System.Collections.Generic;
namespace RoleplayGame;

    public class Orco: Personaje
    {
        public Orco (string name) : base(name)
        {
            VP = 4;
            Health = 120;
            AddItem(new Garrote());
            AddItem(new Casco());
        }
    }
    
            
        
       
       