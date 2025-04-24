// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
int n = 20;
Console.WriteLine("Duzgun eded daxil et");
if (n == 0)
{
    Console.WriteLine("0 ne 3e ne 7e bolunur");

}
else if (n % 3 == 0 && n % 7 == 0)
{
    Console.WriteLine("Eded hem 3e hem 7e bolunur");
}
else if (n % 7 == 0)
{
    Console.WriteLine("Eded yalniz 7e bolunur");
}

else if (n % 3 == 0)
    Console.WriteLine("eded yalniz 3e bolunur");
else
{
    Console.WriteLine("Eded ne 7e ne 3e bolunur");
}


int a = 20;


if (a > 15 && a < 10)
{
    Console.WriteLine("10dan boyuk 15den kicik");

}
else
{

    Console.WriteLine("Bu araliqda deyil");

}
    





