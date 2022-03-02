// See https://aka.ms/new-console-template for more information
using System;

namespace console_programlama
{
      
      class Program
      {

          public static void Main(string[] args){

            Console.WriteLine("Hoşgeldin Witcher");
            Console.WriteLine("Adını söyle geçmene izin veriyim ?");
            string name = Console.ReadLine();
            Console.WriteLine("Son olarak nereden geldin "+ name + " ?");
            string country = Console.ReadLine();
            Console.WriteLine("Geçmene izin veriyorum " + country + "'lı " + name);

          }
      }
}
