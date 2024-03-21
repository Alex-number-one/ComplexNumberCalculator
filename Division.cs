class DivisionFunction
{
    public int a;
    public int b;
    public int c;
    public int d; 
   

public DivisionFunction(int a, int b, int c, int d)
{
    this.a = a;
    this.b = b;
    this.c = c;
    this.d = d;
}

    public void Division()
    {
        int ac = (a * c);
        int bd = (b * d);
        int bc = (b * c);
        int ad = (a * d);
        int divider = (c * c) + (d * d);
        int res1 = (ac + bd) / divider;
        int res2 = (bc + ad) / divider;
        Console.WriteLine($"{res1} + {res2}i");
    }
}
