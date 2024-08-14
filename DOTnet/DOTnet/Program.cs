internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //System.Console.ReadKey();
        //System.Console.Clear();
        //Console.WriteLine("Welcome");
        //System.Console.ReadKey();



        //int num = 10;
        //Console.WriteLine(num);

        //sbyte a = 10;
        //byte b = 20;
        //short c = 30;
        //ushort d = 40;
        //int f = 50;
        //uint g = 60;
        //long h = 70;
        //ulong i = 80;
        //float j= 10.23f;
        //double k = 100.234234;
        //decimal l = 110.2342324M;


        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //Console.WriteLine(f);
        //Console.WriteLine(g);
        //Console.WriteLine(h);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(k);
        //Console.WriteLine(l);


        //uint min = uint.MinValue;
        //uint max = uint.MaxValue;

        //Console.WriteLine(min);
        //Console.WriteLine(max);


        //char ch = 'A';
        //Console.WriteLine(ch);
        // string str = "Hello 1562bk";
        //Console.WriteLine(str);


        //bool isadult = true;
        //Console.WriteLine(isadult);



        //****Operators*****//

        //int num1 = 35;
        //int num2 = 20;
        //Console.WriteLine(num1 + num2);
        //Console.WriteLine(num1 - num2);
        //Console.WriteLine(num1 * num2);
        //Console.WriteLine(num1 / num2);
        //Console.WriteLine(num1%3);

        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num1 *= num2);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num1 %= 3);

        //int x = 10, y = 20, z = 10;
        //bool results1 = ((x == y) && (y == z));
        //Console.WriteLine(results1);
        //bool results2 = ((x == y) || (y<z));
        //Console.WriteLine(results2);
        //bool result3 = !results1;
        //Console.WriteLine(result3);


        //string str1 = "Good Mornig";
        //string str2 = "Welcome";
        //Console.WriteLine(str1+ " " + str2);

        //int num = 10;
        // Console.WriteLine(str1 + num);

        //int num = 13;
        //string result = ((num % 2 == 0) ? "Even" : "Odd");
        //Console.WriteLine(result);

        //int num = 21;
        //if (num % 2 == 0)
        //{
        //    Console.WriteLine(num + " is even num");
        //}
        //else
        //{
        //    Console.WriteLine(num + " is odd num");
        //}



        //int year = int.Parse(Console.ReadLine());
        //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //{
        //    Console.WriteLine(year + " is leap num");
        //}
        //else
        //{
        //    Console.WriteLine(year + " is not a leap num");
        //}


        //int marks = 70;

        //if(marks >= 75)

        //{
        //    Console.WriteLine("Distinction");
        //}
        //else if(marks >= 60 && marks < 75)
        //{
        //    Console.WriteLine("Second Class");
        //}
        //else if (marks >= 35 && marks < 05)
        //{
        //    Console.WriteLine("Third Class");
        //   else
        //{
        //    Console.WriteLine("Fail");
        //}
        //}

        //int num1 = 110, num2 = 320, num3 = 230;

        //int largest;

        //if (num1 >= num2 && num1 >= num3)
        //{
        //    largest = num1;
        //}
        //else if (num2 >= num1 && num2 >= num3)
        //{
        //    largest = num2;
        //}
        //else
        //{
        //    largest = num3;
        //}
        //Console.WriteLine("The Largest of Three Numbers is" + largest);

        //    string monthname = "";
        //    int monthno = 7;

        //    switch (monthno)

        //    {
        //    case 1: monthname = "Jan"; break;
        //    case 2: monthname = "Feb"; break;
        //    case 3: monthname = "March"; break;
        //    case 4: monthname = "April"; break;
        //    case 5: monthname = "MAy"; break;
        //    case 6: monthname = "June"; break;
        //    case 7: monthname = "July"; break;
        //    case 8: monthname = "Aug"; break;
        //    case 9: monthname = "Sep"; break;
        //    case 10: monthname = "Oct"; break;
        //    case 11: monthname = "Nov"; break;
        //    case 12: monthname = "Dec"; break;
        //        default: monthname = "Wrong Month Entered"; break;

        //}
        //    Console.WriteLine(monthname);



        ////FACTORIAL OF A NUMBER
        //Console.WriteLine("Enter the number :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int fact = 1;
        //int temp = num;
        //while (num > 1)
        //{
        //    fact = fact * num;
        //    num--;

        //}
        //Console.WriteLine("Factorial of  " + temp + "  is  :" + fact);


        //int m = 1;
        //int sumofodds = 0;
        //do
        //{
        //    if (m % 2 == 0)
        //    {
        //        sumofodds += m;
        //    }
        //    m++;
        //}
        //while (m < 100);
        //Console.WriteLine("Sum of Odd numbers Between 1 to 100"+ " "+ sumofodds);

        //int sumofnum = 0;
        //for(int i =0;i<100;i++)
        //{
        //    if(i%10==0)
        //    {
        //        sumofnum++;
        //    }
        //}
        //Console.WriteLine(sumofnum);


        //int num1 = 6;
        //int fact = 1;
        //for(int i = num1;i>1;i-- )
        //{
        //    fact *= i;
        //}
        //Console.WriteLine(fact);

        //int num = 64351;
        //int num1 = 0;
        //int sum = 0;
        //while(num>0)
        //{
        //    num1 = num % 10;
        //    sum += num1;
        //    num =  num/10;

        //}

        //Console.WriteLine(sum);





        int num1 = int.Parse(Console.ReadLine());
        bool isPrime = true;



        for (int i = 2; i < num1; i++)
        {
            if (num1 % i == 0)
            {
                isPrime = false;
                break;
            }
        }


        if (isPrime)
        {
            Console.WriteLine(num1 + " is a prime number");
        }
        else
        {
            Console.WriteLine("lol you are wrong");
        }
    }
}

