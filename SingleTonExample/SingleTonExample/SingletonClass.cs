using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonExample
{
    public sealed class SingletonClass
    {
        private int count = 0;

        private static SingletonClass instance = null;
        public static SingletonClass getinstance
        {
            get
            {
                if (instance == null)
                {
                    instance= new SingletonClass();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
        private SingletonClass()
        {
            count = count++;
        }
        public  void print(string letters)
        {
            Console.WriteLine(count);
            Console.WriteLine(letters);
        }
    }
}
