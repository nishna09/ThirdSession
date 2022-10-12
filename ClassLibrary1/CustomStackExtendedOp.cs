using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class CustomStackExtendedOp
    {
        public static void DisplayAllInternsNameAndId(ICustomStack<IIntern> stack)
        {
            while (stack.Count() > 0)
            {
                //Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop().GetNameId());
            }
        }


    }
}
