namespace GADEFINAL_POE
{
    abstract  class Unit
    {
        protected int yposition;
        protected int xposition;
        protected int hp;
        protected int atk;
        protected int range;
        protected string faction;
        protected string symbol;
        protected string name;
        protected int maxHp;
        protected bool attackStuff;
        //variables declared for accessors to inherit 

        public int Yposition { get => yposition; set => yposition = value; }
        public int Xposition { get => xposition; set => xposition = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Range { get => range; set => range = value; }
        public string Faction { get => faction; set => faction = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Name { get => name; set => name = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Atk { get => atk; set => atk = value; }
        public bool AttackStuff { get => attackStuff; set => attackStuff = value; }

        public Unit(int Yposition, int Xposition, string faction, string symbol, string name)
        {
        }

        public abstract Unit GetClosestUnit(Unit[] units);

        public abstract bool InRange(Unit enemy);

        public abstract void MoveToEnemy(Unit enemy);

        public abstract int Attack();

        public abstract void MoveInAnotherDirection();

        

        
    }
}
