using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AroyanAV.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) & (c != d);
            res[1] = (b > c) | (a == d);
            res[2] = (c >= a) ^ (b <= d);
            res[3] = !(a + c == b - d);
            res[4] = (a * 2 > d) && (c < b);
            res[5] = (a + b == c + d);
            return res;
        }
    }
}