namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 50;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 15;
            }
        }
    }
}