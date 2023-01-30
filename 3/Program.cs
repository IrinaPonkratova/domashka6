//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным 
//элементов массива.
double [] CreateArray()
{
    double [] array = new double [5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;

}
void PrintArray(double [] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
double Differ(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    double diff = maxValue - minValue;
    return diff; 
    
}


double [] numberArray = CreateArray();
PrintArray(numberArray, "массив: ");
System.Console.WriteLine(Differ(numberArray));
