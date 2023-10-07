namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 30;
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