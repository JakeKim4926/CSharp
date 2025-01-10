using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Console;

namespace CSharpTest
{
    enum test
    {
        NUM_0,
        NUM_1,
        NUM_2,
        NUM_3,
        NUM_4,
        NUM_5,
        NUM_6,
        NUM_7
    }
    class HelloWorld
    {
        static void Main(string[] args)
        {
            WriteLine("여러분, 안녕하세요? \n반갑습니다!");

            int nNum = 4;
            uint unLimit = 3000000000;

            WriteLine($"test={nNum}, uintTest = {unLimit}");

            string strHi = "hey, I miss you guys";

            WriteLine(strHi);

            object objNum = 7;
            object objDouble = 3.141592;
            object objString = "NO WAY";
            object objBool = true;

            
            WriteLine($"Object test =======\n{objNum}");
            WriteLine($"{objDouble}");
            WriteLine(objString);
            WriteLine(objBool);

            Console.WriteLine((int)test.NUM_0);
            Console.WriteLine((int)test.NUM_1);
            Console.WriteLine((int)test.NUM_2);
            Console.WriteLine((int)test.NUM_3);
            Console.WriteLine((int)test.NUM_4);
            Console.WriteLine((int)test.NUM_5);
            Console.WriteLine((int)test.NUM_6);
            Console.WriteLine((int)test.NUM_7);

            // Nullable
            int? nA = null;

            Console.WriteLine(nA);

            // var
            var varNum = 7;
            var varDouble = 3.141592;
            var varString = "NO WAY";
            var varBool = true;

            WriteLine($"Object test =======\n{varNum}");
            WriteLine($"{varDouble}");
            WriteLine(varString);
            WriteLine(varBool);

            // 서식 지정자 테스트
            WriteLine("{0:D}", 2048);
            WriteLine("{0:X}", 2048);
            WriteLine("{0:N}", 123456789);
            WriteLine("{0:F}", 123.456);
            WriteLine("{0:E}", 123.456789);

            DateTime dt = new DateTime(2024, 12, 31, 23, 59, 59);
            WriteLine("{0}", dt);
            // 문자열 보간
            WriteLine($"{dt}");

            if (args.Length == 0)
            {
                Console.WriteLine("사용법: HelloWorld.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
