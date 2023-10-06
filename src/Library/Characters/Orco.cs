using System.Collections.Generic;
namespace RoleplayGame;

    public class Orco: Personaje, Enemigo
    {
        public override int Health 
        {
            get {return 120;}
            set
            {
            }
            } 
        public int VP {get; set;} = 100;  
        public Orco (string name) : base(name)
        {
            AddItem(new Garrote());
            AddItem(new Casco());
        }
    }
    
            
        
       
       