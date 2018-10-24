namespace GADEFINAL_POE
{
    abstract class Building
    {
        protected int xposition;
        protected int yposition;
        protected int hp;
        protected string faction;
        protected string symbol;

        public int Xposition { get => xposition; set => xposition = value; }
        public int Yposition { get => yposition; set => yposition = value; }
        public int Hp { get => hp; set => hp = value; }
        public string Faction { get => faction; set => faction = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public int WoodResources { get => woodResources; set => woodResources = value; }

        public Building(int Xposition, int Yposition, string faction, string symbol)
        {

        }

        protected int woodResources;

        public virtual int PlaceWoodResources()
        {
            return 0;
        }
    }
}
