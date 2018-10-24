using System;

namespace GADEFINAL_POE
{
    class Map
    {
        public string[,] GameMap = new string[20, 20];
        public Unit[] units = new Unit[10];
        string[] Names = new string[] { "Kyle", "alpha", "bravo", "ringSting", "Chops", "Liam", "cam", "beefy", "kaylee", "jordan", "bunnychow", "Green", "hundry", "TikkaBomb", "Julia", "Swastik", "Johno", "Steve" };
        public Building[] buildings = new Building[8];
        


        Random r = new Random();

        public Map()
        {

        }

        public void BattleField()
        {
            for(int k = 0; k < 20; k++)
            {
                for(int j =0; j<20; j++)
                {
                    GameMap[k, j] = ".";
                }
            }
        }

        public void PopulateMap()
        {
            UnitPlacing();

            for(int k =0; k <units.Length; k++)
            {
                Console.WriteLine(units[k].ToString());
            }
            for (int k = 0; k < buildings.Length; k++)
            {
                Console.WriteLine(buildings[k].ToString());
            }

        }

        public void UnitPlacing()
        {
            for(int k =0; k < units.Length;k++)
            {
                int UnitType;
                int Faction;
                int name = r.Next(0, Names.Length);

                string placeFaction = "";
                string placeSymbol = "";

                int x = r.Next(1, 20);
                int y = r.Next(1, 20);

                UnitType = r.Next(1, 3);

                switch(UnitType)
                {
                    case 1:
                       Faction = r.Next(1, 3);
                        switch(Faction)
                        {
                            case 1:
                                placeFaction = "Rogue Team 1";
                                placeSymbol = "M";
                                break;

                            case 2:
                                placeFaction = "Rogue Team 2";
                                placeSymbol = "m";
                                break;
                        }
                        units[k] = new MeleeUnit(x, y, placeFaction, placeSymbol, Names[name]);
                        break;

                    case 2:
                        Faction = r.Next(1, 3);
                        switch(Faction)
                        {
                            case 1:
                                placeFaction = "Hero Team 1";
                                placeSymbol = "R";
                                break;

                            case 2:
                                placeFaction = "Hero Team 2";
                                placeSymbol = "r";
                                break;
                        }
                        units[k] = new RangedUnit(x, y, placeFaction, placeSymbol, Names[name]);
                        break;
                }
                GameMap[units[k].Yposition, units[k].Xposition] = units[k].Symbol;
                
                
            }           
        }
        public void BuildingPlacing()
        {
            int f = 0;
            int Faction;

            string placeFaction = "";
            string placeSymbol = "";

            buildings[f] = new FactoryBuilding(0, 0, "Rogue team", "F");
            GameMap[buildings[f].Xposition, buildings[f].Yposition] = buildings[f].Symbol;
            f++;
            buildings[f] = new FactoryBuilding(17, 17, "Hero team", "f");
            
        }
    }
}
