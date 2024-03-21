class MultiplicationFunction
{
    public int a;
    public int b;
    public int c;
    public int d; 

public MultiplicationFunction(int a, int b, int c, int d)
{
    this.a = a;
    this.b = b;
    this.c = c;
    this.d = d;
}

    public void Multiplication()
    {
        int res1 = (a * c);
        int res2 = (b * d);
        int finish1 = res1 - res2;
        int res3 = (a * d);
        int res4 = (b * c);
        int finish2 = res3 + res4;
        Console.WriteLine($"{finish1} + {finish2}i");
    }
}
