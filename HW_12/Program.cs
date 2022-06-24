using HW_12;
using static HW_12.Adder;

internal class Program
{
    private static void Main(string?[] args)
    {
        Summator sumDeleg1 = Adder.GetResult1;
        Summator sumDeleg2 = Adder.GetResult2;

        Adder.trySum(sumDeleg1, 5, 10);
        Adder.trySum(sumDeleg2, 10, 20);
    }
}