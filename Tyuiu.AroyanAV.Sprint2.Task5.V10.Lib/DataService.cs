using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AroyanAV.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            g--; m = 12; n = 31;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 2: n = 28; break;
                                case 4: case 6: case 9: case 11: n = 30; break;
                                default: n = 31; break;
                            }
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }

            return $"{(n < 10 ? "0" + n : n)}.{(m < 10 ? "0" + m : m)}.{g}";
        }
    }
}

