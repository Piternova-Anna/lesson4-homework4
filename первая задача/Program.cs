// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void FillArray(int[]array,int N, int size)
{
   int length = size;
       for (int i = 0; i < length; i++)
    {
        array[i] = N;
    }
}

void GetArrayPow(int[]array,int N,int Length)
{
   
   int length = Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = N;
    }
double ArrayPow = 1;
    for (int i = 0; i < length; i++)
    {
        ArrayPow=ArrayPow*array[i];
    }
    Console.WriteLine(N +" в степени "+ Length +"->"+ArrayPow);
}


Console.Write("введите число A: ");
int A= int.Parse(Console.ReadLine());
Console.Write("введите число B: ");
int B = int.Parse(Console.ReadLine());
   if (B == 0)
    {
        Console.WriteLine("значение B не может быть равно 0");
    }
else
{
   if (B > 0)
{
    int[]Array = new int [B];
    FillArray(Array,A,B);
    GetArrayPow(Array,A,B);
}
else
{
    B = (-1)*B;
    int[]Array = new int [B];
    FillArray(Array,A,B);
    GetArrayPow(Array,A,B);
}
 
}
