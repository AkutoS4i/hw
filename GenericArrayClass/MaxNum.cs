namespace GenericArrayClass
{
    public class MaxNumber<T> where T : IComparable
    {
        public static T MaxNum(T numOne, T numTwo, T numThree)
        {
            if (numOne.CompareTo(numTwo) > 0)
            {
                if (numOne.CompareTo(numThree) > 0) return numOne;
                else return numThree;
            }
            else if (numTwo.CompareTo(numThree) > 0) return numTwo;
            else return numThree;
        }
    }
}