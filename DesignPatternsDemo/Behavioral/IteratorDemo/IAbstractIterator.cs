using System;
using System.Collections.Generic;
using System.Text;

namespace BehavoiuralIterator
{
   public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
