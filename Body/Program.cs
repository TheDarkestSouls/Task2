Console.Write("Enter first number: "); 
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: "); 
int second = Convert.ToInt32(Console.ReadLine());

int a = first, b = second;

if(a > b)
{
    Console.Write(a); Console.Write(" is bigger than "); Console.Write(b); //Console.WriteLine(" is bigger than " + b);
}

if(a < b)
{
    Console.Write(a); Console.Write(" is less than "); Console.Write(b); //Console.WriteLine(" is less than " + b);
}

if(a == b)
{
    Console.Write(a); Console.Write(" and "); Console.Write(b); Console.Write(" are equal"); //Console.WriteLine(a + " and " + b + " are equal");
}