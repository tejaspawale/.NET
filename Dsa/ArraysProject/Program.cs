int[,] numbers =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};


int[,] numbers2 =
{
    {7,8,9},
    {10,11,12}
};

Console.WriteLine(numbers[0,0] + numbers2[0,0]);
Console.WriteLine(numbers[0,1] + numbers2[0,1]);
Console.WriteLine(numbers[0,2] + numbers2[0,2]);

Console.WriteLine(numbers[1,0] + numbers2[1,0]);
Console.WriteLine(numbers[1,1] + numbers2[1,1]);
Console.WriteLine(numbers[1,2] + numbers2[1,2]);

for(int i = 0; i<=1 ; i++)
{
    for(int j = 0; j<=2; j++)
    {
        Console.Write((numbers[i,j] + numbers2[i,j] +" "));
    }
    Console.WriteLine();

}


int[,]result = new int  [3,3];
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        result[j,i] = numbers[i,j];
    }
}

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }

    Console.WriteLine();
}