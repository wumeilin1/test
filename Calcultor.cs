using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2_8
{
    class Calcultor
    {
        public string a;
        public string b;
        public string c;
        public int e;
        public int f;
        public void setmessage()
        {
            Console.WriteLine("请输入第一个数字或字符串：");
            a = Console.ReadLine();
            Console.WriteLine("请输入运算符（+ - * /） ：");
            c = Console.ReadLine();
            Console.WriteLine("请输入第二个数字或字符串：");
            b = Console.ReadLine();
        }
        public void getmessage()
        {
            int d = 0;
            if (int.TryParse(a, out d) && int.TryParse(b, out d))
            {
               e = int.Parse(a);
               f = int.Parse(b);
               jisuan();
            }
            else
                Connection();
        }
        public void Connection()
        {
            string d;
            if (c == "+")
            {
                d = a + b;
                Console.WriteLine(a + c + b + '=' + d);
            }
            else if (c == "-")
            {
                d = a.Replace(b, "");
                Console.WriteLine(a + c + b + '=' + d);
            }
        }
        public void jisuan()
        {
            float d;
            if (c == "+")
            {
                d = e + f;
                Console.WriteLine(a + c + b + '=' + d);
            }
            else
                if (c == "-")
                {
                    d = e - f;
                    Console.WriteLine(a + c + b + '=' + d);
                }
             else
                if (c == "*")
                 {
                     d = e * f;
                     Console.WriteLine(a + c + b + '=' + d);
                  }
             else
                 if (c == "/")
                  {
                      d = e / f;
                      Console.WriteLine(a + c + b + '=' + d);
                  }
             else
                  Console.WriteLine("符号输入错误");
        }
    }
}
