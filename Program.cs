using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{    
    static void Main(string[] args)
    {
      // Задание 2
            // Console.WriteLine("Введите первое число");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите второе число");
            // int b = Convert.ToInt32(Console.ReadLine());
            // int summ=0;
            // for (int i = a+1; i < b; i++)
            // {
            //     summ += i;
            // }
            // Console.WriteLine(summ);
            
            int A = 0;
            int B = 10;
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("Первая задача: {0}", (A + B) * (B - A - 1) / 2);
            Console.Write("Вторая задача: ");
            for (int i = A + 1 % 2 == 1 ? A + 1 : A + 2; i < B; i = i + 2)
            Console.Write("{0} ", i);

            //Задание3
        
        // Console.Write ("*"); Console.Write (" "); Console.Write ("*"); Console.Write (" ");Console.Write ("*"); Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" "); Console.Write ("* ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        // Console.Write ("*"); Console.Write (" "); Console.Write ("*"); Console.Write (" ");Console.Write ("*"); Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("* ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        //   Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        // Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("*");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write (" ");Console.Write ("\n");
        
        // Задание 4
         
        {
            // double proc;
            // Console.WriteLine("Введите процент по вкладу(>0 <25) :");
            // proc = Convert.ToDouble(Console.ReadLine());
            // if (proc < 0 || proc > 25)
            // {
            //     Console.WriteLine("Нереальный процент :)");
            //     Console.ReadKey();
            //     Environment.Exit(0);
            // }
            // double deposit = 1000;
            // int count = 0;
            // while (deposit < 1100)
            // {
            //     deposit += deposit * proc/100;
            //     count++;
            // }
            // Console.WriteLine("До превышения лимита вклада на сумму 1100с. понадобится: {0} месяца \n сумма вклада составит: {1} с.", count, deposit);
            // Console.ReadKey(); 
        }
    }
}