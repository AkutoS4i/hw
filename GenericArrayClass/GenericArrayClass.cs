namespace GenericArrayClass
{
    public class GenericArrayClass<T>
    {
        T[] array = new T[10];
        int index = 0;
        public void AddElements(T element)
        {
            try
            {
                array.SetValue(element, index);
                index++;
            }
            catch (IndexOutOfRangeException) { Console.WriteLine("Индекс не может быть больше 10"); }
        }
        public T GetElement(int index) => (T)array.GetValue(index);
        public void CountElements()
        {
            Console.WriteLine($"Количество элементов в массиве: {index}");
        }
    }
}