using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Factory_pattern
{
    public interface IPersonRepository
    {
        IEnumerable GetPeople();
    }
}
