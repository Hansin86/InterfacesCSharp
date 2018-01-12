using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Factory_pattern
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repositoryType)
        {
            IPersonRepository repo = null;
            switch(repositoryType)
            {
                case "Service": repo = new ServiceRepository();
                    break;
                case "CSV":
                    repo = new CsvRepository();
                    break;
                case "SQL":
                    repo = new SqlRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }

            return repo;
        }
    }
}
