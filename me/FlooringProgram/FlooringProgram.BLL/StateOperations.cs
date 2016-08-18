using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Factories;
using FlooringProject.Data.FileRepos;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProgram.BLL
{
    public class StateOperations
    {
        public State GetStateByName(string name)
        {
            IState repo = StateRepositoryFactory.CreateStateRepository();

            return repo.GetStateName(name);
        }
    }
}
