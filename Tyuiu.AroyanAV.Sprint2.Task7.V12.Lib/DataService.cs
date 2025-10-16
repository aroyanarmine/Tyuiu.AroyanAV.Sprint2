using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AroyanAV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if (((x < 0) && ((y >= 2 - x) && (y <= x * x))) || ((y >= 0) && (x >= 0) && (y <= x * x) && (y <= 2 - x))) res = false;
            return res;
        }

    }
}
