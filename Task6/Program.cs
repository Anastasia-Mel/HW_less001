//Принимает число и выдает,
//является ли число четным (num%2=0)

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int rest = Convert.ToInt32(num % 2);

if(rest == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}