Console.WriteLine("Введите пятизначное число");
Console.Write("a: ");
string number =Console.ReadLine();
if(number[0]==number[4] || number[1]==number[3] )
{
  Console.WriteLine("Это число палиндром");
}
else 
{
  Console.WriteLine("Это число не палиндром");
}
