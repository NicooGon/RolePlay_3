using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{
    public abstract class Personaje : ICharacter
    {
        private List<IItem> items = new List<IItem>();

        public string Name { get; set; }

        public abstract int Health { get; set; }

        public abstract int VP { get; set; } 

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in items)
                {
                    if (item is IAttackItem attackItem)
                    {
                        value += attackItem.AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in items)
                {
                    if (item is IDefenseItem defenseItem)
                    {
                        value += defenseItem.DefenseValue;
                    }
                }
                return value;
            }
        }
        protected Personaje(string name)
        {
            Name = name;
        }

        public void ReceiveAttack(int power)
        {
            int damage = power - DefenseValue;
            if (damage > 0)
            {
                Health -= damage;
            }
        }

        public void Cure()
        {
            Health = 80;
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
       
    }
}