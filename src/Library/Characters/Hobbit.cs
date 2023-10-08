using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
namespace RoleplayGame;

    public class Hobbit : Personaje
    {
        public Hobbit (string name) : base (name)
        {
            VP = 3;
            Health = 110;
            AddItem(new Anillo());
            AddItem(new Dardo());
        }
    }