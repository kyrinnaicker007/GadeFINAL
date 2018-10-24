namespace GADEFINAL_POE
{
    class FactoryBuilding:Building
    {
        public FactoryBuilding(int Xposition, int Yposition, string faction, string symbol): base(Xposition,Yposition,faction,symbol)
        {
            this.hp = 70;
            this.Xposition = Xposition;
            this.Yposition = Yposition;
            this.faction = faction;
            this.symbol = symbol;
        }

        public override string ToString()
        {
            string[] unitType = GetType().ToString().Split('.');
            string myType = unitType[unitType.Length - 1];

            return Faction + "," + myType + "," + (Xposition + 1) + "," + (Yposition + 1) + "," + Hp;
        }



    }
}
