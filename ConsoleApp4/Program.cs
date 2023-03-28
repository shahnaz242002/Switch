using System.Text;
Console.OutputEncoding = Encoding.UTF8;


int number = Convert.ToInt32(Console.ReadLine());
if (number % 10 == 0 && number < 20)
{
    switch (number)
    {
        case 1:
            Console.Write("Один");
            break;
        case 2:
            Console.Write("Два");
            break;
        case 3:
            Console.Write("Три");
            break;
        case 4:
            Console.Write("Четыре");
            break;
        case 5:
            Console.Write("Пять");
            break;
        case 6:
            Console.Write("Шесть");
            break;
        case 7:
            Console.Write("Семь");
            break;
        case 8:
            Console.Write("Восемь");
            break;
        case 9:
            Console.Write("Девять");
            break;
        case 10:
            Console.Write("десять");
            break;
        case 11:
            Console.Write("Одиннадцать");
            break;
        case 12:
            Console.Write("Двенадцать");
            break;
        case 13:
            Console.Write("Тринадцать");
            break;
        case 14:
            Console.Write("Четырнадцать");
            break;
        case 15:
            Console.Write("Пятнадцать");
            break;
        case 16:
            Console.Write("Шестнадцать");
            break;
        case 17:
            Console.Write("Семнадцать");
            break;
        case 18:
            Console.Write("Восемнадцать");
            break;
        case 19:
            Console.Write("Девятнадцать");
            break;
        case 20:
            Console.Write("двадцать");
            break;
        case 30:
            Console.Write("тридцать");
            break;
        case 40:
            Console.Write("сорок");
            break;
        case 50:
            Console.Write("пятьдесять");
            break;
        case 60:
            Console.Write("шестьдесять");
            break;
        case 70:
            Console.Write("семьдесять");
            break;
        case 80:
            Console.Write("восемьдесять");
            break;
        case 90:
            Console.Write("девяноста");
            break;
    }
}
else
{
    switch (number / 10)
    {
        case 2:
            Console.Write("двадцать");
            break;
        case 3:
            Console.Write("тридцать");
            break;
        case 4:
            Console.Write("сорок");
            break;
        case 5:
            Console.Write("пятьдесять");
            break;
        case 6:
            Console.Write("шестьдесять");
            break;
        case 7:
            Console.Write("семьдесять");
            break;
        case 8:
            Console.Write("восемьдесять");
            break;
        case 9:
            Console.Write("девяноста");
            break;
    }
    Console.Write(" ");
    switch (number % 10)
    {
        case 1:
            Console.Write("Один");
            break;
        case 2:
            Console.Write("Два");
            break;
        case 3:
            Console.Write("Три");
            break;
        case 4:
            Console.Write("Четыре");
            break;
        case 5:
            Console.Write("Пять");
            break;
        case 6:
            Console.Write("Шесть");
            break;
        case 7:
            Console.Write("Семь");
            break;
        case 8:
            Console.Write("Восемь");
            break;
        case 9:
            Console.Write("Девять");
            break;
    }
}








