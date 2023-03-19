
try
{
    var array = new int[] { 4, 6, 10, 35, 178, 43, 77, 51 };
    var max = 10000;
    var secMax = 0;
    foreach (var item in array)
    {
        if (max < item)
        {
            max = item;
        }
    }
    Console.WriteLine(secMax);
}
finally
{
    Console.WriteLine("Ошибка. Пожалуйста, перепроверьте введёные данные");
}
