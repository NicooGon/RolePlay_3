using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
namespace RoleplayGame;

    public class Hobbit : Personaje
    {
        public override int VP {get; set;} = 3;
        public Hobbit (string name) : base (name)
        {
            Health = 110;
            AddItem(new Anillo());
            AddItem(new Dardo());
        }
    }