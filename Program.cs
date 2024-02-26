// See https://aka.ms/new-console-template for more information

MathUtils.Add(1,2);
RandomNumber.Gets();
var a = new RandomNumber();
a.Get();
/*Static classes use cases*/
public static class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
class RandomNumber
{
    private static Random random;

    static RandomNumber()
    {
        random = new Random();
    }
    public int Get() => random.Next();
    public static void Gets() => Console.WriteLine("random.Next()");
}