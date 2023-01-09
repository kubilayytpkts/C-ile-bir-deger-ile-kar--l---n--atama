using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            



            Hashtable hashtabledeger = new Hashtable();

            do
            {
               
                Console.WriteLine("eklemek istediğiniz değeri yazınız");
                Console.Write("ENG:");
                String engdeger = Console.ReadLine();
                bool sorgulama = hashtabledeger.ContainsKey(engdeger);
                Console.Clear();
                if (sorgulama)
                {
                    Console.WriteLine("Girmiş olduğunuz değer {0} karşılığı  listede {1} bulunmaktadır", engdeger, hashtabledeger[engdeger].ToString());
                }
                else
                {
                    Console.WriteLine("Lütfen girmiş oldugunuz {0}degerin karşılıgını giriniz", engdeger);
                    Console.Write("{0} değerinizin karşılığı=",engdeger);
                    string trdeger = Console.ReadLine();
                    hashtabledeger.Add(engdeger, trdeger);
                    Console.Clear();
                }

                Console.WriteLine("girmiş oldugunuz degerler başarıyla eklenmiştir");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("yeni değer eklemek istiyor musunuz E/H");
                
                
            } while (Console.ReadLine().ToUpper() != "H");

            foreach(var item in hashtabledeger.Keys)
            {
                Console.WriteLine("{0} değerinizin karşılığı= {1}", item, hashtabledeger[item]);
            }

            Console.ReadLine();

        }   
    }
}
