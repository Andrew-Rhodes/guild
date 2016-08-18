using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.FileRepos;
using FlooringProject.Data.InMemoryRepos;
using FlooringProject.Data.Interfaces;

namespace FlooringProject.Data.Factories
{
    public class StateRepositoryFactory
    {
        public static IState CreateStateRepository()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            IState repo;
            switch (mode.ToUpper())
            {
                case "TEST":
                    repo = new InMemoryStateRepository();
                    break;

                case "PROD":
                    repo = new FileStateRepository();
                    break;
                default:
                    throw new Exception("No such repository, check your settings");
            }
            return repo;
        }
    }
}
