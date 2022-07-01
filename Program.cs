/* РЕшение задачи 23


void cub(int n)
{
    int i=0;
    for (; i <= n; i++)
    {
        int num = i*i*i;
        Console.WriteLine(i + "^3 = "+ num);
    }
}

Console.WriteLine("Введите число N, для формирования таблицы кубов: ");
int n = Convert.ToInt32(Console.ReadLine());

cub(n); */