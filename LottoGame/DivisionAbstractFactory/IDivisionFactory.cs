using System;
using System.Collections.Generic;
using System.Text;

namespace LottoGame.ConcreteGames
{
    public interface IDivisionFactory
    {
        string Division1();
        string Division2();
        string Division3();
        string Division4();
        string Division5();
        string Division6();
        string Division7();
        string Division8();
        string NoDivision();
    }
}
