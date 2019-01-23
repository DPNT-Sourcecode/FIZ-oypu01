using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string rtnValue = string.Empty;
            for(int i = 1; i <= number; ++i )
            {
                bool intThree = (i % 3 == 0 ? true : false) || (i.ToString().Contains("3") ? true : false);
                bool intFive = (i % 5 == 0 ? true : false) || (i.ToString().Contains("5") ? true : false);


                bool sameVal = false;
                string numValue = number.ToString();
                string deluxeValue = string.Empty;
                for (int k = 0; k < numValue.Length; k++)
                {
                    if (k >= 1)
                    {
                        if (numValue[k] == numValue[k - 1])
                            sameVal = true;
                        else
                        {
                            sameVal = false;
                            break;
                        }
                    }
                }

                //if (sameVal) rtnValue = "deluxe";
                if (i % 3 == 0 && i.ToString().Contains("3"))
                    sameVal = true;
                else if (i % 5 == 0 && i.ToString().Contains("5"))
                    sameVal = true;

                if (sameVal)
                {
                    if (i % 2 != 0)
                        deluxeValue = "fake deluxe";
                    else
                        deluxeValue = "deluxe";
                }

                if (!intThree && !intFive)
                {
                    if (!sameVal)
                        rtnValue = i.ToString();
                    else
                        rtnValue = deluxeValue;
                }
                else
                {
                    if (intThree) rtnValue = "fizz";
                    if (intFive) rtnValue = "buzz";
                    if (sameVal) rtnValue = deluxeValue;
                    if (intThree && sameVal && i.ToString().Contains("3"))
                        rtnValue = "fizz" ;
                    else if (intThree && sameVal) rtnValue = "fizz " + deluxeValue;
                    if (intFive && sameVal) rtnValue = "buzz " + deluxeValue;
                    if (intThree && intFive) rtnValue = "fizz buzz";
                    if (intThree && intFive && sameVal) rtnValue = "fizz buzz " + deluxeValue;
                }
            }

            return rtnValue;
        }
    }
}
