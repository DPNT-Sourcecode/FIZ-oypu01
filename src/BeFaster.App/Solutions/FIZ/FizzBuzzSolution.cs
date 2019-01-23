using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string rtnValue = string.Empty;
            for(int i = 1; i < number; ++i )
            {
                bool intThree = (i % 3 == 0 ? true : false);
                bool intFive = (i % 5 == 0 ? true : false);
            }

            return rtnValue;
        }
    }
}

