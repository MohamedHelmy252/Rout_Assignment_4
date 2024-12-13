using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace session_4
{
    internal class Program
    {

        public static void Print(string Pattern = "/", int count = 10)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }

        //Part 7 Call By Reference And Call By Value

        //Call By Value
        public static void Swap(int x, int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
            Console.WriteLine($"x in Swap = {x} , y in Swap  = {y}");
        }
      //  Call By Reference
        public static void SwapReference(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
          Console.WriteLine($"x in Swap = {x} , y in Swap  = {y}");
        }

        //Part 8  Calling With Regference Type
        public static int ArrayEdited(int[] array)
        {
            int sum = 0; 
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                { 
                sum += array[i];
                }
            array[0] = 100;
            

            }
            return sum;
        
        
        }

        //Part 9

        public static void SumMull(int x , int y,out int sum,out int mull)
        {
            sum = x + y;
            mull = x * y;


        
        }

        static void Main(string[] args)
        {









            #region Session 4

            #region  1-String And  StringBilder

            #region 1-String 
            //string Name1 = "ali";
            //string Name2 = "saad";
            //Name2 = Name1; // name2 = ali 
            //Name1 = "omar";
            //Console.WriteLine($"Name1 : {Name1}");//omar
            //Console.WriteLine($"Name2 : {Name2}");//ali 
            ////when change value of string => ther is new object create 

            #endregion
            #region  2-StringBilder 
            //StringBuilder sb = new StringBuilder();
            //sb.Append("ali");
            //Console.WriteLine(sb);              //ali
            //Console.WriteLine(sb.GetHashCode());// 46104728
            //Console.WriteLine("==================================");
            //sb.Append(" saad");
            //Console.WriteLine(sb);              //ali saad
            //Console.WriteLine(sb.GetHashCode());// 46104728
            //Console.WriteLine("==================================");
            //sb.Clear();
            //sb.Append("mohamed");
            //Console.WriteLine(sb);               //mohamed
            //Console.WriteLine(sb.GetHashCode()); // 46104728
            ////if you want to add or  change 

            #endregion

            #endregion
            #region  2-Array
            //int[] array;
            ////CLR => Will Allocate Bytes In Stack For Reference 
            ////CLR => Will Allocate 0 Byte At Heap 

            //array = new int[10];
            ////CLR => Will Allocate 12 Byte in Heap 
            ////Initialize Default Value Of Int = 0 At Heap


            ////1 
            //int[] array2 = new int[10] {1,2,34,5,6,7,8,9,34,43 };
            ////2
            //int[] array3 = {1,2,3,4,5,6,7 };
            ////Tp Print Array Element Use for 
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write(array3[i]+" ");
            //}
            //Console.WriteLine(  " ");

            //Console.WriteLine("Type Of Array : "+array2.Rank);
            #endregion
            #region 3-Array 2Dimention 


            //////2Dimention Array 
            ////int[,] array = new  int[2, 3] { { 10, 20, 30 } ,  { 10, 20, 30 }  };
            ////Console.WriteLine("Length OF Array : "+array.Length);
            ////Console.WriteLine(" Type Of Array  : "+array.Rank);

            //////2Dimention Array 


            //int[,] Array = new int [2,3];
            ////             sbject1  |  sbject2  |  sbject3  |
            ////student 1 :           |           |           |
            ////student 2 :           |           |           |
            //Console.WriteLine(Array.GetLength(0));//Row     // 2
            //Console.WriteLine(Array.GetLength(1));//columns // 3

            //Console.WriteLine("Length Of Array : "+Array.Length);
            //for (int i = 0; i < Array.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Student Number {i+1}");
            //    for (int j = 0; j < Array.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter Subject ({j+1})  Of Student ({i + 1}) : ");
            //        Array[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}

            ////To Print
            //Console.WriteLine("Print Array : : : ");
            //for (int i = 0; i < Array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Array.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Student ({i+1})  dgree of Subject ({j + 1}) = {Array[i, j]}"  );
            //    }

            //}





            #endregion
            #region  4-Judget Array
            ////Array Contain Number Of Array
            //int[][] array = new int[3][];

            //array[0]  = new int[] {1,2,3 };
            //array[1] = new int [] {4,5};
            //array[2] = new int [] {6};


            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        Console.Write(array[i][j]+" ");
            //    }

            //}

            #endregion
            #region 5-Array Methods
            #region Class Method
            //int[] A1 = { 1, 2, 4, 5, 3, 1, 34, 54, 22 };
            //int[] A2 = new int[5];

            ////1-Sort Method 
            //Array.Sort(A1);

            //foreach (int i in A1)
            //{
            //    Console.Write(i+" "); //1 1 2 3 4 5 22 34 54
            //}
            //Console.WriteLine("");
            //Console.WriteLine("__________________");
            ////2-Copy Method 
            //Array.Copy(A1,A2,5); //If Number > 5 Occure Error 

            //foreach (int i in A2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("__________________");


            //3-ConstrainedCopy Method
            //Array.ConstrainedCopy(A1, 0, A2, 0, 5);

            //foreach (int i in A2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("__________________");
            //#endregion





            #endregion
            #region Object Method
            //int[] A1 = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] A2 = new int[10];
            ////1-Length
            //Console.WriteLine(A1.Length);
            ////2-SetValue    ToEditAtValue
            //A1.SetValue(100, 0);
            //Console.WriteLine(A1[0]);//100
            ////3-CopyTo 
            //A1.CopyTo(A2, 2); //A[0]=0 , A[1]=0
            //foreach (int i in A2) Console.Write(i+" ");//0 0 100 2 3 4 5 6 7 0

            #endregion







            #endregion
            #region 6-Function
            ////Call Function 
            //Program.Print("#", 10);// import if function in anter class 
            //Print("#",10);         //Pass By Order
            ////Call With Defualt 
            //Print();
            //Print("()");
            //// Print(11);Occur Error لان القيمه الاولي للبترن 
            ////Call By NAme Of Parameter
            //Print(count:100,Pattern:")()("); // Possible wirhout Order 
            //Print(count:100);//صح 
            //Print(Pattern: "))"); //صح


            #endregion
            #region 7-Call By Reference And Call By Value
            #region Call By Value 
            //int x = 10, y = 20;
            //Console.WriteLine($"x = {x} , y = {y}");//10 , 20 
            //Console.WriteLine("==========================================");
            //Swap(x, y);   // x=20 , y=10
            //Console.WriteLine("==========================================");
            //Console.WriteLine($"x = {x} , y = {y}"); // 10 , 20 
            //                                         //change not change in the basic variable 

            #region



            #endregion
















            #endregion

            #region Call BY Reference 


            //int x = 10, y = 20;
            //Console.WriteLine($"x = {x} , y = {y}");//10 , 20 
            //Console.WriteLine("==========================================");
            //SwapReference(ref x, ref y);  // x=20 , y=10
            //Console.WriteLine("==========================================");
            //Console.WriteLine($"x = {x} , y = {y}"); // 20, 10
            //                                         // change in the basic variable 
            #endregion


            #endregion

            #region 8-EX About Data Reference Type

            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //foreach (int x in array)
            //{
            //    Console.Write(x+" ");
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("=======================================");
            //ArrayEdited(array);
            //Console.WriteLine("Function Edited Occured ");
            //Console.WriteLine("=======================================");

            //foreach (int x in array)
            //{
            //    Console.Write(x + " ");
            //}
            ////Value change After Use Function 
            ////Because we use Reference Type
            #endregion


            #region 9-Call By Out
            //Ues when i want to return 2 or more value from Function 

            //Call Function 
            int sum;
            int mull;
            SumMull(5, 10, out sum, out mull);
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Mull : {mull}");

            #endregion








            #endregion
            #region Assignments 4

            #endregion


        }

    }

}


