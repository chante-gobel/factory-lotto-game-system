using System;
using System.Collections.Generic;
using System.Text;

namespace LottoGame.ConcreteGames.DivisionFactory
{
    public class SALottoDivisions : IDivisionFactory
    {
        public string Division1()
        {
            return "Winner – Division 1";
        }

        public string Division2()
        {
            return "Winner – Division 2";
        }

        public string Division3()
        {
            return "Winner – Division 3";
        }

        public string Division4()
        {
            return "Winner – Division 4";
        }

        public string Division5()
        {
            return "Winner – Division 5";
        }

        public string Division6()
        {
            return "Winner – Division 6";
        }

        public string Division7()
        {
            return "Winner – Division 7";
        }

        public string Division8()
        {
            return "Winner – Division 8";
        }

        public string NoDivision()
        {
            return "Not a winner";
        }
    }
}
