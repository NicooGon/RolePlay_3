using System.Collections.Generic;
namespace RoleplayGame;

    public class Orco: Personaje
    {
        public override int VP {get; set;} = 4; 
        public Orco (string name) : base(name)
        {
            Health = 120;
            AddItem(new Garrote());
            AddItem(new Casco());
        }
    }
    
            
        
       
       