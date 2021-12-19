using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
   public class Program
    {
        public delegate void GetAccess<T>(T name);
        static void Main(string[] args)
        {
            SingletonClass obj1 = SingletonClass.getinstance;
            obj1.print("fuck");

            SingletonClass obj2 = SingletonClass.getinstance;
            obj2.print("Bitch");

            GetAccess<string> newdel = new GetAccess<string>(Giveaccess);
            newdel += Giveaccess1;
            newdel("GOWTHAM");


            PermanentEmployee PM = new PermanentEmployee();
            PM.Age = 24;
            int Salary = PM.GetSalary();
        }

        public static void Giveaccess1(string a)
        {
            int a1 = 1;
            while(a1 <4)
            {

            }
        }

        public static void Giveaccess(string a)
        {
            int b = 0;
            do
            {
                b = b + 1;
            }
            while (b < 4);
        }
    }

}
      
    
 
    
    




    

