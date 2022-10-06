using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStack<T>
    {
        public T[] arr;
        public int pointer;
       

        public CustomStack()
        {
            arr=new T[10];
            pointer = 0;
        }

        public void Push(T str)
        {
            
            arr[pointer] = str;
            pointer++;

        }

        public int Count()
        {
            return pointer;
        }

        public T Pop()
        {
            pointer--;
            T str=arr[pointer];
            

            return str;
        }


    }
}
