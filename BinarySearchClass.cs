class BinarySearchClass
{
    int[] values;
    int valueToFind;

    public BinarySearchClass(int[] values, int valueToFind)
    {
        this.values = values;
        this.valueToFind = valueToFind;
    }

    public int Search()
    {
        int start = 0;
        int end = values.Length - 1;

        while (start <= end)
        {
            int middle = (start + end) / 2;
            if (valueToFind == values[middle])
            {
                return middle;
            }
            else if (valueToFind < values[middle])
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }
        return -1;
    }
}




