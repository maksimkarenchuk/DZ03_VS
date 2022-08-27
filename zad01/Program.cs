// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


public class IsPalindrome
{
public static void Main(string[] args)
{
    int no,total=0,t,rev;
    Console.Write("Введите число ");
    no = int.Parse(Console.ReadLine());
    t=no;
        while(no > 0)
        {
                rev = no % 10;
                total = (total * 10) + rev;
                no = no / 10;
        }
        if(t == total)
                Console.Write("Это число палиндром");
        else
                Console.Write("Это число не палиндром");
        }
        }