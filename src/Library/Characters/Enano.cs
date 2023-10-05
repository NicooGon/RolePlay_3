using System.Collections.Generic;
namespace RoleplayGame
{

    public class Enano: Personaje
    {
        public override int Health 
        {
            get {return 150;}
            set
            {
            }
            }   
                public Enano (string name) : base(name)
                {
                    AddItem(new Hacha());
                    AddItem(new Escudo());
                }
            }
        }
       
        