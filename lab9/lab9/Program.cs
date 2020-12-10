using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("exercise1");
            Director student = new Director("Kirill", 10, 2);
            student.Promote += message => Console.WriteLine(message);
            Director student2 = new Director("Petrov", 20, 3);
            student2.Promote += message => Console.WriteLine(message);
            student2.Punishment += message => Console.WriteLine(message);
            Director student3 = new Director("Vasiliy",30,4);
            student3.Promote += message => Console.WriteLine(message);
            student3.Punishment += message => Console.WriteLine(message);

            student.Improved();
            student.Reduced();
            student2.Improved();
            student2.Reduced();
            student3.Improved();
            student3.Reduced();

            Console.WriteLine("exercise2");
            string str = "hello my name booba!";
            Action<string> meth;
            meth = Application;
            meth += DeleteLetter;
            meth += AddLetterAfterLetter;
            meth += DeleteSpaces;
            meth += AddPointsAfterSpace;
            meth(str);
            Console.WriteLine(str);

        }
        public static void Application(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '!')
                    str.Remove(i, 1);
          
            }
        }
        public static void DeleteSpaces(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    str.Remove(i, 1);
            }

        }
        public static void DeleteLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'h')
                    str.Remove(i, 1);
            }
        }
        public static void AddLetterAfterLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'y')
                    str.Insert(i + 1, "S");
            }
        }
        public static void AddPointsAfterSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    str.Insert(i + 1, ".");
            }
        }

    }
   
            
        
    
}
