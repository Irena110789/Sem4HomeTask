// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int deg = A;

for(int i = 1; i < B; i++)
{
    deg = deg * A;
}
Console.WriteLine($"The number A to the power of B is {deg}");


