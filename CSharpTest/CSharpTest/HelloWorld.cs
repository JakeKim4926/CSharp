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
    class TestClass
    {
        public TestClass() { }
        public TestClass(int member) { this.member = member; }
        public int member;
        
    }

    class HelloWorld
    {
        static void refTest(ref int a, ref int b)
        {
            a = 3;
            b = 7;
        }

        static int sum (params int[] args)
        {
            int nSum = 0;
            foreach (int n in args)
            {
                nSum += n;
            }

            return nSum;
        }

        // 명명된 매개 변수
        static void person(string name, int age)
        {
            WriteLine($"name : {name}, age: {age}");
        }


        // out 키워드의 경우 ref와 동일하지만 
        // 따로 변수를 저장하지 않을 시 컴파일러가 에러 메시지 출력
        static void Main(string[] args)
        {
            //WriteLine("여러분, 안녕하세요? \n반갑습니다!");

            //int nNum = 4;
            //uint unLimit = 3000000000;

            //WriteLine($"test={nNum}, uintTest = {unLimit}");

            //string strHi = "hey, I miss you guys";

            //WriteLine(strHi);

            //object objNum = 7;
            //object objDouble = 3.141592;
            //object objString = "NO WAY";
            //object objBool = true;


            //WriteLine($"Object test =======\n{objNum}");
            //WriteLine($"{objDouble}");
            //WriteLine(objString);
            //WriteLine(objBool);

            //Console.WriteLine((int)test.NUM_0);
            //Console.WriteLine((int)test.NUM_1);
            //Console.WriteLine((int)test.NUM_2);
            //Console.WriteLine((int)test.NUM_3);
            //Console.WriteLine((int)test.NUM_4);
            //Console.WriteLine((int)test.NUM_5);
            //Console.WriteLine((int)test.NUM_6);
            //Console.WriteLine((int)test.NUM_7);

            //// Nullable
            //int? nA = null;

            //Console.WriteLine(nA);

            //// var
            //var varNum = 7;
            //var varDouble = 3.141592;
            //var varString = "NO WAY";
            //var varBool = true;

            //WriteLine($"Object test =======\n{varNum}");
            //WriteLine($"{varDouble}");
            //WriteLine(varString);
            //WriteLine(varBool);

            //// 서식 지정자 테스트
            //WriteLine("{0:D}", 2048);
            //WriteLine("{0:X}", 2048);
            //WriteLine("{0:N}", 123456789);
            //WriteLine("{0:F}", 123.456);
            //WriteLine("{0:E}", 123.456789);

            //DateTime dt = new DateTime(2024, 12, 31, 23, 59, 59);
            //WriteLine("{0}", dt);
            //// 문자열 보간
            //WriteLine($"{dt}");

            //// null 연산자
            //TestClass t1 = new TestClass(2);
            //TestClass t2 = new TestClass(4);

            //t1 = null;
            //int? nNullTest = null;
            //nNullTest = t1?.member;
            //WriteLine(nNullTest);
            //nNullTest = t2?.member;
            //WriteLine(nNullTest);

            //// for-each
            //int[] arr = new int[] { 0, 1, 2, 3, 4 };
            //foreach (int n in arr)
            //Console.Write(n + " ");
            //Console.WriteLine();

            //int nRefA = 1;
            //int nRefB = 2;

            //Console.WriteLine(nRefA);
            //Console.WriteLine(nRefB);

            //refTest(ref nRefA, ref nRefB);

            //Console.WriteLine(nRefA);
            //Console.WriteLine(nRefB);

            //Console.WriteLine(sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //person(age: 31, name: "Taek");
            //person(name: "Jake", age: 31);

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("사용법: HelloWorld.exe <이름>");
            //    return;
            //}

            //WriteLine("Hello, {0}!", args[0]);

            Console.WriteLine("사각형의 너비를 입력하세요");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine();

            int result = int.Parse(width) * int.Parse(height);

            Console.WriteLine($"사각형의 넓이는 : {result}");
            
        }
    }
}
