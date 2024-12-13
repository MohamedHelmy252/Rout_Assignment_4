using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4
{
    internal class Program
    {





        //Function Q2
        public static void Efficiency(float NumberOfHours)
        {



            if (NumberOfHours >= 2 && NumberOfHours <= 3)
            {
                Console.WriteLine(" worker is highly efficient.");
            }
            else if (NumberOfHours > 3 && NumberOfHours <= 4)
            {
                Console.WriteLine(" worker will instructed to increase their speed.");
            }
            else if (NumberOfHours > 4 && NumberOfHours <= 5)
            {
                Console.WriteLine("worker will  provided with training to enhance their speed. ");
            }
            else if (NumberOfHours > 5)
            {
                Console.WriteLine("worker will required to leave the company.");
            }
            else { Console.WriteLine( "Enter Correct  Value"); }
        
        
        }


        //Q Functons
        #region Functions 

        #region Q1
        //1 Value
        public static void SwapByValue(int x , int y)
        {
            int temp = x;
            x = y;
            y=temp; 
        }
        //2 Reference
        public static void SwapByReference(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y=temp;  

        }

        #endregion
        #region Q3
        public static void SumSub(int a, int b, int c, int d, out int sum, out int sub)
        { 
            sum = a+b+c+d;
            sub = (a + b) - (c + d);
        
        }

        #endregion
        #region 4 Function 
        public static void SuMDigit(string num)
        {
 
        }



        #endregion
        #region 5 Function 
        public static void IsPrime(int num)
        {

            if (num != 2 && num != 3 && num > 3)
            {
                if (num % 2 == 0 || num % 3 == 0)
                {
                    Console.WriteLine($"Num {num} : Is  Not Prime");
                }
                else
                {
                    Console.WriteLine($"Num {num} : Is Prime");
                }

            }
            else if (num == 2 || num == 3)
            {
                Console.WriteLine($"Num {num} : Is Prime");
            }
            else
            {
                Console.WriteLine($"Num {num} : Is Not Prime");
            }


        }

        #endregion
        #region 6 Function 
        public static void MinMaxArray(ref int max ,ref int min , int[]arr )
        {
        max=arr[0];
        min=arr[0];

            for (int i = 0; i < arr.Length; i++)
            {

                if (max < arr[i])
                { 
                max=arr[i]; 
                }

                if (min > arr[i])
                { 
                min=arr[i]; 
                }

            }
            Console.WriteLine($"Max : {max}  Min = {min}");
        }
        #endregion
        #region  7 Function
        public static void Fact(int Num)
        {
            int fact = 1;
            for (int i = 1; i <= Num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Fact OF ({Num}) : {fact}");

        }
        #endregion
        #region 8 Function 
        public static void ChangeChar(string Text,char Value, int index)
        {
          StringBuilder text= new StringBuilder();  
            text.Append(Text);
            text[index] = Value;
            Console.WriteLine($"Old Text = {Text}  Set Char : {Value}  In Index : {index} After Alter Text = {text} ");
        
        }

        #endregion







        #endregion


        static void Main(string[] args)
        {

            #region Q1

            //----------------------Solution----------------------


            #endregion
            #region Q2

            //2 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            //  //- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //  //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //  //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.


            //----------------------Solution----------------------

            //Console.Write("Enter Number OF Hours It Take : ");
            //float NumberOfHours ;
            //bool flag=float.TryParse(Console.ReadLine(),out NumberOfHours);
            //if (flag == true)
            //{
            //    Efficiency(NumberOfHours);
            //}


            #endregion//k

            //**
            #region Q3
            //3 - .Write a program that prints an identity matrix using for loop,
            //    in other words takes a value n from the user and shows the identity table of size n * n.
            //----------------------Solution----------------------

            //Console.Write("Enter Size Of Matrix : ");
            //int Size;
            //bool flag=int.TryParse(Console.ReadLine(), out Size);
            //if (flag == true)
            //{
            //    int[,] array = new int[Size, Size];





            //}



            #endregion


            #region Q4

            //-Write a program in C# Sharp to find the sum of all elements of the array.
            //----------------------Solution----------------------

            //int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8 };//Syntax Suger
            //if (Array != null )
            //{
            //    int sum = 0;
            //    for (int i = 0; i < Array.Length; i++)
            //    {
            //        sum += Array[i];
            //    }
            //    Console.WriteLine($"Sum OF All Value OF Array = {sum}");

            //}




            #endregion


            #region Q 5
            //  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //----------------------Solution----------------------

            //int[] Array1 = { 2, 3, 4, 5, 0, 1 };
            //int[] Array2 = { 10, 29, 5, 3, 1, 20 };
            //if (Array1.Length == Array2.Length)
            //{
            //    int size = Array1.Length;
            //    int[] Merge = new int[size];

            //    for (int i = 0; i < size; i++)
            //    {
            //        Merge[i] = Array1[i] + Array2[i];
            //    }

            //    //Sort 
            //    Array.Sort(Merge);
            //    //Print
            //    foreach (int i in Merge)
            //    {
            //        Console.Write(i+" ");
            //    }
            //}




            #endregion

            //**
            #region Q 6

            //- Write a program in C# Sharp to count the frequency of each element of an array.
            //----------------------Solution----------------------
            //int[] Array = { 1, 2, 3, 3, 2, 3, 5, 6, 7 };
            //List<int> list = new List<int>();


            //if (Array != null)
            //{
            //    int number=0;
            //    for (int i = 0; i < Array.Length; i++)
            //    {

            //        for (int j = 0; j < Array.Length; j++)
            //        { 


            //        }

            //    }



            //}



            #endregion


            #region Q 7

            // Write a program in C# Sharp to find maximum and minimum element in an array
            //----------------------Solution----------------------
            //int[] array = { 1, 2, 34, 5, 60, 0, 100 };
            //int max=array[0];
            //int min=array[0];
            //if (array != null)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (max < array[i])
            //        {
            //            max = array[i];
            //        }
            //        if (min > array[i])
            //        {
            //            min = array[i];
            //        }
            //    }
            //    Console.WriteLine($"Max = {max}  ,  Min = {min}");
            //}


            #endregion


            #region Q 8
            // Write a program in C# Sharp to find the second largest element in an array.
            //----------------------Solution----------------------
            //int[] array = { 1, 2, 3, 4,90, 5, 6, 7, 8, 9 };
            //if (array != null)
            //{

            //    int SecondMAx=array[0];
            //    Array.Sort(array);
            //    SecondMAx = array[array.Length - 2];

            //    Console.WriteLine($"SecondMax : {SecondMAx}");

            //}

            #endregion


            #region Q 7
            // Write a program in C# Sharp to find the second largest element in an array.
            //----------------------Solution----------------------
            //int[] array = { 1, 2, 3, 4, 90, 5, 6, 7, 8, 9 };
            //if (array != null)
            //{

            //    int SecondMAx = array[0];
            //    Array.Sort(array);
            //    SecondMAx = array[array.Length - 2];

            //    Console.WriteLine($"SecondMax : {SecondMAx}");

            //}

            #endregion

            //**
            #region Q 8

            //----------------------Solution----------------------


            #endregion

            #region Q 27
            // 27 - Write a program to create two multidimensional arrays of same size.
            // Accept value from user and store them in first array.
            // Now copy all the elements of first array on second array and print second array.
            //----------------------Solution----------------------


            //int size=0;
            //Console.Write("Enter Size OF Array : ");
            //bool flag=int.TryParse(Console.ReadLine(), out size);
            //int[] a1 = new int[size];
            //int[] a2 = new int[size];
            //if (flag = true)
            //{
            //    //Assign Vale in A1
            //    Console.WriteLine("Enter Element In Array 1 : ");
            //    for (int i = 0; i < a1.Length; i++)
            //    {
            //        Console.Write($"Enter ELement Of Index ({i}) : ");
            //    a1 [i] = int.Parse(Console.ReadLine());     
            //    }
            //    a1.CopyTo(a2, 0);
            //    //Print a2
            //    Console.WriteLine("Print A2 : ");
            //    foreach (int i in a2)
            //    {
            //        Console.Write(i+" ");
            //    }    




            //}



            #endregion


            #region Q 28
            //28-Write a Program to Print One Dimensional Array in Reverse Order
            //----------------------Solution----------------------
            //int[] a = { 1,2,3,4,5,6,7,8,9,10};

            //if (a != null)
            //{
            //    for (int i = a.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(a[i] + " ");//10 9 8 7 6 5 4 3 2 1
            //    }
            //}


            #endregion

            #region Functons 




            #region Q1 Function
            //1-Explain the difference between passing
            //(Value type parameters) by value and by reference
            //then write a suitable c# example.
            //----------------------Solution----------------------

            //1-Passing By Value => When Function Work on Alocal Varaible 
            //And Happen Change in Function (The Value Not Change)

            //2-Passing By Reference => When Function Work on Alocal Varaible 
            //And Happen Change in Function (The Value Change in the memory)


            //The Example Is Function Swap : 
            //int x=5 , y=10;
            //Console.WriteLine($"x = {x} , y = {y} ");
            //Console.WriteLine("================================");
            //SwapByValue(x, y); Console.WriteLine("SWaping");
            //Console.WriteLine("================================");
            //Console.WriteLine($"x = {x} , y = {y} ");
            //Console.WriteLine("================================");

            //Console.WriteLine("================================================================");
            //Console.WriteLine("Passing By Reference : ");

            //int a=5 ;
            //int b=10;
            //Console.WriteLine($"x = {a} , y = {b} ");
            //Console.WriteLine("================================");
            //SwapByReference(ref a,ref b); Console.WriteLine("SWaping");
            //Console.WriteLine("================================");
            //Console.WriteLine($"x = {a} , y = {b} ");
            //Console.WriteLine("================================");



            #endregion
            #region Q3 Function
            // 3 - Write a c# Function that accept 4 parameters from user 
            //     and return result of summation and subtracting of two numbers

            //----------------------Solution----------------------

            ////Solutin by use  (Call By Out)
            //int sum , sub;
            //SumSub(40, 30, 20, 10, out sum,out sub);
            //Console.WriteLine($"Sum = {sum}  Sub = {sub}");



            #endregion
            #region Q4 Function *****
            //4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            //----------------------Solution----------------------

            #endregion
            #region Q5 Function 
            //5-Create a function named "IsPrime", which receives an integer
            //number and retuns true if it is prime, or false if it is not:
            //----------------------Solution----------------------

            //int x;
            //Console.Write("Enter Number : ");
            //x=int.Parse(Console.ReadLine());    

            //IsPrime(x);
            #endregion
            #region Q6 Function
            // 6 - Create a function named MinMaxArray,
            // to return the minimum and maximum values stored in an array,
            //  using reference parameters

            //----------------------Solution----------------------
            //int[] array = { 2,3,5,6,2,1,100};
            //int max = 0;
            //int min = 0;
            //Console.WriteLine($"max , min Befor Function =max={max} , min={min}");
            //MinMaxArray(ref max,ref min,array);
            //Console.WriteLine($"max , min After Function =max={max} , min={min}");

            #endregion
            #region Q7 Function
            //1-Create an iterative (non-recursive) function to
            //calculate the factorial of the number specified as parameter

            //----------------------Solution----------------------

            //int num = 3;
            //Fact(num);



            #endregion




            #region Q7 Function
            //8-Create a function named "ChangeChar" to modify a letter in a
            //certain position (0 based) of a string, replacing it with a different letter

            //----------------------Solution----------------------
            string text = "ali";
            char value = 'S';
            int index = 0;
            ChangeChar(text,value,index);
            #endregion

            #region Q1 Function

            #endregion

            #region Q1 Function

            #endregion







            #endregion

        }
    }
}
