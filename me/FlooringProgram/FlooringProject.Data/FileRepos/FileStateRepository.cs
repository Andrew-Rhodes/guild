using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data.FileRepos
{
    public class FileStateRepository : IState
    {
        private const string FILENAME = @"DataFiles\States.txt";

        public static List<State> StateList = new List<State>();

        static FileStateRepository()
        {
            using (StreamReader sr = File.OpenText(FILENAME))
            {
                StateList = new List<State>();

                string inputLine = "";
                string[] inputParts;

                for (var i = 0; i < 1; i++)
                {
                    sr.ReadLine();
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        inputParts = inputLine.Split(',');
                        var thisState = new State()
                        {
                            StateAbbreviation = inputParts[0],
                            StateName = inputParts[1],
                            TaxRate = decimal.Parse(inputParts[2])
                        };

                        StateList.Add(thisState);
                    }
                }
            }
        }

        public State GetStateName(string name)
        {
            {
                var state = new State();

                var result = from i in StateList
                             where i.StateName == name
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
}
