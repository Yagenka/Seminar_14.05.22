// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Проверяемый день недели - ");
int denNedeli = new Random().Next(1,8);
Console.WriteLine(denNedeli);


if (denNedeli < 6)
Console.WriteLine("Этот день будний");
else
{
    Console.WriteLine("Этот день выходной");
}