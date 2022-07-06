/* Решение задачи 23


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


/* Решение задачи 19


void pali(int n)  
{
    int a, b, c, d, e;
    while(n > 9999 && n <= 99999)
    {
        a = n % 10;
        b = n / 10000;
        c = n / 10;
        n = c % 1000;
        if (a != b)
        {
            Console.WriteLine("Введенное число не является палиндромом");
        }
        else
        {
            d = n % 10;
            e = n / 100;
            if (d == e)
            {   
            Console.WriteLine("Введенное число - палиндромом");
            }
            else
            {
                Console.WriteLine("Введенное число не является палиндромом");
            }
        }
    }
    
}

Console.WriteLine("Введите пятизначное число для для определения палиндрома: ");
int n = Convert.ToInt32(Console.ReadLine());

pali(n); */