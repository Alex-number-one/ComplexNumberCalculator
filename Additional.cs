class AdditionFunction
{
    public int a;
    public int b;
    public int c;
    public int d; 
 

public AdditionFunction(int a, int b, int c, int d)
{
    this.a = a;
    this.b = b;
    this.c = c;
    this.d = d;
}

    public void Addition()
    {
        int res1 = (a + c);
        int res2 = (b + d);
        
        Console.WriteLine($"{res1} + {res2}i");
    }
}
