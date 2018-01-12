using InterfacesCSharp.Explicit_interfaces;
using InterfacesCSharp.Factory_pattern;
using InterfacesCSharp.Shapes;
using System;
using System.Collections;

namespace InterfacesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable enums;
            int[] arr = new int[2];
            Octagon oc;

            // Explicit interfaces: depending on which object type is chosen (concrete or one of the interfaces),
            // different Save method can be executed
            ImplementationClass impClass = new ImplementationClass();
            ISaveable saveable = new ImplementationClass();
            IPersistable persistable = new ImplementationClass();
            impClass.Save(); //Save implementation from ImplementationClass
            saveable.Save(); //Save implementation from ISaveable, if no explicit implementation, then uses standard Save from implementation class
            persistable.Save(); //Save implementation from IPersistable, then uses standard Save from implementation class
            ((ISaveable)impClass).Save(); //Save implementation from ISaveable
            ((IPersistable)impClass).Save(); //Save implementation from IPersistable

            IPersonRepository repo = DynamicRepositoryFactory.GetRepository();
            var result = repo.GetPeople();

            Console.WriteLine("Hello World!");
        }
    }
}
