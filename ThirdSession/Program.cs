using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ThirdSession
{
  
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //var stack = new CustomStack<string>();
            //stack.Push("Jedi-X");
            //stack.Pop();
            //stack.Push("Jedi");
            //stack.Push("SkillsLab");
            //stack.Push(1);

            //while (stack.Count() > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            CustomStack<Jedi> customStack2 = new CustomStack<Jedi>();
            customStack2.Push(new Jedi("James", 1));
            customStack2.Push(new Jedi("Jane", 2));
            customStack2.Push(new Jedi("Frank", 3));


            CustomStackExtendedOp.DisplayAllInternsNameAndId(customStack2);
           

            Console.ReadLine();
        }
    }
}
