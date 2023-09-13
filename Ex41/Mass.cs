class Vvod
{
     public double[] MassArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {   Console.WriteLine($"Введите число: {i+1}");
             array[i] = Convert.ToInt32(Console.ReadLine());
        }

        return(array);
    }
}