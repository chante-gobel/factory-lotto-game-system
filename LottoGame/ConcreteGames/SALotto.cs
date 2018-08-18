using LottoGame.Games;
using LottoGame.ConcreteGames;
using System;

namespace LottoGame
{
    public class SALotto : GameFactory
    {
        readonly IDivisionFactory divisionFactory;
        public SALotto (IDivisionFactory divisionFactory)
        {
            this.divisionFactory = divisionFactory;
        }
    
        public override string GetDivision(int result)
        {
            switch (result)
            {
                case 1: return divisionFactory.Division1();
                case 2: return divisionFactory.Division2();
                case 3: return divisionFactory.Division3();
                case 4: return divisionFactory.Division4();
                case 5: return divisionFactory.Division5();
                case 6: return divisionFactory.Division6();
                case 7: return divisionFactory.Division7();
                case 8: return divisionFactory.Division8();

                default: return divisionFactory.NoDivision();
            }

        }

    
    }
}
