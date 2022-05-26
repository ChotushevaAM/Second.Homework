// Задача 1

int Chislo(int num)
    {
        int n1 = ( num / 10) % 10;
    
        return n1;
    }
    int number = new Random().Next(100,1000);
    Console.WriteLine(number + "-->" + Chislo(number));
    

// Задача 2

    int sum(int num)
{
    int n1 = (num / 100 % 10);
    return n1;
}
int number = new Random().Next(10,100000);
Console.WriteLine(number + "-->" + sum(number));

// Задача 3

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 6)
{
    Console.WriteLine("нет\n");
}
else if(number == 6)
{
    Console.WriteLine("да\n");
}
else if(number == 7)
{
    Console.WriteLine("да\n");
}
