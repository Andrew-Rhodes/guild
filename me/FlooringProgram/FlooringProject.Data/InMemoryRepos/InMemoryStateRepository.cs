using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data.InMemoryRepos
{
    public class InMemoryStateRepository : IState
    {
        public List<State> StateList = new List<State>();



        public InMemoryStateRepository()
        {
            StateList.Add(new State()
            {
                StateAbbreviation = "OH",
                StateName = "Ohio",
                TaxRate = 6.25m
            });

            StateList.Add(new State()
            {
                StateAbbreviation = "PA",
                StateName = "Pennsylvania",
                TaxRate = 6.75m
            });

            StateList.Add(new State()
            {
                StateAbbreviation = "MI",
                StateName = "Michigan",
                TaxRate = 5.75m
            });

            StateList.Add(new State()
            {
                StateAbbreviation = "IN",
                StateName = "Indiana",
                TaxRate = 6.00m
            });
        }

        public State GetStateName(string stateName)
        {
            var state = new State();

            var result = from i in StateList
                         where i.StateName == stateName
                         select i;

            foreach (var state1 in result)
            {
                state.StateAbbreviation = state1.StateAbbreviation;
                state.StateName = state1.StateName;
                state.TaxRate = state1.TaxRate;
            }


            return state;
        }
    }
}
