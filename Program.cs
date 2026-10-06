public int Multiply(int x, int y)
{
    return x * y
}
public int Add(int x, int y)
{
    Console.WriteLine(Multiply(2, 3));
    return x+y   
}

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,8));
        }
    }
}