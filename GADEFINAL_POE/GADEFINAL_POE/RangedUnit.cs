using System;

namespace GADEFINAL_POE
{
    class RangedUnit:Unit
    {
        Random r = new Random();

        public RangedUnit(int Xposition, int Ypositon, string faction, string symbol, string name):base(Xposition,Ypositon,faction,symbol,name)
        {
            this.Xposition = Xposition;
            this.Yposition = Yposition;
            this.hp = 100;
            this.atk = 3;
            this.range = 1;
            this.faction = faction;
            this.symbol = symbol;
            this.name = name;
            this.maxHp = MaxHp = 100;
            this.attackStuff = AttackStuff = false;
        }

        public override string ToString()
        {
            string[] unitType = GetType().ToString().Split('.');
            string myType = unitType[unitType.Length - 1];

            return Faction + "," + Name + "," + myType + "," + (Xposition + 1) + "," + (Yposition + 1) + "," + hp;
        }

        public override Unit GetClosestUnit(Unit[] units)
        {
            int tDistance = 500;
            int Distance = tDistance;
            Unit feedBackUnit = null;

            for (int k = 0; k < units.Length; k++)
            {
                if (units[k] != null && units[k] != this && units[k].Hp > 0 && units[k].Faction != this.faction)
                    Distance = ((this.Xposition - units[k].Xposition) ^ 2 + (this.Yposition - units[k].Yposition) ^ 2) ^ 1 / 2;
                if (Distance < 0)
                {
                    tDistance = Distance;
                    feedBackUnit = units[k];

                }
            }
            return feedBackUnit;
        }

        public override void MoveToEnemy(Unit enemy)
        {
            if (enemy != null)
            {
                int DistanceX = (enemy.Xposition - Xposition);
                int DistanceY = (enemy.Yposition - Yposition);
                if (Math.Abs(DistanceX) < Math.Abs(DistanceY))
                {
                    if (DistanceX < 0)
                        Xposition--;
                    else if (DistanceX > 0)
                        Xposition++;
                }
                else if (Math.Abs(DistanceY) < Math.Abs(DistanceX))
                {
                    if (DistanceY < 0)
                        Yposition--;
                    else if (DistanceY > 0)
                        Yposition++;
                }

            }

        }

        public override bool InRange(Unit enemy)
        {
            int Dist = 500;
            if (enemy != null)

                Dist = ((Xposition - enemy.Xposition) ^ 2 + (Yposition - enemy.Yposition) ^ 2) ^ 1 / 2;
            if (Dist <= this.range)
                return true;
            else
                return false;

        }

        public override void MoveInAnotherDirection()
        {
            bool valid = false;
            int move = 0;
            while (valid == false)
            {
                move = r.Next(1, 5);
                if (Yposition == 0 && move == 1)
                    valid = false;
                else if (Xposition == 19 && move == 2)
                    valid = false;
                else if (Yposition == 19 && move == 3)
                    valid = false;
                else if (Xposition == 0 && move == 4)
                    valid = false;
                else
                    valid = true;
            }

            switch (move)
            {
                case 1:
                    Yposition--;
                    break;
                case 2:
                    Xposition++;
                    break;
                case 3:
                    Yposition++;
                    break;
                case 4:
                    Xposition--;
                    break;
            }
        }

        public override int Attack()
        {
            return this.Atk;
        } 
    }
}
