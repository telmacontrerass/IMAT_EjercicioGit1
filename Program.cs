public int Multiply(int x, int y)
{
    return x * y
}
public int Add(int x, int y)
{
    return x+y   
}

public double Divide(int x, int y)
{
    return x / y;
}

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2,3));
        }
    }
}