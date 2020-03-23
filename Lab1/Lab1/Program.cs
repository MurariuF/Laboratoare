using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        int x;
        void checkPrime()
        {
            Console.WriteLine("Introduceti un numar prim pentru primul program");
            string n = Console.ReadLine();
            int x = Int32.Parse(n);
            for (int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Nu este prim");
                    break;
                }
                else
                    Console.WriteLine("Este prim");
            }
                
        }

        void secondCheck()
        {
            Console.WriteLine("Introduceti un numar prim pentru al 2-lea program");
            string n = Console.ReadLine();
            int x = Int32.Parse(n);
            int i;
            if (x == 2 || x == 1)
            {
                Console.WriteLine("Este prim");
               
            }
            else
            {
                for(i=2; i <= (x/2); i+=2)
                {
                    if(x % i == 0)
                    {
                        Console.WriteLine("Nu este prim");
                        break;
                    }
                    else
                    Console.WriteLine("Este prim");
                }
            }         
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "fir principal";
            Program prog = new Program();
            Thread t1prog = new Thread(prog.checkPrime);
            Thread t2prog = new Thread(prog.secondCheck);
            t1prog.Name = "fir2";
            t1prog.Start();
            var timeWorking1 = DateTime.Now;
            Console.WriteLine(timeWorking1);
            while(t1prog.IsAlive)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                timeWorking1 = timeWorking1.Add(TimeSpan.FromSeconds(1));
                Console.WriteLine(timeWorking1);
            }
            //prog.checkPrime();
            t2prog.Name = "fir2";
            t2prog.Start();
            var timeWorking2 = DateTime.Now;
            Console.WriteLine(timeWorking2);
            while(t2prog.IsAlive)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                timeWorking2 = timeWorking2.Add(TimeSpan.FromSeconds(1));
                Console.WriteLine(timeWorking2);
            }
            //prog.secondCheck();
        }
    }
}
