Console.WriteLine("Введите число дня недели, чтобы узнать выходной ли это: ");
void DayNum(string num)
{
    if ( int.Parse(num) > 7 | int.Parse(num) <= 0)
    {
        Console.WriteLine("нет такого дня недели");
    }
    else
    {
        switch (num)
        {
            case "6":
                Console.WriteLine("Да");
                break;
            case "7":
                Console.WriteLine("да");
                break;
            default:
                Console.WriteLine("нет");
                break;
        }
    }
}
string day = Console.ReadLine()!;
DayNum(day);
