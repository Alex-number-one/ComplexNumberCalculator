class Program
{
static void Main()
{
    Console.WriteLine("Выберите номер для действия с примером:\n1) Сложение\n2) Умножение\n3) Деление");
int mode = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число(индекс i): ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 число(индекс i): ");
int num4 = Convert.ToInt32(Console.ReadLine());

if (mode == 1)
{
AdditionFunction task1 = new AdditionFunction(num1, num2, num3, num4);
task1.Addition();
}
if (mode == 2)
{
MultiplicationFunction task1 = new MultiplicationFunction(num1, num2, num3, num4);
task1.Multiplication();
}
if (mode == 3)
{
DivisionFunction task1 = new DivisionFunction(num1, num2, num3, num4);
task1.Division();
}
}
}