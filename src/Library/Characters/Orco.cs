using System.Collections.Generic;
namespace RoleplayGame;

    public class Orco: Personaje
    {
        public override int Health 
        {
            get {return 120;}
            set
            {
            }
            } 
        public override int VP {get; set;} = 4; 
        public Orco (string name) : base(name)
        {
            AddItem(new Garrote());
            AddItem(new Casco());
        }
    }
    
            
        
       
       