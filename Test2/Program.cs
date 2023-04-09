int SetNumber(string text = "") //45987
{
    System.Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int MethodNum(int number)
{
    int count = 0;
    if (number < 0) number *= -1;
    for (; number >= 0; number /= 10)
    {
        ++count;
    }
    return count;
}
int number = SetNumber();
Console.WriteLine($"Quantity number = {MethodNum(number)}");