using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringtasks
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(GetHalfString(" Hello,world"));
            //Console.WriteLine(GetHalfString(""));
            //Console.WriteLine(GetHalfString("A B C D"));



            //Console.WriteLine("ВВедите адрес э.почты");
            //var email = Console.ReadLine();
            //var index = email.IndexOf('@');
            //var mailBox = email.Substring(0, index);
            //var mailService = email.Substring(index + 1);
            //Console.WriteLine($"Ваш почтовый яшик {mailBox} находится на почтовом серисе {mailService}");

            Console.WriteLine("ВВедите символ");
            var sy = Console.ReadLine()[0];
            Console.WriteLine($"Код символа \'{sy}\':0x{Convert.ToString((int)sy, 16).ToUpper()}");


            Console.ReadKey();
        }
        static string GetHalfString(string fullstring)
        {
            var s = fullstring.Replace(" "," ");
            return s.Substring(fullstring.Length / 2);
        }
        static double ConvertCelsiumToFarenheith(double celsiumDegrees)
        {
            return celsiumDegrees * 1.8 + 32;
        


        }



    }
}
