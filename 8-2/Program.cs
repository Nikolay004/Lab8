using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText(@"D:\Work\2\Lab8-2.txt");//а помощи метода File.CreateText создали файл                                                                        
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100)); //Записываем случайные числа в наш файл
                    
                }
                sw.Close();
            }
            int sum = File.ReadAllLines(@"D:\Work\2\Lab8-2.txt").Sum(x => int.Parse(x));
            Console.WriteLine(sum);            
        }
    }
}
