Console.WriteLine("Введите число(кол-во элементов массива)");
int M = Convert.ToInt32(Console.ReadLine());
double[] array = new double[M];

Vvod vv = new Vvod();
Write wr = new Write();
check ch = new check();

vv.MassArray(array);
wr.WriteArray(array);
ch.CheckPlus(array);
Console.WriteLine(" ");
Console.WriteLine($"Кол-во чисел, которые больше нуля: {check.q}");