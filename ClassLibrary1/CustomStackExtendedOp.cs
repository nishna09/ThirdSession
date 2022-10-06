using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class CustomStackExtendedOp
    {
        public static void DisplayAllInternsNameAndId(CustomStack<Jedi> stack)
        {
            while (stack.Count() > 0)
            {
                Jedi jedi = stack.Pop();
                Console.WriteLine(jedi.GetNameId());
            }
        }
    }
}
