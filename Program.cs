using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE490_1
{
   //Debug Mode
    //Releas Mode
 
    class Program
    {
        static void Main(string[] args)        {


            Console.WriteLine("Enter yor name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter yor salary:");
            int salary = int.Parse(Console.ReadLine()); //Casting
            DateTime e = DateTime.Now;

            Console.WriteLine("Enter yor Birthday: ");
           int x= int.Parse( Console.ReadLine());
           int xx = e.Year - x;


           ;

            

           

            Console.WriteLine("welcom  yor name:{0}  yor salary:{1}  yor age{2}  ", name, salary, xx);


                               
                              
                           

            
            System.Console.ReadKey();

           

        }
    }
}
