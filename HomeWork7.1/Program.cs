Console.WriteLine("Entered two numbers for diapasone: ");
int digit1 = int.Parse(Console.ReadLine());
int digit2 = int.Parse(Console.ReadLine());

if (digit1 > digit2)
{
    int temp = digit1;
    digit1 = digit2;
    digit2 = temp;

}
Console.WriteLine("Diapason of numbers: ");
for (int i = digit1; i < digit2; i++)
{
    if (i % 2 == 0)
    {

        Console.Write($"{i}, ");
    }
}
