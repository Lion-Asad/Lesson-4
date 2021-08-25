using System;

class Program
{    
    static void Main(string[] args)
    {
         
        // Задание 1
             Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        int summ = 0;
        for (int i = a + 1; i < b; i++)
        {
            summ += i;
        }
        Console.WriteLine(summ);

        int A = 0;
        int B = 10;
        Console.WriteLine("A = {0}", A);
        Console.WriteLine("B = {0}", B);
        Console.WriteLine("Первая задача: {0}", (A + B) * (B - A - 1) / 2);
        Console.Write("Вторая задача: ");
        for (int i = A + 1 % 2 == 1 ? A + 1 : A + 2; i < B; i = i + 2)
            Console.Write("{0} ", i);
            Console.ReadKey();

        System.Console.WriteLine("\n");
        System.Console.WriteLine("\n");

         //Задание2
        // прямоуголник
            int i1 = 0, i2 = 0; 
                
            for (int aa = 0; aa < 6; aa++)
            {    
            for (int bb = 0; bb < 15; bb++)
            {
            if (bb == i1 || bb == i2) Console.Write("*");
            else Console.Write(" ");
            i2++;
            }                             
            System.Console.WriteLine("*");
            
            }
            for (int bb = 0; bb < 16; bb++)
            {
            Console.Write("*");
            }  
            System.Console.WriteLine("\n");
            System.Console.WriteLine("\n");
            // прямоуголный триуголник   
            int m=15;
             char pathChar='*';
             char entireChar=' ';
             for(int i=0;i<m;i++)
             {
                 for(int j=0;j<=i;j++)
                 {
                     if(i!=m-1)
                         Console.Write(j==0 || j==i?pathChar:entireChar);
                     else
                         break;
                 }
                 Console.WriteLine(i==m-1?new string(pathChar,m):"");
             }       
                System.Console.WriteLine("\n");
                 System.Console.WriteLine("\n");

            //  равностароный триуголник
                 int g = 26;
                 int z = 2;
                for (int v = 0; v < 8; v++)
                    {
                        if (v==4) continue;
                for (int jm = 0; jm < 52; jm++)
                {
                    Console.Write(" ");
                    if (jm == g)
                    {
                        for (int s = 0; s < z; s++)
                        
                     Console.Write("*");
                    }
                }
                g = g - 1;
                z = z + 2;
                Console.WriteLine();
                }
                System.Console.WriteLine("\n");
                System.Console.WriteLine("\n");
                //  Ромб 
             var h = 10;
             h = h % 2 == 0 ? h + 1 : h;
             
             
             Console.WriteLine("{0}{1}", new string(' ', h/2), '*');
             for (var i = 1; i < h - 1; i++)
             {
             var spacesBefore = Math.Abs(h / 2 - i);
             var spacesIn = h - 2 * spacesBefore - 2;
             Console.WriteLine("{0}{1}{2}{1}", new string(' ', spacesBefore), '*', new string(' ', spacesIn));
             }
             Console.WriteLine("{0}{1}", new string(' ', h/2), '*');
             Console.Read(); 
             System.Console.WriteLine("\n"); 
             System.Console.WriteLine("\n"); 
             Console.ReadLine();
            
            // Задание 3
            double proc;
            Console.WriteLine("Введите процент по вкладу(>0 <25) :");
            proc = Convert.ToDouble(Console.ReadLine());
            if (proc < 0 || proc > 25)
            {
                Console.WriteLine("Нереальный процент :)");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double deposit = 1000;
            int count = 0;
            while (deposit < 1100)
            {
                deposit += deposit * proc/100;
                count++;
            }
            Console.WriteLine("До превышения лимита вклада на сумму 1100с. понадобится: {0} месяца \n сумма вклада составит: {1} с.", count, deposit);
            Console.ReadKey();
         
    }
}
