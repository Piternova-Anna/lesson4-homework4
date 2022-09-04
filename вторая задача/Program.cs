// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void FillArray(int[]Array,int Nums,int length)
{
       for (int i = 0; i < length; i++)
    {
        Array[i] = Nums%10;
        Nums=Nums/10;
    }
}
void GetSumNums(int[]coll, int size,int N)
{
    int Sum = 0;
    for (int i = 0; i < size; i++)
    {
        Sum = Sum + coll[i];
    }
    Console.WriteLine("сумма цифр в числе "+N+ " равна "+Sum);
}
Console.Write("введите число: ");
int N = int.Parse(Console.ReadLine());
   if (N > 0)
{
    int Value = N;
    int Length = 1;
    while (Value/10 > 0)
    {
        Length = Length+1;
        Value = Value/10;
    } 
int[]array = new int[Length];
FillArray(array,N,Length);
GetSumNums(array, Length,N);

}
else
{
    N = (-1)*N;
    int Value = N;
    int Length = 1;
    while (Value/10 > 0)
    {
        Length = Length+1;
        Value = Value/10;
    } 
int[]array = new int[Length];
FillArray(array,N,Length);
GetSumNums(array, Length,N);
}


    