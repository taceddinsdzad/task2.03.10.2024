int deciml, simple;
int num = Convert.ToInt32(Console.ReadLine());
deciml = num / 10;
simple = num % 10;
if (deciml > simple)
{
    Console.WriteLine(deciml);
}
if (simple > deciml)
{
    Console.WriteLine(simple);
}