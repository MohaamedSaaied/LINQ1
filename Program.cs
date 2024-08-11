using System.Text;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region C# keyword :implicitly typed local varibale [var-dynamic}

            #region var

            //// Compiler will detect datatype of local varible based on inital value
            //// Must be initialized
            //// Can't initializee local variablw with null 

            //var data01 = "ahmed";

            //// var x = 12;

            //// var x; invalid 

            //// var x = null; invalid 

            ////data01 = 12; invalid

            #endregion

            #region Dynamic

            ////dynamic

            //dynamic data02 = "ahmed";  //like vat in javascript

            //// CLR will detect datatype of local varible based on last value at runtime
            //// Dont need to be initialized
            //// Cant initialize local variable with null
            //// Can change datatype of local variable after initialization
            //// Can use dynamic as parameter or returntype
            //// Be carful when using dynamic keyword


            //data02 = 12;
            //Console.WriteLine(data02.GetType.Name);
            //data02 = 'a';
            //Console.WriteLine(data02.GetType.Name);
            //data02 = 1.9;
            //Console.WriteLine(data02.GetType.Name);
            //data02 = new StringBuilder("");
            //dynamic x;
            //Console.WriteLine(data02.GetType.Name);

            #endregion

            #endregion

            #region extention method

            //int number = 12345; //54321

            ////var result = intExtention.Reverse(number);

            ////Console.WriteLine(result);

            //Console.WriteLine(number.Reverse());

            #endregion

            #region Anonymous Types


            //employee emp01 = new employee(1, "ahmed", 12000);

            //var emp02 = new { id = 1, name = "ahmed", salary = 12000 };//anonymous

            //var emp03 = emp02;

            //Console.WriteLine(emp01.GetType().Name);
            //Console.WriteLine(emp02.GetType().Name);

            // The same Anonymous as long as
            // 1.the prop Naming [Case sansitive]
            // 2.the prop order
            // 3.the prop datetype
            #endregion

            #region LINQ overview

            ////+40 Extension Metods
            ////13 category
            //// LINQ operators Exist Class "IEnumerable"

            //// sequence :object from class Implement Interface "IEnumrable"

            ////Local seq: L2O , L2XML
            ////remote seq: L2EF

            ////input sequence -->LINQ operator---> output seq
            ////input sequence -->LINQ operator---> one value
            ////               -->LINQ operator---> output Sequence

            //List<int> num= new List<int>() {1,2,3,4,5,6 };

            ////var res= Enumerable.Where(num, N => N % 2 == 0);

            //num.Any();
            //var res = Enumerable.Range(1, 100);

            //foreach (var x in res)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region LINQ Syntax

            //// 1. Fluent Syntax
            //// use LINQ methods
            //// 1.1. LINQ Operator As => Class member method through class Enumbrable

            //List<int> num = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

            ////where

            //var res = Enumerable.Where(num, N => N % 2 == 0);

            //foreach (var x in res)
            //{
            //    Console.WriteLine(" " + x);
            //}


            //// 1.1. LINQ Operator As =>  Extension methods through the seq ( Recommended )

            //var res1 = num.Where(N => N % 2 == 0);
            //foreach (var x in res1)
            //{
            //    Console.WriteLine(" " + x);
            //}

            //// 2. Query Syntax (Query Expression) like SQL style
            //// Start with from 
            //// End with select or group by 
            //// Query Synatx easier than fluent (join, group by ,let ,into)

            //List<int> num = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

            //var res2 = from N in num where N % 2 == 0 select N;

            //foreach (var x in res2)
            //{
            //    Console.WriteLine(" " + x);
            //}


            #endregion

            #region LINQ Execution ways

            // 1.Differed Execution Way : 10 Category
            //2. Inidiate Execution Way : Category ( Elements Operator - Casting Operators - Aggregate Operators )

            //List<int> num = new List<int>() { 1, 2, 3, 4 , 5, 6, 7, 8 , 9};

            //var res3 = num.Where(N=>N % 2 == 0).TOList() ;// where is differed

            //num.AddRange(new int[] { 10, 11, 12 });

            //foreach (var x in res2)
            //{
            //    Console.WriteLine(" " + x);
            //}

            #endregion

            #region

            Console.WriteLine(ListGenerator.ProductsList[0]);
            Console.WriteLine(" ");
            Console.WriteLine(ListGenerator.CustomersList[0]);
            
            #endregion

        }
    }
}
