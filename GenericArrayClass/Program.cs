namespace GenericArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new GenericArrayClass<int>();
            array.AddElements(132);
            array.AddElements(543);
            array.AddElements(2345);
            array.AddElements(765);
            array.AddElements(123455);
            array.AddElements(04576);
            array.AddElements(8347968);
            array.AddElements(574863);
            array.AddElements(2345);
            array.AddElements(546367);
            Console.WriteLine(array.GetElement(3));
            array.CountElements();

            Console.WriteLine(MaxNumber<int>.MaxNum(47, 69, 99));
        }
    }
}