using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write(value: "Enter a number : ");
            //int Number = int .Parse(Console.ReadLine());

            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("Yes"); //Enter a number: : 12 Yes
            //}
            //else 
            //{
            //    Console.WriteLine("NO"); //Enter a number: : 9 NO
            //}

            #endregion

            #region Q2

            // 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write(value: "Enter a number : ");
            //int Number = int .Parse(Console.ReadLine());


            //if (Number <0)
            //{
            //    Console.WriteLine("Negative"); //Enter a number: : -5 Negative
            //}
            //else 
            //{
            //    Console.WriteLine("Positive"); //Enter a number: : 2 Positive
            //}

            #endregion

            #region Q3

            //3.Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.Write(value: " Enter The First Integer:  ");
            //int Num1 = int.Parse(Console.ReadLine());

            //Console.Write(value: " Enter The Second Integer:  ");
            //int Num2 = int.Parse(Console.ReadLine());

            //Console.Write(value: " Enter The Third Integer:  ");
            //int Num3 = int.Parse(Console.ReadLine());

            //int Maxelement = Math.Max(Num1, Math.Max(Num2, Num3));
            //int Minelement = Math.Min(Num1, Math.Min(Num2, Num3));

            //Console.WriteLine("The Maximum Number is: " + Maxelement);
            //Console.WriteLine("The Minimum Number is: " + Minelement);

            //EX01
            // Enter The First Integer:  7
            // Enter The second Integer:  8
            // Enter The third Integer:  5
            // The Maximum Number is: 8
            // The Minimum Number is: 5

            //EX02
            // Enter The First Integer:  3
            // Enter The second Integer:  6
            // Enter The third Integer:  9
            // The Maximum Number is: 9
            // The Minimum Number is: 3

            #endregion

            #region Q4

            //4.Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter an Integer: ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 2 == 0)
            //{
            //    Console.WriteLine("The Number is Even."); //Enter an Integer: 8 The Number is Even.
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Odd."); //Enter an Integer: 5 The Number is Odd.
            //}

            #endregion

            #region Q5

            //5.Write a program that takes character from the user then if it is a vowel chars
            //(a,e,I,o,u) then print (vowel) otherwise print (consonant).

            // char Character;
            // bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Character");
            //    flage = char.TryParse(Console.ReadLine().ToLower(), out Character);

            //} while (!flage);

            //switch (Character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'u':
            //    case 'i':
            //    case 'o':
            //        Console.WriteLine("Vowel"); // a => Vowel
            //    break;
            //    default:
            //        Console.WriteLine("consonant");// z => consonant
            //    break;

            //}

            #endregion

            #region Q6 

            //6. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //int Number;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    flage = int.TryParse(Console.ReadLine(), out Number);

            //} while (!flage);

            //for (int i= 1; i <= Number; i++)
            //Console.WriteLine(i); //5 => 1,2,3,4,5

            #endregion

            #region Q7  

            //7.Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //int Number;
            //bool flage;

            //do
            //{

            //    Console.WriteLine("Enter Number");
            //    flage = int.TryParse(Console.ReadLine(), out Number);

            //} while (!flage);

            //for (int i = 1; i <=12; i++)
            //Console.WriteLine($"{i} * {Number} = {i*Number}");

            //Enter Number 5
            //1 * 5 = 5
            //2 * 5 = 10
            //3 * 5 = 15
            //4 * 5 = 20
            //5 * 5 = 25
            //6 * 5 = 30
            //7 * 5 = 35
            //8 * 5 = 40
            //9 * 5 = 45
            //10 * 5 = 50
            //11 * 5 = 55
            //12 * 5 = 60

            #endregion

            #region Q8 

            //8. Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //int Number;
            //bool flage;

            //do
            //{

            //    Console.WriteLine("Enter Number");
            //    flage = int.TryParse(Console.ReadLine(), out Number);

            //} while (!flage);
            //if (Number > 0)
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        if (i % 2 == 0)
            //        Console.WriteLine(i);

            //    }
            //}
            //else if (Number < 0)
            //{
            //    for (int i = Number; i <= 1; i++)
            //    {
            //        if (i % 2 == 0)
            //        Console.WriteLine(i);

            //    }

            //}

            //Enter Number 15
            //2
            //4
            //6
            //8
            //10
            //12
            //14

            #endregion

            #region Q9 

            //9. Write a program that takes two integers then prints the power.

            //int Integers;
            //bool Flage1;

            //do
            //{

            //    Console.WriteLine("Enter Number Base");
            //    Flage1 = int.TryParse(Console.ReadLine(), out Integers);


            //} while (!Flage1);
            //int power;
            //bool flage2;
            //double result = 1;
            //do
            //{

            //    Console.WriteLine("Enter Number Power");
            //    flage2 = int.TryParse(Console.ReadLine(), out power);


            //} while (!flage2);

            //if (power > 0)
            //{
            //    for (int i = 0; i < power; i++)
            //    {
            //        result *= Integers;
            //    }
            //    Console.WriteLine($"{Integers} ^ {power} = {result}");

            //}
            //else if (power < 0)
            //{
            //    for (int i = power; i < 0; i++)
            //    {
            //        result *= Integers;
            //    }
            //    Console.WriteLine($"{Integers} ^ {power} = {1 / result}");

            //}
            //else
            //    Console.WriteLine($"{Integers} ^ {power} = 1");

            ////enter number base 4
            ////enter number power 3
            ////4 ^ 3 = 64

            #endregion

            #region Q10 

            //10.Write a program to enter marks of five subjects and calculate total, average and percentage


            //double Total = 0, Avg, Percentage = 0;

            //int Count = 0;
            //double subject;
            //while (Count < 5)
            //{
            //    Console.WriteLine($"Enter Mark Of Subject {Count + 1}");
            //    bool flage = double.TryParse(Console.ReadLine(), out subject);

            //    if (flage && (subject >= 0 && subject <= 100))
            //    {
            //        Total += subject;
            //        Count++;

            //    }
            //    else
            //        Console.WriteLine("Not Valid Mark");
            //}

            //Avg = Total / 5;
            //Percentage = (Total * 100) / 500;

            //Console.WriteLine($"Total marks = {Total}");
            //Console.WriteLine($"Average Marks  = {Avg}");
            //Console.WriteLine($"Percentage = {Percentage} %");

            //Enter Mark Of Subject 1
            //95
            //Enter Mark Of Subject 2
            //76
            //Enter Mark Of Subject 3
            //58
            //Enter Mark Of Subject 4
            //90
            //Enter Mark Of Subject 5
            //89
            //Total = 408
            //Avg = 81.6
            //Percentage = 81.6 %

            #endregion

            #region Q11

            //11. Write a program to input the month number and print the number of days in that month.

            //int Month;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Month Number : ");
            //    flage = int.TryParse(Console.ReadLine(), out Month);
            //} while (!flage);
            //switch (Month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month : 31");
            //        break;

            //    case 2:
            //        Console.WriteLine("Days in Month : 28");
            //        break;
            //    default:
            //        Console.WriteLine("Days in Month : 30");
            //        break;
            //}
            //Month Number : 1
            //Days in Month : 31

            #endregion

            #region Q12

            //12.Write a program to create a Simple Calculator.

            //int Number1;
            //bool flage1;

            //do
            //{
            //    Console.WriteLine("Enter Number1 : ");
            //    flage1 = int.TryParse(Console.ReadLine(), out Number1);
            //} while (!flage1);

            //char OP;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Operator : ");
            //    flage = char.TryParse(Console.ReadLine(), out OP);
            //} while (!flage);

            //int Number2;
            //bool flage2;

            //do
            //{
            //    Console.WriteLine("Enter Number2 : ");
            //    flage2 = int.TryParse(Console.ReadLine(), out Number2);
            //} while (!flage2);

            //switch (OP)
            //{
            //    case '+':
            //        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 + Number2}");
            //    break;

            //    case '-':
            //        Console.WriteLine($"{Number1} {OP} {Number2}  = {Number1 - Number2}");
            //    break;

            //    case '*':
            //        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 * Number2}");
            //    break;

            //    case '/':
            //        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 / Number2}"); 
            //    break;

            //    default:
            //        Console.WriteLine("Invalid");
            //    break;
            //}

            //    //Enter Number1 : 4200
            //    //Enter Operator : +
            //    //Enter Number2 : 3600
            //    //4200 + 3600 = 7800

            #endregion

            #region Q13 

            //13. Write a program to allow the user to enter a string and print the REVERSE of it.

            //string Text;
            //Console.WriteLine("Enter A string : ");
            //Text = Console.ReadLine();

            //for (int i = Text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Text[i]);
            //}

            ////Enter A string : Menna
            ////anneM

            #endregion

            #region Q14 

            //14. Write a program to allow the user to enter int and print the REVERSED of it.  

            //int Number;
            //bool flage;
            //int Result = 0;

            //do
            //{
            //    Console.WriteLine("Enter Number : ");
            //    flage = int.TryParse(Console.ReadLine(), out Number);
            //} while (!flage);

            //while (Number > 0)
            //{
            //    int Remainder = Number % 10; 
            //    Result = (Result * 10) + Remainder; 
            //    Number = Number / 10; 
            //}
            //Console.WriteLine($"Reversed Number : {Result}");

            //    //Enter Number : 543
            //    //Reversed Number : 345

            #endregion

            #region Q15 

            //15. Write a program in C# Sharp to find prime numbers within a range of numbers.

            //int Start;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Number : ");
            //    flage = int.TryParse(Console.ReadLine(), out Start);
            //} while (!flage);

            //int End;
            //bool flage2;

            //do
            //{
            //    Console.WriteLine("Enter Number : ");
            //    flage2 = int.TryParse(Console.ReadLine(), out End);
            //} while (!flage2);

            //for (int i = Start; i <= End; i++)
            //{
            //    int count = 0;
            //    for (int U = 2; U < i; U++)
            //    {
            //        if (i % U == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    if (count == 0 & i != 1)
            //        Console.WriteLine(i);
            //}

            //Enter Number : 1
            //Enter Number : 50
            //2
            //3
            //5
            //7
            //11
            //13
            //17
            //19
            //23
            //29
            //31
            //37
            //41
            //43
            //47


            #endregion

            #region Q16 

            //16. Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //int Number;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter a number to convert : ");
            //    flage = int.TryParse(Console.ReadLine(), out Number);
            //} while (!flage);

            //string Result = " ";


            //for (int i = 0; Number > 0; i++)
            //{                 
            //    Result = (Number % 2) + Result; 
            //    Number /= 2;
            //}
            //Console.WriteLine(Result);

            //    //Enter a number to convert: 25
            //    //11001

            #endregion

            #region Q17 

            //17.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            //and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter he coordinates of the first point (x1, y1):");

            //double x1 = GetCoordinate("x1");
            //double y1 = GetCoordinate("y1");

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double x2 = GetCoordinate("x2");
            //double y2 = GetCoordinate("y2");

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double x3 = GetCoordinate("x3");
            //double y3 = GetCoordinate("y3");

            //double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}
            //static double GetCoordinate(string name)
            //{
            //    Console.Write($"Enter {name}: ");
            //    return Convert.ToDouble(Console.ReadLine());
            //}

            //Enter he coordinates of the first point(x1, y1):
            //Enter x1: 1
            //Enter y1: 2
            //Enter the coordinates of the second point(x2, y2):
            //Enter x2: 3
            //Enter y2: 4
            //Enter the coordinates of the third point(x3, y3):
            //Enter x3: 5
            //Enter y3: 6
            //The points lie on a straight line.

            //Enter he coordinates of the first point(x1, y1):
            //Enter x1: 8
            //Enter y1: 3
            //Enter the coordinates of the second point(x2, y2):
            //Enter x2: 23
            //Enter y2: 45
            //Enter the coordinates of the third point(x3, y3):
            //Enter x3: 32
            //Enter y3: 67
            //The points do not lie on a straight line.

            #endregion

            #region Q18

            //18. Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
            //A worker's efficiency level is determined as follows: 
            //- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

                    //Console.Write("Enter the time taken to complete : ");
                    //double time = Convert.ToDouble(Console.ReadLine());

                    //if (time >= 2 && time <= 3)
                    //{
                    //    Console.WriteLine("Highly efficient.");//Enter the time taken to complete : 3 Highly efficient.
                    //}
                    //else if (time > 3 && time <= 4)
                    //{
                    //    Console.WriteLine("Increase your speed.");//Enter the time taken to complete : 4 Increase your speed.
                    //}
                    //else if (time > 4 && time <= 5)
                    //{
                    //    Console.WriteLine("You need training to improve your speed.");//Enter the time taken to complete : 5 You need training to improve your speed.
                    //}
                    //else if (time > 5)
                    //{
                    //    Console.WriteLine("You are required to leave the company.");//Enter the time taken to complete : 6 You are required to leave the company.
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Invalid input! Time must be 2 hours or more.");//Enter the time taken to complete : 1 Invalid input!Time must be 2 hours or more.
                    //}

            #endregion


        }
    }
}
