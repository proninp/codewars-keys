namespace Kata._7_kyu.Leap_Years.src
{
    public class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}