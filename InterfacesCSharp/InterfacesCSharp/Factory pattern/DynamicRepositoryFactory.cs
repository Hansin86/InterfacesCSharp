using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Factory_pattern
{
    /// <summary>
    /// 
    /// </summary>
    public static class DynamicRepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            // Get repository type from some configurations: config / db / other
            //string typeName = ConfigurationManager.AppSettings[];

            string typeName = "InterfacesCSharp.Factory_pattern.ServiceRepository";
            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPersonRepository repo = repoInstance as IPersonRepository;
            return repo;
        }
    }
}
