//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125




string numderskub()
 {
    Console.Write("Введите положительное число ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i=1;
            string res = string.Empty;   //пустая строка
            while (i <= N)
            {
                res = res + i*i*i+", ";
                i=i+1;
            }
            return res;
 }
 try
{
    Console.WriteLine(numderskub());
}
catch
{
    Console.WriteLine("Введите положительное число цифрами");
}
 