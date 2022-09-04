// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int[]array)
{
   int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}
void PrintArray(int[]arr)
{ 
    Console.Write("[");
    int count = arr.Length;
        for (int position = 0; position < count-1 ; position++)
    {
       Console.Write(arr[position]+",");
    }
    
Console.WriteLine(arr[count-1]+"]");
}

int[]Array = new int [8];
FillArray(Array);
PrintArray(Array);
