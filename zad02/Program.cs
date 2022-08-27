// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



string rast3d()
{
    Console.Write("Введите координату X первой точки ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y первой точки ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z первой точки ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату X второй точки ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y второй точки ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z второй точки ");
    int z2 = Convert.ToInt32(Console.ReadLine());
        
            double rast3d;
            //rast3d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
            rast3d = Math.Sqrt(Math.Pow(x1 - x2, 2)+ Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
            return ($"Длина между точками в 3D {rast3d}");
}
try
{
    Console.WriteLine(rast3d());
}
catch
{
    Console.WriteLine("Координаты вводятся цифрами");
}


    
