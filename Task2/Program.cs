//Принимает два числа и выдает,
//какое число больше, а какое меньше (а=5, б=7, мах=7)

Console.WriteLine("Enter number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number one: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Number {num1} is bigger then {num2}.");
}
else if(num2 > num1)
{
    Console.WriteLine($"Number {num2} is bigger then {num1}.");
}

else if(num1 == num2)
{
    Console.WriteLine("The numberts are equal!");
}