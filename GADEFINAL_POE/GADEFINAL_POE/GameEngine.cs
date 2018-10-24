namespace GADEFINAL_POE
{
    class GameEngine
    {
        public Map map = new Map();

        public GameEngine()
        {
        }

        public void StartGame()
        {
            SwitchUnitTurn();
        }

        private void SwitchUnitTurn()
        {
            for(int k = 0; k < map.units.Length;k++)
            {
                if(map.units[k]!=null)
                {
                    map.GameMap[map.units[k].Yposition, map.units[k].Xposition] = "";

                    if(map.units[k].Hp >0)
                    {
                        if((map.units[k].Hp/map.units[k].MaxHp)*100 <=25/100)
                        {
                            map.units[k].MoveInAnotherDirection();                            
                                if(map.units[k].InRange(map.units[k].GetClosestUnit(map.units))==true)
                                {
                                    for(int z = 0; z<map.units.Length;z++)
                                    {
                                        if (map.units[z] == map.units[k].GetClosestUnit(map.units) && map.units[z] != null) map.units[z].Hp -= map.units[k].Attack();
                                    }
                                }                           
                            
                        }
                        else
                        {
                            if (map.units[k].InRange(map.units[k].GetClosestUnit(map.units)) == true)
                            {
                                for (int z = 0; z < map.units.Length; z++)
                                {
                                    if (map.units[z] == map.units[k].GetClosestUnit(map.units) && map.units[z] != null) map.units[z].Hp -= map.units[k].Attack();
                                }
                            }
                            else
                                map.units[k].MoveToEnemy(map.units[k].GetClosestUnit(map.units));
                            
                        }
                        map.GameMap[map.units[k].Yposition, map.units[k].Xposition] = map.units[k].Symbol;
                        
                    }
                    else
                    {
                        map.GameMap[map.units[k].Yposition, map.units[k].Xposition] = "*";
                        map.units[k] = null;
                    }
                }
            }
        }
    }
}
