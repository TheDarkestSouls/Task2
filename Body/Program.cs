Console.Write("Enter first number: "); 
string first = Console.ReadLine();
Console.Write("Enter second number: "); 
string second = Console.ReadLine();

int a = first, b = second;

if(a > b)
{
    Console.Write(a); Console.Write(" is bigger than "); Console.Write(b); 
}

if(a < b)
{
    Console.Write(b); Console.Write(" is bigger than "); Console.Write(a); 
}

if(a == b)
{
    Console.Write("numbers are equal");
}