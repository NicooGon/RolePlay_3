using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;

namespace RoleplayGame
{
    public class Mago : Personaje
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public override int VP {get; set;} = 0;
        public Mago(string name) : base(name)
        {
            Health = 85;
            ISpell spell = new HechizoUno();
            LibroMagico libroMagico = new LibroMagico();
            libroMagico.AddSpell(spell);

            AddItem(new Staff());
            AddItem(libroMagico);
        }
        public void AddItem(IItem item) 
        {
            base.AddItem(item);

            if (item is IMagicalItem magicalItem)
            {
                magicalItems.Add(magicalItem);
            }
        }
        public void RemoveItem(IItem item)
        {
            base.RemoveItem(item);

            if (item is IMagicalItem magicalItem)
            {
                magicalItems.Remove(magicalItem);
            }
        }

        public int GetTotalSpellDamage()
        {
            int spellDamage = 0;
            foreach (IMagicalItem item in magicalItems)
            {
                if (item is IMagicalAttackItem magicalAttackItem)
                {
                    spellDamage += magicalAttackItem.AttackValue;
                }
            }
            return spellDamage;
        }

        public int GetTotalDamage()
        {
            int totalDamage = 0;

            foreach (IMagicalItem item in magicalItems)
            {
                if (item is IMagicalAttackItem magicalAttackItem)
                {
                    totalDamage += magicalAttackItem.AttackValue;
                }
            }
            
            foreach (IItem item in items)
            {
                if (item is LibroMagico libroMagico)
                {
                    totalDamage += libroMagico.AttackValue;
                }
            }
            return totalDamage;
        }
    }
}