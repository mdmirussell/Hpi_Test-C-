using System;

namespace hpi_test{
    class test{
        public static void Main(string[] args){
            

    // For Loop
     Console.WriteLine("For Loop Start ");

      for (int i = 1; i <= 10;i++){
        Console.WriteLine("For Loop Run time {0}",i);
      }


// While Loop
     Console.WriteLine("While Loop Start ");
       int num = 1;
      while(num  <=10){ 
         Console.WriteLine("While Loop Run time {0}",num);
         num++;
      }

      // Do  while loop
      Console.WriteLine("Do While Loop Start ");
      int num2 = 1;
      do{
          Console.WriteLine("While Loop Run time {0}",num2);
          num2++;
      }while(num2 <= 10);
 
             
            Console.ReadKey();
        }
    }
}