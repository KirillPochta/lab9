using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Director
    {
        public delegate void DirectorHandler(string message);
        public event DirectorHandler Promote;
        public event DirectorHandler Punishment;

        public string name;
        public int money;
        public int position;

        public Director(string name, int money, int position)
        {
            this.name=name;
            this.money = money;
            this.position = position;
        }
        
        public void Improved() 
        {
            if (position > 1)
            {
                
                money += 10;
                if (Promote != null) { Promote?.Invoke($"{name} get {position} position and 10 money's"); }
                if (position == 1) Console.WriteLine($"{name} get max position ");
         
            }
        }
        public void Reduced()
        {
            if (money > 0)
            {
                position -= 1;
                money -= 5;
                if (Punishment != null)
                {
                    Punishment?.Invoke($"{name} was fine on 5 and have {position} position");
                    if (money <= 0) { money = 0; Console.WriteLine($"{name} end up money now!"); }
                }
                Console.WriteLine($"{name} now have {money} money's");
            }
            else Console.WriteLine($"{name} no money's");
        }
    }
}
