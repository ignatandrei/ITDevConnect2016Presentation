using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetExamples
{

    public class Person
    {
        public static int MinAgeForDriving{get;}=18;

        public int MaxAge{get;private set;}=200;
        
        public int Age{get;set;}
        public string Name{get;set;}

        internal string ToDebug()
        {
          
            var q=  $"Name = {Name:0}";  
            return q; 
        }
        public void LogMethod(int x13){
            System.Console.WriteLine(
                $"in method {nameof(LogMethod)} with argument {nameof(x13)} value {x13}"
                );
        }
        public bool HasRightToDrive=>Age>=18;
        public bool HasRightToDrive1()=>Age>=18;
        public void ExceptionForMonday(){
            try{
                int x=1;
                x--;
                x=x/x;
            }
            catch (Exception e) when (
              (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
              || (DateTime.Now.DayOfWeek == DayOfWeek.Sunday
)) {
            //just log for monday
            }
    }
            
   }
}