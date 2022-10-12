using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICustomStack<IIntern> : ICustomStackReadonly<IIntern>
    {
        IIntern Pop();
    }
    public interface ICustomStackReadonly<in IIntern> 
    {
        void Push(IIntern value);
        int Count();
        
    }

    
}
