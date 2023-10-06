using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
namespace RoleplayGame;

    public class Hobbit : Personaje, Enemigo
    {
        public override int Health 
        {
            get { return 110; }
            set 
            {
            }
        }
        public int VP {get; set;} = 100;
        public Hobbit (string name) : base (name)
        {
            AddItem(new Anillo());
            AddItem(new Dardo());
        }
    }