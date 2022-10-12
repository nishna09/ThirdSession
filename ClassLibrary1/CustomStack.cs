using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStack<iIIntern> : ICustomStack<IIntern>
    {
        public IIntern[] arr;
        public int pointer;
       

        public CustomStack()
        {
            arr=new IIntern[10];
            pointer = 0;
        }

        public void Push(IIntern value)
        {
            
            arr[pointer] = value;
            pointer++;

        }

        public int Count()
        {
            return pointer;
        }

        public IIntern Pop()
        {
            pointer--;
            IIntern value=arr[pointer];
            

            return value;
        }


    }
}
