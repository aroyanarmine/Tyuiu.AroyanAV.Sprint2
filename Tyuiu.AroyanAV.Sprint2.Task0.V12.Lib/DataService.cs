using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AroyanAV.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = (x + 0) > (y + 0);
            res[1] = (x - 1000) < (y - 500);
            res[2] = (x % 2) == (y % 2);
            res[3] = (x / 100) == (y / 100);
            res[4] = (x * 0 + 1) != (y * 0 + 0);
            res[5] = (x + y) <= (x + y - 1);

            return res;
        }
    }
}
