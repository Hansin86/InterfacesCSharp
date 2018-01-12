using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Factory_pattern
{
    public class CsvRepository : IPersonRepository
    {
        public IEnumerable GetPeople()
        {
            throw new NotImplementedException();
        }
    }
}
