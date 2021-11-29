public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        int c = program.add();
        int r = sub(8,2);
        int g = mul(9,4);
        int j = div(7,6);
        Console.WriteLine(c);
        Console.WriteLine("the multiplacion is  " + g);
        Console.WriteLine("the div is  " + j);
        Console.WriteLine("the sub is  " + r);
        Dog name = new Dog();

    }

    public int add (int a, int b)
    {
        return a+b; 
    }

    public static int sub (int a, int b)
    {
        return a-b;
    }   

    public static int mul ( int a, int b)
    {
        return a*b;
    }

    public static int div (int a, int b)
        {
            return a/b;
        }
} 
