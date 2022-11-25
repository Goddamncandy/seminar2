Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
    Console.WriteLine("Третьей цифры нет");
else if (a > 99 && a < 1000)
    Console.WriteLine(a % 10);