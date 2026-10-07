public int Multiply(int x, int y)
{
    return x * y
}
public int Add(int x, int y)
{
    return x+y   
}

public int Substract(int x, int y)
{
    return x-y
}

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Substract(2,8));
        }
    }
