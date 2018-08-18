using System.Collections.Generic;
using System.Linq;

namespace LottoGame.Games
{
    public abstract class GameFactory : IGameFactory
    {
        public string CaptureGame(int[] lottoNumbers)
        {
            return GetDivision(WinningNumbers(lottoNumbers));

        }

        public abstract string GetDivision(int result);


        private int WinningNumbers(int[] array)
        {

            var winningNumberLookUp = new Dictionary<int, string>()
            {
                { 1, string.Join(",",new int[] { 1, 6, 10, 18, 21, 32, 7 })},
                { 2, string.Join(",",new int[] { 1, 6, 10, 18, 19, 28, 7 })},
                { 3, string.Join(",",new int[] { 1, 6, 10, 18, 19, 30, 20 })},
                { 4, string.Join(",",new int[] { 1, 6, 10, 18, 20, 25, 7 })},
                { 5, string.Join(",",new int[] { 1, 6, 10, 18, 20, 25, 3 })},
                { 6, string.Join(",",new int[] { 1, 6, 10, 16, 24, 30, 7 })},
                { 7, string.Join(",",new int[] { 1, 6, 10, 16, 24, 30, 10 })},
                { 8, string.Join(",",new int[] { 1, 6, 7, 19, 25, 28, 7 })}
            };

            if (!(winningNumberLookUp.FirstOrDefault(x => x.Value == string.Join(",", array)).Key > 0))
            {
                return 0;
            }

            return winningNumberLookUp.FirstOrDefault(x => x.Value == string.Join(",", array)).Key;

        }
    }
}
