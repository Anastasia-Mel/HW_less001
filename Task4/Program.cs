//Принимает три числа и выдает
//максимальное из этих чисел

Console.WriteLine("Enter number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number three: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 >= num2 && num1 > num3)
{
    Console.WriteLine($"Max number: {num1}.");
}
else if(num2 > num1 && num2 >= num3)
{
    Console.WriteLine($"Max number: {num2}.");
}
else if(num3 >= num1 && num3 > num2)
{
    Console.WriteLine($"Max number: {num3}.");
}
else if(num1 == num2 && num1 == num3 && num2 == num3)
{
    Console.WriteLine("The numberts are equal!");
}