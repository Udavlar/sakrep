Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
if(numberDayOfWeek<1||numberDayOfWeek>7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if(numberDayOfWeek==1)
{
    Console.WriteLine("Понедельник");
    return;
}
if(numberDayOfWeek==2)
{
    Console.WriteLine("Вторник");
    return;
}
if(numberDayOfWeek==3)
{
    Console.WriteLine("Среда");
    return;
}
if(numberDayOfWeek==4)
{
    Console.WriteLine("Четверг");
    return;
}
if(numberDayOfWeek==5)
{
    Console.WriteLine("Пятница");
    return;
}
if(numberDayOfWeek==6)
{
    Console.WriteLine("Суббота");
    return;
}
if(numberDayOfWeek==7)
{
    Console.WriteLine("Воскресенье");
    return;
}
Console.WriteLine("Введен неправильный номер");