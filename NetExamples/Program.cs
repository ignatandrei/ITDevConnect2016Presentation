using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.ConsoleColor;
namespace NetExamples
{
    /// <summary>
    /// https://msdn.microsoft.com/en-us/magazine/dn879355.aspx
    /// https://sachabarbs.wordpress.com/2016/04/19/entity-framework-7-in-memory-provider-test/
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Andrei";
            //auto property
            Console.WriteLine(p.MaxAge);
            //string.format
            Console.WriteLine($"The age is {p.MaxAge}");
            //string format inside
            Console.WriteLine(p.ToDebug());
            //nameof
            p.LogMethod(3);
            //exception when
            p.ExceptionForMonday();
            //static using
            var c = Console.ForegroundColor;
            Console.ForegroundColor = Red;
            Console.WriteLine("using static System.ConsoleColor");
            Console.ForegroundColor = c;
            //expression bodies
            Console.WriteLine(p.HasRightToDrive);
            Console.WriteLine(p.HasRightToDrive1());
            //null conditional operator
            p = null;
            bool? x = p?.HasRightToDrive;
            Console.WriteLine($"{nameof(x)} has a value : {x.HasValue}");
        }
    }
}
