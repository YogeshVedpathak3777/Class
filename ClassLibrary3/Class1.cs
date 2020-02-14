using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        int a = 2;
        int b = 3;
        int c = 4;
        int add;
        int abc = 10;
         
        /// <summary>
        /// Addition of two numbers
        /// </summary>
        /// <returns></returns>
        public int Addition(int a , int b)
        {
            string result = string.Empty;

            add = a + b;

            return add;
        }

        public static void main (string[] args)
        {
            Class1 objclass = new Class1();
            {
                objclass.Addition(5,2);
            }
        }
    }
}
