Console.Clear();
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Неверное число");
    return;
}
int y=num%100;
int x = y / 10;
Console.WriteLine($"{x}");