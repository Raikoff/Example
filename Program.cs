


Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();

int num = int.Parse(a);

if (num <= 9999 || num >= 999999)
{
Console.WriteLine("Не умеешь считать до пяти?");
}
   else if (int.Parse("" + num[0]) == int.Parse("" + num[5]) || int.Parse("" + num[1]) == int.Parse("" + num[3]))
   {
    Console.WriteLine("Число проверяеться на полидромом");
   }