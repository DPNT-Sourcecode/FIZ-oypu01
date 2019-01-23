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
                bool intThree = (i % 3 == 0 ? true : false) || (i.ToString().Contains("3") ? true : false);
                bool intFive = (i % 5 == 0 ? true : false) || (i.ToString().Contains("5") ? true : false);

                if (!intThree && !intFive)
                    rtnValue = i.ToString();
                else
                {
                    if(intThree) rtnValue = "fizz";
                    if(intFive) rtnValue = "buzz";
                    //if (intThree && intFive) rtnValue = "fizz buzz";
                }
            }

            return rtnValue;
        }
    }
}





