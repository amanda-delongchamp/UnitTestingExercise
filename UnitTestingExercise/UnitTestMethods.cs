using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // DONE: Make sure your references are set properly
        // DONE: Righ-click on Dependencies in your .Tests project and set your reference



        // Done: Create an Add method that passes 3 integers

       
        public int Add(int one, int two, int three)
        {

            return one + two + three;
        }
        // Done:  Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend


        public int Subtract(int one, int two)
        {

            return one - two;
        }
        // Done:  Create a Multiply method that passes 2 integers

        public int Multiply(int one, int two)
        {

            return one * two;
        }
        // Done: Create a Divide method that passes 2 integers


        public int Divide(int one, int two)
        {
            if (one != 0 && two != 0)
            {
                return one / two;
            }
            else
            {
                return 0;
            }
            
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote


        public bool MyStringMethod()
        {
            string s = "hey";

            if (s == "hey")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public bool MySecondMethod()
        {

            return false;
        }
    }
}
