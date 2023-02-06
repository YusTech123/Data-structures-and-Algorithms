class Program
{
    static void Main(string[] args)
    {
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int valueToFind = 5;
        BinarySearchClass binarySearch = new BinarySearchClass(values, valueToFind);
        int result = binarySearch.Search();
        Console.WriteLine(result);
    }
}
