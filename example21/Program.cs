/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
double formulaDlina()
{
    Console.WriteLine("Точка 1 координаты X");
    int tochka1X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты Y");
    int tochka1Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты Z");
    int tochka1Z = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Точка 2 координаты X");
    int tochka2X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты Y");
    int tochka2Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты Z");
    int tochka2Z = Convert.ToInt32(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow(tochka1X - tochka2X, 2) + Math.Pow(tochka1Y - tochka2Y, 2) + Math.Pow(tochka1Z - tochka2Z, 2));
        return result;
}
double result = formulaDlina();
Console.WriteLine(result);
