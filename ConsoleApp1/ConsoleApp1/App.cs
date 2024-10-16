using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class App
    {
        public void Run()
        {
            //DemoVariable();
            DemoCondition();
            DemoSwitch();
            DemoArray();
        }

        private void DemoVariable()
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int sumresult = firstNumber + secondNumber;
            Console.WriteLine(sumresult);// print data to console

            float firstValue = 10.5f;
            float SecondValue = 1.0f;
            float sumValue = firstNumber + secondNumber;

            double firstGrade = 10d;
            double secondGrade = 8d;
            double sumGrade = firstNumber + secondNumber;
            Console.WriteLine(sumGrade);

            char character = 'a';
            Console.WriteLine(character);

            string message = "Welcome to c# programming";
            Console.WriteLine(message);
        }
        private void DemoAnonymousVariable()
        {
            //var is anonymous type
            var number = 20;
            var name = "Hello Bro";
            var grade = 10.5f;
            var amount = 1000.75d;
            var character = 'h';
            var information = "We are learning c# programming";
            
        }
        private void DemoConversion()
        {
            int number = 20;
            double value = number;//Convert double to int

            float point = number;
            int cvFloat = (int)point;


            string numberStr = "50";
            int num = int.Parse(numberStr);
            double v = double.Parse(numberStr);

            Console.WriteLine("cvDouble" + cvFloat);

        }
        private void DemoCondition()
        {
            int age = 30;
            if (age > 30)
            {
                Console.WriteLine("more than qualify to register for class");
            }
            else if (age > 20)
            {
                Console.WriteLine("qualify to register");
            }
            else if (age == 20)
            {
                Console.WriteLine("turn out you in able to register");
            }
            else
                Console.WriteLine("Sorry! your age below requirement");
        }
        private void DemoSwitch()
        {
            Console.Write("enter your score : ");
            string numberStr = Console.ReadLine();
            int choice = int.Parse(numberStr);
            switch (choice)
            {
                case 12: Console.WriteLine("Excellent"); break;
                case 11: Console.WriteLine("great"); break;
                case 10: Console.WriteLine("doing well"); break;
                case 9: Console.WriteLine("SurSdey"); break;
                case 8: Console.WriteLine("JomleabLea"); break;
                default: Console.WriteLine("JoubKneapelKroy"); break;
            }
        }
        private void DemoForLoop()
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60 };
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                Console.WriteLine("number : " + number);

            }

            Console.WriteLine("==========================");

            foreach (int num in numbers)
            {
                Console.WriteLine("number : " + num);
            }
            Console.WriteLine("===============While loop=============");
            int index = 0;
            while (index < numbers.Length)
            {
                int number = numbers[index];
                Console.WriteLine("number : " + number);
                index++;
            }
            Console.WriteLine("=============do-WhileLoop============");

            int secondIndex = 0;
            do
            {
                int number = numbers[secondIndex];
                Console.WriteLine("number : " + number);
                secondIndex++;
            }while (secondIndex < numbers.Length);
        }
        private void DemoArray()
        {
            string [] names = new string [5];
            names[0] = "BroSiS";
            names[1] = "SiSBRo";
            names[2] = "HelloWorld";
            names[3] = "Array";
            names[4] = "Namespace";

            int[] ages = {10 ,20 , 30 };

            Console.WriteLine("name : " + names[0]);
            Console.WriteLine("age : " + ages[1]);

            Console.WriteLine("names length : " + names.Length);
            Console.WriteLine("age length : " + ages.Length);
    }
}
