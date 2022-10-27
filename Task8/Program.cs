//Принимает число (N) и выдает
//все четные (num%2=0) от 1 до N

Console.WriteLine("Enter positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
int rest = Convert.ToInt32(num % 2);
int index = 2;

while(index <= num)
{
    if(rest == 0);
    Console.Write($"{index}, ");
    index += 2;
}