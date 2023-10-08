using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RoleplayGame
{
    public abstract class Personaje : ICharacter
    {
        public List<IItem> items = new List<IItem>();

        public string Name { get; set; }

        private int _health;
        public virtual int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        private int _vp;
        public virtual int VP
        {
            get { return _vp; }
            set { _vp = value; }
        }

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
                    if (item is IMagicalAttackItem magicalAttackItem)
                    {
                        value += magicalAttackItem.AttackValue;
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

    public virtual void ReceiveAttack(int power)
    {
        int damage = Math.Max(0, power - DefenseValue);

        if (damage > 0)
        {
            Health = Health - damage;
            Console.WriteLine($"{Name} received {damage} damage. New health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Name} defended the attack. Health unchanged: {Health}");
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