using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Explicit_interfaces
{
    public class ImplementationClass : ISaveable, IPersistable
    {
        public ImplementationClass()
        {
        }

        public void Load()
        {

        }

        public string Save()
        {
            return "Catalog Save";
        }

        string ISaveable.Save()
        {
            return "ISaveable Save";
        }

        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
    }
}
