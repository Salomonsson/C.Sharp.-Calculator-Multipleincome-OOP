using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApplicationEASTER
{
    public class ClassFunctions : ClassMultipleIncome
 {
        internal int Substract(int x, int y){
            return x - y;
        }

        internal int Multiply(int x, int y){
            return x * y;
        }

        internal int Add(int x, int y){
            return x + y;
        }

        internal int Divide(int x, int y){
            return x / y;
        }
    }


 public class ClassUserActivity{
        public static int inData1 { get; set; }
        public static int inData2 { get; set; }
        public static string inString { get; set; }
    }


 public class Program
    {
        static void Menu(){
            Console.WriteLine("1. Multiplikation" +
               Environment.NewLine + "2. Additation" +
                 Environment.NewLine + "3. Division" +
                     Environment.NewLine + "4. Substraktion" +
                         Environment.NewLine + "5. Multi list" +
                             Environment.NewLine + "6. Exit");
        }

        static string tal1() {
            return "Tal 1: ";
        }
        static string tal2(){
            return "Tal 2: ";
        }

public enum Operator{
            Multiplication = 1,
            Addition,
            Division,
            Substraction,
            MultipleAddition,
            Exit
    }


public static void Main(string[] args){

                //Get instance
                ClassDisplayCalculator display = new ClassDisplayCalculator();
                Menu();
                
                // get value user provided
                int OperatorInt = Int32.Parse(Console.ReadLine());
                Operator IncomeInteger = (Operator)OperatorInt;

                switch (IncomeInteger)
                {
                    case Operator.Multiplication:
                                    Console.WriteLine("Case1 - Multiplikation");
                                    Console.WriteLine("Skriv in två heltal.");

                                    Console.Write(tal1());
                                    ClassUserActivity.inData1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write(tal2());
                                    ClassUserActivity.inData2 = Convert.ToInt32(Console.ReadLine());

                                    //DisplayMultiplication
                                    display.DisplayMultiplication(ClassUserActivity.inData1, ClassUserActivity.inData2);
                                    Main(args);
                        break;

                    case Operator.Addition:
                                    Console.WriteLine("Case2 - Addition");
                                    Console.WriteLine("Skriv in två heltal.");
            
                                     Console.Write(tal1());
                                     ClassUserActivity.inData1 = Convert.ToInt32(Console.ReadLine());
                                     Console.Write(tal2());
                                     ClassUserActivity.inData2 = Convert.ToInt32(Console.ReadLine());
            
                                     //DisplayAddition
                                     display.DisplayAddition(ClassUserActivity.inData1, ClassUserActivity.inData2);
                                     Main(args);
                        break;

                    case Operator.Division:
                                    Console.WriteLine("Case3 - Division");
                                    Console.WriteLine("Skriv in två heltal.");
            
                                    Console.Write(tal1());
                                    ClassUserActivity.inData1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write(tal2());
                                    ClassUserActivity.inData2 = Convert.ToInt32(Console.ReadLine());
            
                                    //DisplayDivision
                                    display.DisplayDiv(ClassUserActivity.inData1, ClassUserActivity.inData2);
                                    Main(args);
                        break;

                    case Operator.Substraction:
                                    Console.WriteLine("Case4 - Substraktion");
                                    Console.WriteLine("Skriv in två heltal.");
            
                                    Console.Write("Skriv in tal 1: ");
                                    ClassUserActivity.inData1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Skriv in tal 2: ");
                                    ClassUserActivity.inData2 = Convert.ToInt32(Console.ReadLine());
            
                                    //DisplaySubstraction
                                    display.DisplaySub(ClassUserActivity.inData1, ClassUserActivity.inData2);
                                    Main(args);
                        break;

                    case Operator.MultipleAddition:
                                  Console.WriteLine("MULTI = Addition - Substraktion, Press Q for menu.");
                                  Console.WriteLine();
                                  int uInt;
                                  
                                //Do while if readline is not null or "q"
                                      do
                                      {
                                          uInt = 0;
                                          ClassUserActivity.inString = Console.ReadLine();
                                          display.DisplayMultipleIncome(ClassUserActivity.inString);
                                      } while (uInt != null);
                        break;

                    case Operator.Exit:
                                Console.WriteLine("Du har tryckt noll!");
                                Environment.Exit(0);
                        break;
                }
            Console.ReadKey();
        }
    }


//NOTIS!! -----  class UserActivity->MultipleIncome->Function->Display.... Inheritence

public class ClassMultipleIncome {

   protected List<int> MultipleIncomeList = new List<int>();
   protected int listSumma;
   
    //Add to list
   protected void AddtoList(int x){
        MultipleIncomeList.Add(x);
    }
     
   protected int ShowSum(){
          listSumma = MultipleIncomeList.Sum();
          return listSumma;
     }

      // Loop out the items.
  protected void ShowAllItemsInList(){
          foreach (int value in this.MultipleIncomeList ){
                Console.Write(" + {0}",value);
          }
      }
 }

  

public class ClassDisplayCalculator  : ClassFunctions{
    //Constructor
    public ClassDisplayCalculator() {
        Console.WriteLine("****En simpel minräknare!*****");
        Console.WriteLine();
    }
    
    
  internal void DisplayAddition(int x, int y){
                Console.Write("Svar: {0} + {1} = ", x, y);
                Console.WriteLine(this.Add(x, y));
                Console.ReadLine();
            }

 internal void DisplayDiv(int x, int y){
                Console.Write("Svar: {0} / {1} = ", x, y);
                Console.WriteLine(this.Divide(x, y));
                Console.ReadLine();
            }

 internal void DisplaySub(int x, int y){
                Console.Write("Svar: {0} - {1} = ", x, y);
                Console.WriteLine(this.Substract(x, y));
                Console.ReadLine();
            }

  internal void DisplayMultiplication(int x, int y){
                Console.Write("Svar: {0} * {1} = ", x, y);
                Console.WriteLine(this.Multiply(x,y));
                Console.ReadLine();
            }

  internal void DisplayMultipleIncome(string checkString){
            int validInteger;
            bool ifValidInteger = int.TryParse(checkString, out validInteger);

            if (ifValidInteger){
                Console.Clear();
                this.AddtoList(validInteger);
                Console.WriteLine("*******");

                //Show all items in list
                this.ShowAllItemsInList();
                Console.WriteLine();
                Console.WriteLine("Total Summa = {0}", this.ShowSum());
                Console.Write("Skriv in tal: ");
            }
            else if (checkString.Contains("q")){
                Console.Clear();
                Console.WriteLine("DU HAR VALT ATT AVSLUTA!");
                //Main(args);
                //Program.Main();
            }
            else{
                Console.Clear();
                Console.WriteLine("Endast siffror!");
            }
        }
        
        
 }
}


