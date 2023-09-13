class check
{
    static public int q = 0;
    public double[] CheckPlus(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
           if (array[i]>0)
           {
                q = q + 1;
           }
        }

        return array;
    }
}